using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using KerbalParser;

namespace ksp_techtree_edit.Models
{
	public class TechNode
	{
		#region Members

		public string NodeName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Cost { get; set; }
		public Point Pos { get; set; }
		public int Zlayer { get; set; }
		public string TechId { get; set; }
		public Icon Icon { get; set; }
		public bool AnyParent { get; set; }
		public bool HideIfEmpty { get; set; }

		public List<TechNode> Parents { get; set; }

		public List<string> Parts { get; set; }

		#endregion Members

		#region Methods

		public void PopulateFromSource(
			KerbalNode sourceNode,
			TreeType treeType = TreeType.TreeLoader)
		{
			var v = sourceNode.Values;

			NodeName = v.ContainsKey("name") ? v["name"].First() : "";

			double x;
			double y;
			switch (treeType)
			{
				case TreeType.TreeLoader:
					TechId = v.ContainsKey("techID") ? v["techID"].First() : "";

					if (v.ContainsKey("pos"))
					{
						var posString = v["pos"].First();
						var coordinates = posString.Split(',');

						if (coordinates.Length >= 2)
						{
							if (!Double.TryParse(coordinates[0], out x))
							{
								x = 0;
							}

							if (!Double.TryParse(coordinates[1], out y))
							{
								y = 0;
							}
							Pos = new Point(x, y);

							decimal z;
							if (!Decimal.TryParse(coordinates[2], out z))
							{
								Zlayer = 0;
							}
							Zlayer = (int)z;
						}
					}
					break;

				case TreeType.ATC:
					if (v.ContainsKey("name"))
					{
						var i = v["name"].First().IndexOf('_');
						TechId = i > 0 && i + 1 < v["name"].First().Length
							         ? v["name"].First().Substring(i + 1)
							         : v["name"].First();
					}
					else
					{
						TechId = "";
					}

					x = 0;
					y = 0;
					if (v.ContainsKey("posX"))
					{
						if (!Double.TryParse(v["posX"].First(), out x))
						{
							x = 0;
						}
					}

					if (v.ContainsKey("posY"))
					{
						if (!Double.TryParse(v["posY"].First(), out y))
						{
							y = 0;
						}
					}
					Pos = new Point(x, y);
					break;
			}

			if (v.ContainsKey("icon"))
			{
				Icon icon;
				if (!Enum.TryParse(v["icon"].First(), true, out icon))
				{
					icon = Icon.UNDEFINED;
				}
				Icon = icon;
			}

			Title = v.ContainsKey("title") ? v["title"].First() : "";
			Description = v.ContainsKey("description") ? v["description"].First() : "";

			AnyParent = false;
			HideIfEmpty = false;

			if (treeType == TreeType.ATC)
			{
				if (v.ContainsKey("scienceCost"))
				{
					int c;
					if (!Int32.TryParse(v["scienceCost"].First(), out c))
					{
						Cost = 0;
					}
					Cost = c;
				}
				if (v.ContainsKey("anyParentUnlocks"))
				{
					switch (v["anyParentUnlocks"].First().Trim().ToLower())
					{
						case "true":
							AnyParent = true;
							break;
					}
				}
				if (v.ContainsKey("hideIfNoparts"))
				{
					switch (v["hideIfNoparts"].First().Trim().ToLower())
					{
						case "true":
							HideIfEmpty = true;
							break;
					}
				}
			}
			else
			{
				if (v.ContainsKey("cost"))
				{
					int c;
					if (!Int32.TryParse(v["cost"].First(), out c))
					{
						Cost = 0;
					}
					Cost = c;
				}
				if (v.ContainsKey("anyParent"))
				{
					switch (v["anyParent"].First().Trim().ToLower())
					{
						case "true":
							AnyParent = true;
							break;
					}
				}
				if (v.ContainsKey("hideIfEmpty"))
				{
					switch (v["hideIfEmpty"].First().Trim().ToLower())
					{
						case "true":
							HideIfEmpty = true;
							break;
					}
				}
			}

			// Create an empty parents collection, populated during linking
			Parents = new List<TechNode>();

			var tmpParts = new List<string>();
			foreach (var child in
				sourceNode.Children.
				           Where(child => child.Name == "PARTS").
				           Where(child => child.Values.ContainsKey("name")))
			{
				tmpParts.AddRange(child.Values["name"]);
			}
			Parts = new List<string>(tmpParts);
		}

		#endregion Methods
	}
}

public enum TreeType
{
	ATC,
	TreeLoader
}
