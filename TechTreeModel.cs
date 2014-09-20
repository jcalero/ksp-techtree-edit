using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using KerbalParser;

namespace ksp_techtree_edit
{
	public class TechTreeModel
	{
		private readonly ObservableCollection<TechNode> _techTree =
			new ObservableCollection<TechNode>();

		//		public TechTreeModel()
		//		{
		//			TechTree = new ObservableCollection<TechNode>();
		//		}

		public void AddTechNode(KerbalNode node)
		{
			var techNode = new TechNode(node);
			TechTree.Add(techNode);
		}

		public ObservableCollection<TechNode> TechTree
		{
			get { return _techTree; }
		}
	}

	[DataContract]
	public class TechNode : INotifyPropertyChanged
	{
		#region Data Members

		private Point _pos;

		[DataMember]
		public KerbalNode Source { get; set; }

		[DataMember]
		public string NodeName { get; set; }

		[DataMember]
		public string TechId { get; set; }

		[DataMember]
		public Point Pos
		{
			get { return _pos; }
			set
			{
				if (_pos == value) return;
				_pos = value;
				OnPropertyChanged();
			}
		}

		[DataMember]
		public int Zlayer { get; set; }

		[DataMember]
		public string Icon { get; set; }

		[DataMember]
		public int Cost { get; set; }

		[DataMember]
		public string Title { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public bool AnyParent { get; set; }

		[DataMember]
		public bool HideIfEmpty { get; set; }

		[DataMember]
		public List<TechNode> Parents { get; set; }

		[DataMember]
		public List<string> Parts { get; set; }

		#endregion

		public TechNode(
			KerbalNode nodeToClone,
			IEnumerable<TechNode> parents = null)
		{
			Source = nodeToClone;

			var v = Source.Values;

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
					Pos = new Point((x + 3000) * 0.85, y * 0.6);

					decimal z;
					if (!Decimal.TryParse(coordinates[2], out z))
					{
						Zlayer = 0;
					}
					Zlayer = (int) -z;
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
					default:
						AnyParent = false;
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
					default:
						HideIfEmpty = false;
						break;
				}
			}

			Parents = new List<TechNode>();
			if (parents != null)
			{
				Parents.AddRange(parents);
			}

			Parts = new List<string>();
			foreach (var child in 
				Source.Children.
				       Where(child => child.Name == "PARTS").
				       Where(child => child.Values.ContainsKey("name")))
			{
				Parts.AddRange(child.Values["name"]);
			}
		}

		#region INotifyPropertyChanged Implementations

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
