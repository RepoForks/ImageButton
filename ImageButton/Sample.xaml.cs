using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ImageButton
{
	public partial class Sample : ContentPage
	{
		public Sample()
		{
			this.BindingContext = new SampleViewModel();
			InitializeComponent();
		}
	}
}

