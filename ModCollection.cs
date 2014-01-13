using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AVTTLoaderStandalone
{
    public class ModCollection
    {
        public List<Mod> Mods { get; set; }
        public int Count
        {
            get
            {
                return Mods.Count;
            }
        }

        public ModCollection()
        {
            Mods = new List<Mod>();
        }

        public void AddMod(string name, List<string> parts)
        {
            var mod = new Mod(name, parts);
            Mods.Add(mod);
        }

        public ModCollection Clone()
        {
            var tmpMC = new ModCollection();
            foreach (var m in Mods)
            {
                tmpMC.Mods.Add(m.Clone());
            }
            return tmpMC;
        }
    }

    public class Mod
    {
        public string Name { get; set; }
        public List<string> Parts { get; set; }

        public Mod()
        {
            Parts = new List<string>();
        }

        public Mod(string name)
        {
            Name = name;
            Parts = new List<string>();
        }

        public Mod(string name, List<string> parts)
        {
            Name = name;
            Parts = parts;
        }

        public Mod Clone()
        {
            var tmpMod = new Mod(Name);
            foreach (var p in Parts)
            {
                tmpMod.Parts.Add(p);
            }
            return tmpMod;
        }
    }

    public class ModCollectionParser
    {
        public ModCollection Collection { get; set; }
        private string path = "modlist.cfg";

        public ModCollectionParser()
        {
            Collection = new ModCollection();
        }

        public ModCollectionParser(ModCollection mc)
        {
            Collection = mc;
            if (Collection == null) Collection = new ModCollection();
        }

        public void Load()
        {
            if (!File.Exists(path)) return;
            var modlistString = "";
            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    modlistString = modlistString + line + Environment.NewLine;
                }
            }

            var mods = Collection.Mods;
            var n = 0;
            var b = false;
            foreach (var str in Regex.Split(modlistString, Environment.NewLine))
            {
                switch (str.Trim())
                {
                    case "{":
                        n += 1;
                        b = true;
                        break;
                    case "}":
                        n -= 1;
                        b = false;
                        break;
                }

                if (!b) { continue; }

                switch (n)
                {
                    case 1:
                        if (str.Contains('=') == false)
                            break;

                        mods.Add(new Mod());

                        mods.Last().Name = str.Trim().Remove(0, str.LastIndexOf(char.Parse("=")) + 1).Trim();
                        break;
                    case 2:
                        if (str.Contains('=') == false)
                            break;
                        mods.Last().Parts.Add(str.Remove(0, str.LastIndexOf(char.Parse("=")) + 1).Trim());
                        break;
                }
            }
        }

        public void Save()
        {
            var mods = Collection.Mods;
            var newLine = Environment.NewLine;
            var cfgOutput = "";

            var file = new StreamWriter(path);

            foreach (var mod in mods)
            {
                cfgOutput += "MOD" + newLine + "{" + newLine;
                cfgOutput += "\tname = " + mod.Name + newLine;
                cfgOutput += "\tPARTS" + newLine + "\t{" + newLine;
                foreach (var part in mod.Parts)
                {
                    if (part.Length < 1) return;
                    cfgOutput += "\t\tname = " + part + newLine;
                }
                cfgOutput += "\t}" + newLine + "}" + newLine;
            }

            file.Write(cfgOutput);
            file.Close();
        }
    }
}
