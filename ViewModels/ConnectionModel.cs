using System.ComponentModel;
using System.Runtime.CompilerServices;
using ksp_techtree_edit.Annotations;

namespace ksp_techtree_edit.ViewModels
{
	public class ConnectionModel : INotifyPropertyChanged
	{
		#region Data Members

		private TechNodeModel _startNodeModel;
		private TechNodeModel _endNodeModel;

		public ConnectionModel(TechNodeModel startNodeModel, TechNodeModel endNodeModel)
		{
			_startNodeModel = startNodeModel;
			_endNodeModel = endNodeModel;
		}

		public TechNodeModel StartNodeModel
		{
			get { return _startNodeModel; }
			set
			{
				if (_startNodeModel == value) return;
				_startNodeModel = value;
				OnPropertyChanged();
			}
		}

		public TechNodeModel EndNodeModel
		{
			get { return _endNodeModel; }
			set
			{
				if (_endNodeModel == value) return;
				_endNodeModel = value;
				OnPropertyChanged();
			}
		}

		#endregion

		#region INotifyPropertyChanged Implementations

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
