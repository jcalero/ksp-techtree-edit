using System.Collections.ObjectModel;

namespace ksp_techtree_edit.ViewModels
{
	public class TechTreeViewModel : NotificationViewModel
	{
		#region Members

		#region Private

		private WorkspaceViewModel _workspaceViewModel;

		public TechTreeViewModel()
		{
			Connections = new ObservableCollection<ConnectionViewModel>();
			TechTree = new ObservableCollection<TechNodeViewModel>();
		}

		#endregion Private

		#region Public

		public ObservableCollection<TechNodeViewModel>
			TechTree { get; private set; }

		public ObservableCollection<ConnectionViewModel>
			Connections { get; private set; }

		public WorkspaceViewModel WorkspaceViewModel
		{
			get { return _workspaceViewModel; }
			set
			{
				if (_workspaceViewModel == value) return;
				_workspaceViewModel = value;
				OnPropertyChanged();
			}
		}

		#endregion Public

		#endregion Members

		#region Methods

		/// <summary>
		/// Searches through the tech tree and creates new connection models
		/// for each child-to-parent relationship. Connection models are stored
		/// in <see cref="Connections"/>.
		/// </summary>
		public void LinkNodes()
		{
			Connections.Clear();

			foreach (var node in TechTree)
				foreach (var parent in node.Parents)
				{
					Connections
						.Add(new ConnectionViewModel(node, parent));
				}
		}

		public void DeleteNode(TechNodeViewModel node)
		{
			TechTree.Remove(node);
			UnlinkParent(node);
			LinkNodes();
		}

		//TODO: Remove this terrible terrible method and replace with proper
		//MVVM model-viewmodel dependencies.
		public void UnlinkParent(TechNodeViewModel parentToRemove)
		{
			foreach (var node in TechTree)
			{
				if (node.Parents.Contains(parentToRemove))
				{
					node.Parents.Remove(parentToRemove);
				}
			}
		}

		#endregion Methods
	}
}
