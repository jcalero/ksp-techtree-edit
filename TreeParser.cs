using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AVTTLoaderStandalone
{
    /// <summary>
    /// Parser and writer for tree.cfg files
    /// </summary>
    class TreeParser
    {
        /// <summary>
        /// The file path to the tree.cfg
        /// </summary>
        public string Path { get; private set; }
        /// <summary>
        /// The tree bound to this parser instance
        /// </summary>
        public Tree Tree { get; private set; }

        /// <summary>
        /// Constructs a TreeParser instance bound to a specific file
        /// </summary>
        /// <param name="path">The full path to the tree.cfg</param>
        public TreeParser(string path)
        {
            Path = path;
            Tree = Load(path);
        }

        /// <summary>
        /// Parses a tree.cfg file into a Tree class
        /// </summary>
        /// <param name="path">Full path to tree.cfg</param>
        /// <returns>A Tree class with Nodes corresponding the tree.cfg data</returns>
        private static Tree Load(string path)
        {
            var treeString = "";
            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    treeString = treeString + line + Environment.NewLine;
                }
            }

            var tree = new Tree(path);
            var nodes = tree.Nodes;
            var n = 0;
            var b = false;
            foreach (var str in Regex.Split(treeString, Environment.NewLine))
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
                        if (b) { nodes.Add(new Node()); nodes.Last().Parts = new List<Attribute>(); }
                        if (str.Contains('=') == false)
                            break;

                        var ss = new Attribute(str.Trim());
                        switch (ss.Item)
                        {
                            case "name":
                                nodes.Last().Name.Value = ss.Value;
                                break;
                            case "techID":
                                nodes.Last().TechId.Value = ss.Value;
                                break;
                            case "pos":
                                nodes.Last().Pos.Value = ss.Value;
                                break;
                            case "icon":
                                nodes.Last().Icon.Value = ss.Value;
                                break;
                            case "cost":
                                nodes.Last().Cost.Value = ss.Value;
                                break;
                            case "title":
                                nodes.Last().Title.Value = ss.Value;
                                break;
                            case "description":
                                nodes.Last().Description.Value = ss.Value;
                                break;
                            case "anyParent":
                                nodes.Last().AnyParent.Value = ss.Value;
                                break;
                            case "hideIfEmpty":
                                nodes.Last().HideIfEmpty.Value = ss.Value;
                                break;
                            case "parents":
                                nodes.Last().Parents.Value = ss.Value;
                                break;
                        }
                        break;
                    case 2:
                        if (str.Contains('=') == false)
                            break;

                        nodes.Last().Parts.Add(new Attribute(str.Trim()));
                        break;
                }
                b = false;
            }
            return tree;
        }

        /// <summary>
        /// Saves a Tree object to the file specified
        /// </summary>
        /// <param name="fileName">The filename to save it to</param>
        private void Save(string fileName)
        {
            var nodes = Tree.Nodes;
            var newLine = Environment.NewLine;
            var cfgOutput = "";

            var file = new StreamWriter(fileName);

            foreach (var node in nodes)
            {
                cfgOutput += "NODE" + newLine + "{" + newLine;

                foreach (var a in node.Attributes)
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
        }

        /// <summary>
        /// Saves the tree to the filename property of the tree
        /// </summary>
        public void Save()
        {
            Save(Tree.FilePath);
        }

        /// <summary>
        /// Saves a Tree object to the file specified. Overrides the default file name property of the tree.
        /// </summary>
        /// <param name="path">The file path to save it to</param>
        public void SaveTo(string path)
        {
            Save(path);
        }
    }
}
