using System.Collections.ObjectModel;

namespace ksp_techtree_edit.ViewModels
{
	internal class PartCollectionViewModel
	{
		private readonly ObservableCollection<string>
			_partCollection = new ObservableCollection<string>();

		public ObservableCollection<string> PartCollection
		{
			get { return _partCollection; }
		}
	}
}
