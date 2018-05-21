using System;
using Xamarin.Forms;

namespace FormsTest
{
	public class HomeContentPage : ContentPage
	{
		public HomeContentPage()
		{
			SetupData();

			SetupContent();

		}

		#region Private API

		private void SetupData() {
            
		}

		private void SetupContent() {

			this.Title = "Home";
			this.BackgroundColor = Color.White;
		}
		#endregion
	}
}

