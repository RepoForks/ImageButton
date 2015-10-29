using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ImageButton
{
	public class SampleViewModel : INotifyPropertyChanged
	{
		public SampleViewModel()
		{
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		private bool _isSelected;

		public bool IsSelected
		{ 
			get
			{
				return _isSelected; 
			}
			set
			{
				_isSelected = value; 
				RaisePropertyChanged("IsSelected"); 
			}
		}

		private bool _isLoading;

		public bool IsLoading
		{ 
			get
			{
				return _isLoading; 
			}
			set
			{
				_isLoading = value; 
				RaisePropertyChanged("IsLoading"); 
				RaisePropertyChanged("CanExecuteToggleFavoriteCommand"); 
			}
		}

		public bool CanExecuteToggleFavoriteCommand
		{
			get
			{
				return!this.IsLoading;
			}
		}



		private Command _toggleFavoriteCommand;

		public System.Windows.Input.ICommand ToggleFavoriteCommand
		{
			get
			{
				_toggleFavoriteCommand = _toggleFavoriteCommand ?? new Command(async () => {
					IsLoading = true;
					await Task.Delay(1000);
					this.IsSelected = !IsSelected;
					IsLoading = false;
				}, () => !IsLoading);
				return _toggleFavoriteCommand;
			}
		}

		void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

