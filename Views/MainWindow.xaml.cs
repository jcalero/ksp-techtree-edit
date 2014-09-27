using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
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

		public MainWindow()
		{
			InitializeComponent();
		}

		public KerbalConfig ParseTree()
		{
			var parser = new Parser();
			return parser.ParseConfig("..//..//tree.cfg");
		}

		private void LoadDataButton_Click(object sender, RoutedEventArgs e)
		{
			var treeData = DataContext as TechTreeModel;
			var nameNodeHashtable = new Dictionary<string, TechNodeModel>();

			if (treeData == null)
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
				TechNodeModel techNodeModel;

				if (nameNodeHashtable.ContainsKey(name))
				{
					techNodeModel = nameNodeHashtable[name];
				}
				else
				{
					techNodeModel = new TechNodeModel();
					nameNodeHashtable.Add(name, techNodeModel);
				}

				techNodeModel.PopulateFromSource(tree);

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
						nameNodeHashtable.Add(parent, new TechNodeModel());
					}

					foreach (var parent
						in parents
							.Where(
							       parent => !String.IsNullOrEmpty(parent) &&
							                 nameNodeHashtable.
								                 ContainsKey(parent)))
					{
						techNodeModel.Parents.Add(nameNodeHashtable[parent]);
					}
				}

				treeData.TechTree.Add(techNodeModel);
			}
			Console.WriteLine(treeData.TechTree);

			treeData.LinkNodes();
		}

		private void ClearButtonClick(object sender, RoutedEventArgs e)
		{
			StatusBarText = "Cleared Tree";
			var treeData = DataContext as TechTreeModel;
			if (treeData == null)
			{
				StatusBarText = "No tech tree data.";
				return;
			}

			treeData.TechTree.Clear();
			treeData.Connections.Clear();
		}

		public string StatusBarText
		{
			get { return (string) GetValue(StatusBarTextProperty); }
			set { SetValue(StatusBarTextProperty, value); }
		}

		// Using a DependencyProperty as the backing store for StatusBarText.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty StatusBarTextProperty =
			DependencyProperty.Register("StatusBarText", typeof (string), typeof (MainWindow), new UIPropertyMetadata(""));

		private Vector _totalDelta = new Vector(0d, 0d);
		private int _nodeStickiness = 25;

		public int NodeStickiness
		{
			get { return _nodeStickiness; }
			set { _nodeStickiness = value; }
		}

		private void TechNode_OnDragDelta(object sender, DragDeltaEventArgs e)
		{
			var nodeThumb = sender as Thumb;
			if (nodeThumb == null) return;
			var techNode = nodeThumb.DataContext as TechNodeModel;
			if (techNode == null) return;

			_totalDelta.X += e.HorizontalChange;
			_totalDelta.Y += e.VerticalChange;

			if (_totalDelta.Length < NodeStickiness) return;

			Mouse.OverrideCursor = Cursors.Hand;

			var newPos = new Point(
				Math.Round(techNode.Pos.X + e.HorizontalChange, 2),
				Math.Round(techNode.Pos.Y - e.VerticalChange, 2));
			techNode.Pos = newPos;
		}

		private void Thumb_OnDragCompleted(object sender, DragCompletedEventArgs e)
		{
			_totalDelta = new Vector(0d, 0d);
			Mouse.OverrideCursor = null;
		}

		private void Thumb_OnDragStarted(object sender, DragStartedEventArgs e)
		{
			var thumb = sender as Thumb;
			if (thumb == null) return;

			var node = thumb.DataContext as TechNodeModel;
			if (node == null) return;

			node.IsSelected = true;

			NodePropertyGrid.SelectedObject = node;
			NodePropertyGrid.SelectedObjectName = node.Title;
		}
	}
}
