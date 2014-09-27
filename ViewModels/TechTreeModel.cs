using System.Collections.ObjectModel;

namespace ksp_techtree_edit.ViewModels
{
	public class TechTreeModel
	{
		private readonly ObservableCollection<TechNodeModel> _techTree =
			new ObservableCollection<TechNodeModel>();

		private readonly ObservableCollection<ConnectionModel> _connections =
			new ObservableCollection<ConnectionModel>();

		public ObservableCollection<TechNodeModel> TechTree
		{
			get { return _techTree; }
		}

		public ObservableCollection<ConnectionModel> Connections
		{
			get { return _connections; }
		}

		public void LinkNodes()
		{
			foreach (var node in TechTree)
				foreach (var parent in node.Parents)
				{
					_connections.Add(new ConnectionModel(node, parent));
				}
		}
	}
}
