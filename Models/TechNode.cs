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
		public string Icon { get; set; }
		public bool AnyParent { get; set; }
		public bool HideIfEmpty { get; set; }

		public List<TechNode> Parents { get; set; }

		public List<string> Parts { get; set; }

		#endregion Members

		#region Methods

		public void PopulateFromSource(KerbalNode sourceNode)
		{
			var v = sourceNode.Values;

			NodeName = v.ContainsKey("name") ? v["name"].First() : "";

			TechId = v.ContainsKey("techID") ? v["techID"].First() : "";

			if (v.ContainsKey("pos"))
			{
				var posString = v["pos"].First();
				var coordinates = posString.Split(',');

				if (coordinates.Length >= 2)
				{
					double x;
					if (!Double.TryParse(coordinates[0], out x))
					{
						x = 0;
					}

					double y;
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

			Icon = v.ContainsKey("icon") ? v["icon"].First() : "";

			if (v.ContainsKey("cost"))
			{
				int c;
				if (!Int32.TryParse(v["cost"].First(), out c))
				{
					Cost = 0;
				}
				Cost = c;
			}

			Title = v.ContainsKey("title") ? v["title"].First() : "";
			Description = v.ContainsKey("description") ? v["description"].First() : "";

			AnyParent = false;
			if (v.ContainsKey("anyParent"))
			{
				switch (v["anyParent"].First().Trim().ToLower())
				{
					case "true":
						AnyParent = true;
						break;
				}
			}

			HideIfEmpty = false;
			if (v.ContainsKey("hideIfEmpty"))
			{
				switch (v["hideIfEmpty"].First().Trim().ToLower())
				{
					case "true":
						HideIfEmpty = true;
						break;
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
