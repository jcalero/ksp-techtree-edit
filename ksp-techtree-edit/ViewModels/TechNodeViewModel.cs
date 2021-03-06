using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Windows;
using ksp_techtree_edit.Models;
using ksp_techtree_edit.Util;

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

		public Icon Icon
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

		public bool HideIfNoBranchParts
		{
			get { return _techNode.HideIfNoBranchParts; }
			set
			{
				if (_techNode.HideIfNoBranchParts == value) return;
				_techNode.HideIfNoBranchParts = value;
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
			TreeType type = TreeType.TechMananger)
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

				case TreeType.TechMananger:
					var partTable = new Dictionary<string, PartViewModel>();

					foreach (var part in pc.PartCollection)
					{
						try
						{
							if (!partTable.ContainsKey(part.PartName))
							{
								partTable.Add(part.PartName, part);
							}
							else
							{
								var duplicate = partTable[part.PartName];
								var existString = String.Format(" - Existing part: {0} ({1})", duplicate.PartName, duplicate.FileName);
								Logger.Error(
								             "PartLoader: Error while storing part \"{0}\" " +
								             "({1}) into PartCollection - {2}{3}",
								             part.PartName,
								             part.FileName,
								             "Part already exists",
								             existString);
							}
						}
						catch (Exception e)
						{
							Logger.Error(
							             "PartLoader: Error while storing part \"{0}\" " +
							             "({1}) into PartCollection - {2}",
							             part.PartName,
							             part.FileName,
							             e.Message);
						}
					}

					foreach (var part in _techNode.Parts)
					{
						if (partTable.ContainsKey(part))
						{
							_parts.Add(partTable[part]);
							pc.PartCollection.Remove(partTable[part]);
						}
						else
						{
							var tmpPart = new Part(part)
							              {
								              Title = part,
								              TechRequired = TechId,
								              Category = "(Unknown)"
							              };
							_parts.Add(new PartViewModel(tmpPart));
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

		public void RemoveParent(TechNodeViewModel parent)
		{
			Parents.Remove(parent);
			TechNode.Parents.Remove(parent.TechNode);
		}

		public void AddParent(TechNodeViewModel parent)
		{
			Parents.Add(parent);
			TechNode.Parents.Add(parent.TechNode);
		}

		#endregion Helper Methods
	}
}
