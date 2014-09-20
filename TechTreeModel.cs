using System.Collections.ObjectModel;
using KerbalParser;

namespace ksp_techtree_edit
{
	public class TechTreeModel
	{
		private readonly ObservableCollection<TechNode> _techTree =
			new ObservableCollection<TechNode>();

		public void AddTechNode(KerbalNode node)
		{
			var techNode = new TechNode(node);
			TechTree.Add(techNode);
		}

		public ObservableCollection<TechNode> TechTree
		{
			get { return _techTree; }
		}
	}
}
