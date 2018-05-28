using System;
using Xamarin.Forms;

namespace FormsTest.Views.Base
{
    public class BaseNavigationPage : NavigationPage
    {
        public BaseNavigationPage(Page root) : base(root)
        {
            BarBackgroundColor = Color.Green;
            BarTextColor = Color.White;
        }
    }
}
