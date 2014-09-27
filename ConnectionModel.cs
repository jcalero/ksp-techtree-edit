using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using ksp_techtree_edit.Annotations;

namespace ksp_techtree_edit
{
	public class ConnectionModel : INotifyPropertyChanged
	{
		#region Data Members

		private TechNode _startNode;
		private TechNode _endNode;

		public ConnectionModel(TechNode startNode, TechNode endNode)
		{
			_startNode = startNode;
			_endNode = endNode;
		}

		public TechNode StartNode
		{
			get { return _startNode; }
			set
			{
				if (_startNode == value) return;
				_startNode = value;
				OnPropertyChanged();
			}
		}

		public TechNode EndNode
		{
			get { return _endNode; }
			set
			{
				if (_endNode == value) return;
				_endNode = value;
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
