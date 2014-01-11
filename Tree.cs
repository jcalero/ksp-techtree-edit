using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AVTTLoaderStandalone
{
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

                        var ss = (Attribute) str.Trim();
                        switch (ss.Item)
                        {
                            case "name":
                                Nodes.Last().Name = ss;
                                break;
                            case "techID":
                                Nodes.Last().TechId = ss;
                                break;
                            case "pos":
                                Nodes.Last().Pos = ss;
                                break;
                            case "icon":
                                Nodes.Last().Icon = ss;
                                break;
                            case "cost":
                                Nodes.Last().Cost = ss;
                                break;
                            case "title":
                                Nodes.Last().Title = ss;
                                break;
                            case "description":
                                Nodes.Last().Description = ss;
                                break;
                            case "anyParent":
                                Nodes.Last().AnyParent = ss;
                                break;
                            case "hideIfEmpty":
                                Nodes.Last().HideIfEmpty = ss;
                                break;
                            case "parents":
                                Nodes.Last().Parents = ss;
                                break;
                        }
                        break;
                    case 2:
                        if (str.Contains('=') == false)
                            break;

                        Nodes.Last().Parts.Add((Attribute) str.Trim());
                        break;
                }
                b = false;
            }
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
        }
    }
}
