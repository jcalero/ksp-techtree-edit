using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using KerbalParser;

namespace ksp_techtree_edit
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

			if (treeData == null)
			{
				StatusBarText = "No tech tree data.";
				return;
			}

			_config = ParseTree();

			foreach (var tree in _config.
				Where(tree => tree.Name != "REMOVENODE"))
			{
				treeData.AddTechNode(tree);
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			StatusBarText = "Cleared Tree";
			var treeData = DataContext as TechTreeModel;
			if (treeData == null)
			{
				StatusBarText = "No tech tree data.";
				return;
			}

			treeData.TechTree.Clear();
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
			var techNode = nodeThumb.DataContext as TechNode;
			if (techNode == null) return;

			_totalDelta.X += e.HorizontalChange;
			_totalDelta.Y += e.VerticalChange;

			if (_totalDelta.Length < NodeStickiness) return;

			Mouse.OverrideCursor = Cursors.Hand;

			var newPos = new Point(
				techNode.Pos.X + e.HorizontalChange,
				techNode.Pos.Y + e.VerticalChange);
			techNode.Pos = newPos;
		}

		private void Thumb_OnDragCompleted(object sender, DragCompletedEventArgs e)
		{
			_totalDelta = new Vector(0d, 0d);
			Mouse.OverrideCursor = null;
		}

		private void Thumb_OnDragStarted(object sender, DragStartedEventArgs e)
		{
			var selfBtn = sender as Thumb;
			if (selfBtn == null) return;

			var node = selfBtn.DataContext as TechNode;
			if (node == null) return;

			NodePropertyGrid.SelectedObject = node;
			NodePropertyGrid.SelectedObjectName = node.Title;
		}
	}
}
