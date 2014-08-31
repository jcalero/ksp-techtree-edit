using System.Collections.Generic;

namespace KSPTechTreeEditor
{
    /// <summary>
    /// Represents a tech tree structure.
    /// </summary>
    public class Tree
    {
        public List<Node> Nodes = new List<Node>();
        public string FilePath { get; set; }

        public Tree(string fileName)
        {
            FilePath = fileName;
        }
    }

    /// <summary>
    /// Represents a node in a tech tree. Can iterate through attributes by calling Attributes. Can iterate through parts by calling Parts.
    /// </summary>
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

        /// <summary>
        /// All the parts in this node
        /// </summary>
        public List<Attribute> Parts = new List<Attribute>();

        private readonly List<Attribute> _attributeList = new List<Attribute>();

        /// <summary>
        /// A list of all attributes in this node (not including the parts)
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return _attributeList; }
        }

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

            _attributeList.Add(Name);
            _attributeList.Add(TechId);
            _attributeList.Add(Pos);
            _attributeList.Add(Icon);
            _attributeList.Add(Cost);
            _attributeList.Add(Title);
            _attributeList.Add(Description);
            _attributeList.Add(AnyParent);
            _attributeList.Add(HideIfEmpty);
            _attributeList.Add(Parents);
        }
    }
}
