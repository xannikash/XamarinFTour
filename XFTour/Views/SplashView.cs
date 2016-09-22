using System;

using Xamarin.Forms;

namespace XFTour
{
	public class SplashView : ContentPage
	{
		public SplashView()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

