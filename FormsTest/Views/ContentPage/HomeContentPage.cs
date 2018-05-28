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
            //Image backgroundImage = new Image();
            //backgroundImage.Aspect = Aspect.AspectFit;
            //backgroundImage.Source = ImageSource.FromFile("default_bckground_portrait");
           // var layout = new RelativeLayout();
           // layout.Children.Add(backgroundImage,0, 0, Application.Current.MainPage.Width,Application.Current.MainPage.Height);
           //Content = layout;

        }

        #endregion

        #region Public API

        #endregion

    }
}
