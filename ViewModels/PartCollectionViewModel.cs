using System;
using System.Collections.ObjectModel;
using ksp_techtree_edit.Models;

namespace ksp_techtree_edit.ViewModels
{
	public delegate void ProgressFileSearch(object sender, EventArgs e);

	public class PartCollectionViewModel
	{
		#region Members

		public ObservableCollection<PartViewModel>
			PartCollection { get; private set; }

		#endregion

		#region Construtctors

		public PartCollectionViewModel()
		{
			PartCollection = new ObservableCollection<PartViewModel>();
		}

		#endregion

		#region Methods

		public void LoadParts(string path)
		{
			var partCollection = new PartCollection(path);
			partCollection.LoadParts();

			foreach (var part in partCollection)
			{
				var partViewModel = new PartViewModel(part);
				PartCollection.Add(partViewModel);
			}
		}

		#endregion
	}
}
