using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Windows;
using ksp_techtree_edit.Models;

namespace ksp_techtree_edit.ViewModels
{
	[DataContract]
	public class TechNodeViewModel : NotificationViewModel
	{
		#region Data Members

		private bool _isSelected;

		private TechNode _techNode;

		private ObservableCollection<TechNodeViewModel> _parents =
			new ObservableCollection<TechNodeViewModel>();

		private ObservableCollection<PartViewModel> _parts =
			new ObservableCollection<PartViewModel>();

		public int Width { get; set; }

		public int Height { get; set; }

		public bool IsSelected
		{
			get { return _isSelected; }
			set
			{
				if (_isSelected == value) return;
				_isSelected = value;
				OnPropertyChanged();
			}
		}

		public TechNode TechNode
		{
			get { return _techNode; }
			set
			{
				if (_techNode == value) return;
				_techNode = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<TechNodeViewModel> Parents
		{
			get { return _parents; }
			set { _parents = value; }
		}

		public ObservableCollection<PartViewModel> Parts
		{
			get { return _parts; }
			set { _parts = value; }
		}

		#region Model Wrappers

		public string NodeName
		{
			get { return _techNode.NodeName; }
			set
			{
				if (_techNode.NodeName == value) return;
				_techNode.NodeName = value;
				OnPropertyChanged();
			}
		}

		public string Title
		{
			get { return _techNode.Title; }
			set
			{
				if (_techNode.Title == value) return;
				_techNode.Title = value;
				OnPropertyChanged();
			}
		}

		public string Description
		{
			get { return _techNode.Description; }
			set
			{
				if (_techNode.Description == value) return;
				_techNode.Description = value;
				OnPropertyChanged();
			}
		}

		public int Cost
		{
			get { return _techNode.Cost; }
			set
			{
				if (_techNode.Cost == value) return;
				_techNode.Cost = value;
				OnPropertyChanged();
			}
		}

		public Point Pos
		{
			get { return _techNode.Pos; }
			set
			{
				if (_techNode.Pos == value) return;
				_techNode.Pos = value;
				OnPropertyChanged();
			}
		}

		public int Zlayer
		{
			get { return _techNode.Zlayer; }
			set
			{
				if (_techNode.Zlayer == value) return;
				_techNode.Zlayer = value;
				OnPropertyChanged();
			}
		}

		public string TechId
		{
			get { return _techNode.TechId; }
			set
			{
				if (_techNode.TechId == value) return;
				_techNode.TechId = value;
				OnPropertyChanged();
			}
		}

		public string Icon
		{
			get { return _techNode.Icon; }
			set
			{
				if (_techNode.Icon == value) return;
				_techNode.Icon = value;
				OnPropertyChanged();
			}
		}

		public bool AnyParent
		{
			get { return _techNode.AnyParent; }
			set
			{
				if (_techNode.AnyParent == value) return;
				_techNode.AnyParent = value;
				OnPropertyChanged();
			}
		}

		public bool HideIfEmpty
		{
			get { return _techNode.HideIfEmpty; }
			set
			{
				if (_techNode.HideIfEmpty == value) return;
				_techNode.HideIfEmpty = value;
				OnPropertyChanged();
			}
		}

		#endregion Model Wrappers

		#endregion Data Members

		#region Constructors

		public TechNodeViewModel()
		{
			Width = 40;
			Height = 40;

			TechNode = new TechNode();
		}

		#endregion Constructors

		#region Helper Methods

		public void PopulateParts(
			PartCollectionViewModel pc,
			TreeType type = TreeType.TreeLoader)
		{
			switch (type)
			{
				case TreeType.ATC:
					foreach (var part in pc.PartCollection)
					{
						if (part.TechRequired == TechId)
						{
							_parts.Add(part);
						}
					}
					break;

				case TreeType.TreeLoader:
					var partTable = new Dictionary<string, PartViewModel>();

					foreach (var part in pc.PartCollection)
					{
						partTable.Add(part.PartName, part);
					}
					foreach (var part in _techNode.Parts)
					{
						if (partTable.ContainsKey(part))
						{
							_parts.Add(partTable[part]);
						}
					}
					break;
			}
		}

		public void RemovePart(PartViewModel part)
		{
			Parts.Remove(part);
			TechNode.Parts.Remove(part.PartName);
		}

		public void AddPart(PartViewModel part)
		{
			Parts.Add(part);
			TechNode.Parts.Add(part.PartName);
		}

		#endregion Helper Methods
	}
}
