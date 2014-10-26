using System;
using System.Linq;
using KerbalParser;

namespace ksp_techtree_edit.Models
{
	public class Part
	{
		#region Members

		public string FileName { get; set; }
		public string PartName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Cost { get; set; }
		public string TechRequired { get; set; }
		public string Category { get; set; }
		public string Icon { get; set; }

		#endregion Members

		#region Constructors

		public Part()
		{
		}

		public Part(string name)
		{
			PartName = name;
		}

		#endregion Constructors

		#region Members

		public void PopulateFromSource(KerbalNode node)
		{
			var v = node.Values;

			if (PartName == null) PartName = v["name"].First();

			if (v.ContainsKey("title"))
			{
				Title = v["title"].First();
			}

			if (v.ContainsKey("description"))
			{
				Description = v["description"].First();
			}

			if (v.ContainsKey("cost"))
			{
				int c;
				Int32.TryParse(v["cost"].First(), out c);
				Cost = c;
			}

			if (v.ContainsKey("TechRequired"))
			{
				TechRequired = v["TechRequired"].First();
			}

			if (v.ContainsKey("category"))
			{
				Category = v["category"].First();
			}
		}

		#endregion Members
	}
}
