using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AVTTLoaderStandalone
{
    /// <summary>
    /// Tech tree parser and structure
    /// </summary>
    public static class Tree
    {
        public static List<Node> Nodes = new List<Node>();
        public static void Load(string cfg)
        {
            var n = 0;
            var b = false;
            foreach (var str in Regex.Split(cfg, "\r\n|\r|\n"))
            {
                switch (str.Trim())
                {
                    case "{":
                        n += 1;
                        b = true;
                        break;
                    case "}":
                        n -= 1;
                        break;
                }

                switch (n)
                {
                    case 1:
                        if (b) { Nodes.Add(new Node()); Nodes.Last().Parts = new List<Attribute>(); }
                        if (str.Contains('=') == false)
                            break;

                        var ss = new Attribute(str.Trim());
                        switch (ss.Item)
                        {
                            case "name":
                                Nodes.Last().Name.Value = ss.Value;
                                break;
                            case "techID":
                                Nodes.Last().TechId.Value = ss.Value;
                                break;
                            case "pos":
                                Nodes.Last().Pos.Value = ss.Value;
                                break;
                            case "icon":
                                Nodes.Last().Icon.Value = ss.Value;
                                break;
                            case "cost":
                                Nodes.Last().Cost.Value = ss.Value;
                                break;
                            case "title":
                                Nodes.Last().Title.Value = ss.Value;
                                break;
                            case "description":
                                Nodes.Last().Description.Value = ss.Value;
                                break;
                            case "anyParent":
                                Nodes.Last().AnyParent.Value = ss.Value;
                                break;
                            case "hideIfEmpty":
                                Nodes.Last().HideIfEmpty.Value = ss.Value;
                                break;
                            case "parents":
                                Nodes.Last().Parents.Value = ss.Value;
                                break;
                        }
                        break;
                    case 2:
                        if (str.Contains('=') == false)
                            break;

                        Nodes.Last().Parts.Add(new Attribute(str.Trim()));
                        break;
                }
                b = false;
            }
        }

        public static bool Save(string fileName)
        {
            var newLine = Environment.NewLine;
            var cfgOutput = "";
            StreamWriter file;

            try
            {
                 file = new StreamWriter(fileName);
            }
            catch (Exception)
            {
                return false;
                // TODO: HANDLE
            }

            foreach (var node in Nodes)
            {
                cfgOutput += "NODE" + newLine + "{" + newLine;

                foreach (var a in node.AttributeList)
                {
                    cfgOutput += "\t" + a.Item + " = " + a.Value + newLine;
                }

                cfgOutput += "\tPARTS" + newLine + "\t{" + newLine;
                foreach (var part in node.Parts)
                {
                    cfgOutput += "\t\t" + part.Item + " = " + part.Value + newLine;
                }

                cfgOutput += "\t}" + newLine + "}" + newLine;
            }

            file.Write(cfgOutput);
            file.Close();

            return true;
        }
    }
    public class Node
    {
        public Attribute Name = new Attribute();
        public Attribute TechId = new Attribute();
        public Attribute Pos = new Attribute();
        public Attribute Icon = new Attribute();
        public Attribute Cost = new Attribute();
        public Attribute Title = new Attribute();
        public Attribute Description = new Attribute();
        public Attribute AnyParent = new Attribute();
        public Attribute HideIfEmpty = new Attribute();
        public Attribute Parents = new Attribute();
        public List<Attribute> Parts = new List<Attribute>();

        public List<Attribute> AttributeList = new List<Attribute>();

        public Node()
        {
            Name.Item = "name";
            TechId.Item = "techID";
            Pos.Item = "pos";
            Icon.Item = "icon";
            Cost.Item = "cost";
            Title.Item = "title";
            Description.Item = "description";
            AnyParent.Item = "anyParent";
            HideIfEmpty.Item = "hideIfEmpty";
            Parents.Item = "parents";

            AttributeList.Add(Name);
            AttributeList.Add(TechId);
            AttributeList.Add(Pos);
            AttributeList.Add(Icon);
            AttributeList.Add(Cost);
            AttributeList.Add(Title);
            AttributeList.Add(Description);
            AttributeList.Add(AnyParent);
            AttributeList.Add(HideIfEmpty);
            AttributeList.Add(Parents);
        }
    }
}
