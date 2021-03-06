using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using KerbalParser;
using ksp_techtree_edit.Properties;
using ksp_techtree_edit.Util;
using ksp_techtree_edit.ViewModels;
using Microsoft.Win32;

namespace ksp_techtree_edit.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private KerbalConfig _config;
		private TechTreeViewModel _treeData;

		public MainWindow()
		{
			InitializeComponent();
			_treeData = TechTreeDiagram.TechTreeGrid.DataContext
			            as TechTreeViewModel;

			if (_treeData == null) return;
			var workspaceViewModel = new WorkspaceViewModel();
			_treeData.WorkspaceViewModel = workspaceViewModel;

			var sidebar = MainSideBar.DataContext as TechTreeViewModel;
			if (sidebar == null) return;
			sidebar.WorkspaceViewModel = workspaceViewModel;

			ContentGrid.DataContext = workspaceViewModel;
			DataContext = workspaceViewModel;
		}

		public KerbalConfig ParseTree(string path)
		{
			var parser = new Parser();
			return parser.ParseConfig(path);
		}

		public void FindParts(TreeType type = TreeType.TechMananger)
		{
			var partCollectionViewModel = MainSideBar.PartsListBox.DataContext
			                              as PartCollectionViewModel;

			if (partCollectionViewModel == null) return;
			partCollectionViewModel.LoadParts(Settings.Default.KspPath);

			var sidebar = MainSideBar.DataContext as TechTreeViewModel;
			if (sidebar == null) return;
			sidebar.PartCollectionViewModel = partCollectionViewModel;
			_treeData.PartCollectionViewModel = partCollectionViewModel;

			foreach (var node in _treeData.TechTree)
			{
				node.PopulateParts(partCollectionViewModel, type);
			}
		}

		public void NewTree()
		{
			ResetTree();
		}

		public void LoadTree(string path, TreeType treeType = TreeType.TechMananger)
		{
			ResetTree();

			var nameNodeHashtable = new Dictionary<string, TechNodeViewModel>();

			if (_treeData == null)
			{
				return;
			}

			_config = ParseTree(path);

			switch (treeType)
			{
				case TreeType.TechMananger:
					var techNodes =
						_config.
							First(
							      child =>
							      child.Name == "TECHNOLOGY_TREE_DEFINITION").
							Children.Where(node => node.Name == "NODE").
							ToArray();

					foreach (var node in
						techNodes.Where(
						                kerbalNode =>
						                kerbalNode.Values.ContainsKey("name")))
					{
						var v = node.Values;
						var name = v["name"].First();
						TechNodeViewModel techNodeViewModel;

						if (nameNodeHashtable.ContainsKey(name))
						{
							techNodeViewModel = nameNodeHashtable[name];
						}
						else
						{
							techNodeViewModel = new TechNodeViewModel();
							nameNodeHashtable.Add(name, techNodeViewModel);
						}

						techNodeViewModel.TechNode.PopulateFromSource(node);

						if (v.ContainsKey("parents"))
						{
							var parentsString = v["parents"].First();
							var parents = parentsString.Split(',');

							foreach (var parent
								in parents.
									Where(
									      parent =>
									      !nameNodeHashtable.ContainsKey(parent)))
							{
								nameNodeHashtable.Add(parent, new TechNodeViewModel());
							}

							foreach (var parent
								in parents
									.Where(
									       parent => !String.IsNullOrEmpty(parent) &&
									                 nameNodeHashtable.
										                 ContainsKey(parent)))
							{
								techNodeViewModel.Parents.Add(nameNodeHashtable[parent]);
							}
						}

						_treeData.TechTree.Add(techNodeViewModel);
					}
					break;

				case TreeType.ATC:
					var atcNodes =
						_config.First(child => child.Name == "TECH_TREE").
						        Children.Where(node => node.Name == "TECH_NODE").
						        ToArray();

					foreach (var node in
						atcNodes.Where(
						               kerbalNode =>
						               kerbalNode.Values.ContainsKey("name")))
					{
						var v = node.Values;
						var name = v["name"].First();
						TechNodeViewModel techNodeViewModel;

						if (nameNodeHashtable.ContainsKey(name))
						{
							techNodeViewModel = nameNodeHashtable[name];
						}
						else
						{
							techNodeViewModel = new TechNodeViewModel();
							nameNodeHashtable.Add(name, techNodeViewModel);
						}

						techNodeViewModel.TechNode.PopulateFromSource(node, TreeType.ATC);

						foreach (var parentNode in node.Children.Where(child => child.Name == "PARENT_NODE"))
						{
							var parentKeyValuePairs = parentNode.Values.Where(pair => pair.Key == "name");
							var parents = new List<string>();
							foreach (var parentKeyValuePair in parentKeyValuePairs)
							{
								parents.Add(parentKeyValuePair.Value.First());
							}

							foreach (var parent
								in parents.
									Where(
									      parent =>
									      !nameNodeHashtable.ContainsKey(parent)))
							{
								nameNodeHashtable.Add(parent, new TechNodeViewModel());
							}

							foreach (var parent
								in parents
									.Where(
									       parent => !String.IsNullOrEmpty(parent) &&
									                 nameNodeHashtable.
										                 ContainsKey(parent)))
							{
								techNodeViewModel.Parents.Add(nameNodeHashtable[parent]);
							}
						}

						_treeData.TechTree.Add(techNodeViewModel);
					}
					break;
			}

			_treeData.LinkNodes();
			_treeData.WorkspaceViewModel.StatusBarText = "Tree Loaded";
		}

		private void ResetTree()
		{
			_treeData.TechTree.Clear();
			_treeData.Connections.Clear();

			var partCollection = MainSideBar.PartsListBox.DataContext as
			                     PartCollectionViewModel;
			if (partCollection == null) return;

			partCollection.PartCollection.Clear();
		}

		public void LoadButtonClick(object sender, RoutedEventArgs e)
		{
			var dlg = new StartupDialog { Owner = this };
			dlg.ShowDialog();
		}

		private void SaveClick(object sender, RoutedEventArgs e)
		{
			var dlg = new SaveFileDialog
			          {
				          DefaultExt = ".cfg",
				          Filter = "Tech Tree Config Files|*.cfg",
				          Title = "Select where to save...",
				          AddExtension = true,
			          };

			var result = dlg.ShowDialog();

			if (result == false) return;

			var saver = new TechManagerSaver();
			try
			{
				_treeData.Save(saver, dlg.FileName);
			}
			catch (Exception)
			{
				_treeData.WorkspaceViewModel.StatusBarText =
					"Failed saving to file..";
			}
		}

		private void SaveATCClick(object sender, RoutedEventArgs e)
		{
			var dlg = new SaveFileDialog
			          {
				          DefaultExt = ".cfg",
				          Filter = "Tech Tree Config Files|*.cfg",
				          Title = "Select where to save...",
				          AddExtension = true,
			          };

			var result = dlg.ShowDialog();

			if (result == false) return;

			var saver = new ATCSaver();
			try
			{
				_treeData.Save(saver, dlg.FileName);
			}
			catch (Exception)
			{
				_treeData.WorkspaceViewModel.StatusBarText =
					"Failed saving to file..";
			}
		}

		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			var dlg = new StartupDialog { Owner = this };
			dlg.ShowDialog();
		}

		private void DeleteOnExecuted(object sender, ExecutedRoutedEventArgs e)
		{
			_treeData.DeleteNode(_treeData.WorkspaceViewModel.SelectedNode);
		}

		private void DeleteOnCanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = _treeData.WorkspaceViewModel.SelectedNode != null;
		}

		private void HelpClick(object sender, RoutedEventArgs e)
		{
			var dlg = new HelpDialog { Owner = this };
			dlg.ShowDialog();
		}

		private void OnClosed(object sender, EventArgs e)
		{
			Logger.Log("Application closed");
		}
	}
}
