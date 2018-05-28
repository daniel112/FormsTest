using System;
using Xamarin.Forms;

namespace FormsTest.Views
{
    public class HomeContentPage : ContentPage
    {
        
        #region Variables

        #endregion

        #region Initialization

        public HomeContentPage()
        {
            SetupContent();
        }
        #endregion

        #region Private API

        private void SetupContent()
        {
            this.Title = "Home";
            this.BackgroundColor = Color.OrangeRed;
        }

        #endregion

        #region Public API

        #endregion

    }
}
