using System;
using Xamarin.Forms;

namespace FormsTest.Views
{
    public class ShopContentPage : ContentPage
    {
        #region Variables

        #endregion

        #region Initialization
        public ShopContentPage()
        {
            SetupContent();
        }
        #endregion

        #region Private API

        private void SetupContent()
        {
            this.Title = "Shop";
            this.BackgroundColor = Color.Gold;
        }

        #endregion

        #region Public API

        #endregion

    }
}
