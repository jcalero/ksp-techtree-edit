using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using KerbalParser;

namespace ksp_techtree_edit
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public KerbalConfig ParseTree()
		{
			var parser = new Parser();
			return parser.ParseConfig("..//..//tree.cfg");
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var config = ParseTree();

			foreach (var tree in config)
			{
				if (tree.Name == "REMOVENODE") continue;

				var offset = tree.Values["name"].First().IndexOf("_", StringComparison.Ordinal);
				var label = new Label { Content = tree.Values["name"].First().Substring(offset) };

				if (tree.Values.ContainsKey("pos"))
				{
					var posString = tree.Values["pos"].First();
					var coordinates = posString.Split(',');

					if (coordinates.Length >= 2)
					{
						// Normalise coordinates
						var x = (int) ((Decimal.Parse(
						                              coordinates[0]) +
						                3000) * 0.85m);
						var y = (int) (Decimal.Parse(
						                             coordinates[1]) * 0.6m);
						Canvas.SetLeft(label, x);
						Canvas.SetBottom(label, y);
					}
				}
				Canvas.Children.Add(label);
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			foreach (var child in Canvas.Children.OfType<Label>().ToArray())
			{
				Canvas.Children.Remove(child);
			}
		}
	}
}
