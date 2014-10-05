using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using KerbalParser;
using ksp_techtree_edit.ViewModels;

namespace ksp_techtree_edit.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private KerbalConfig _config;
		private readonly TechTreeViewModel _treeData;

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
		}

		public KerbalConfig ParseTree()
		{
			var parser = new Parser();
			return parser.ParseConfig("..//..//tree.cfg");
		}

		public void FindParts()
		{
			var partCollectionViewModel = MainSideBar.PartsListBox.DataContext
			                   as PartCollectionViewModel;

			if (partCollectionViewModel == null) return;
			const string ksppath = "C://Program Files (x86)//" +
			                       "Steam//SteamApps//common//" +
			                       "Kerbal Space Program//GameData";
			partCollectionViewModel.LoadParts(ksppath);

			foreach (var node in _treeData.TechTree)
			{
				node.PopulateParts(partCollectionViewModel);
			}
		}

		private void LoadButtonClick(object sender, RoutedEventArgs e)
		{
			var nameNodeHashtable = new Dictionary<string, TechNodeViewModel>();

			if (_treeData == null)
			{
				StatusBarText = "No tech tree data.";
				return;
			}

			_config = ParseTree();

			foreach (var tree in
				_config.Where(
				              tree => tree.Name != "REMOVENODE" &&
				                      tree.Values.ContainsKey("name")))
			{
				var v = tree.Values;
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

				techNodeViewModel.TechNode.PopulateFromSource(tree);

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
			Console.WriteLine(_treeData.TechTree);

			_treeData.LinkNodes();
		}

		private void ClearButtonClick(object sender, RoutedEventArgs e)
		{
			StatusBarText = "Cleared Tree";
			if (_treeData == null)
			{
				StatusBarText = "No tech tree data.";
				return;
			}

			_treeData.TechTree.Clear();
			_treeData.Connections.Clear();
		}

		public string StatusBarText
		{
			get { return (string) GetValue(StatusBarTextProperty); }
			set { SetValue(StatusBarTextProperty, value); }
		}

		public static readonly DependencyProperty StatusBarTextProperty =
			DependencyProperty.Register(
			                            "StatusBarText",
			                            typeof (string),
			                            typeof (MainWindow),
			                            new UIPropertyMetadata(""));

		private void LoadPartsClick(object sender, RoutedEventArgs e)
		{
			FindParts();
		}
	}
}
