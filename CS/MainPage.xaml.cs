using System;
using Microsoft.Maui.Controls;

namespace EditorsGetStarted
{
	public partial class MainPage : ContentPage
	{
        readonly MainViewModel viewModel;


		public MainPage()
		{
			InitializeComponent();
			viewModel = new MainViewModel();
			BindingContext = viewModel;
		}

		void OnSubmitClicked(Object sender, EventArgs e) {
			if (viewModel.Validate())
				DisplayAlert("Success", "Your account has been created successfully", "OK");
		}
	}
}
