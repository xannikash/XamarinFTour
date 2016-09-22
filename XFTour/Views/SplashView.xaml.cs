using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFTour
{
	public partial class SplashView : ContentPage
	{
		public SplashView()
		{
			InitializeComponent();

			//Remove titlebar
			NavigationPage.SetHasNavigationBar(this, false);
			Device.BeginInvokeOnMainThread(() => DelayedShowLoginView() );
		}

		private async Task DelayedShowLoginView()
		{
			await Task.Delay(5000);
			await Navigation.PushAsync(new LoginView());
			Navigation.RemovePage(this);
		}
	}
}
