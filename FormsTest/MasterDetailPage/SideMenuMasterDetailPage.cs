using System;
using Xamarin.Forms;
using FormsTest.Models;

namespace FormsTest
{
	public class SideMenuMasterDetailPage : MasterDetailPage
    {
        public SideMenuMasterDetailPage()
		{

            // cast to NavigationPage and change bar color
			var detailNavigationPage = new NavigationPage(new HomeContentPage());
			detailNavigationPage.BarBackgroundColor = Color.Black;
			detailNavigationPage.BarTextColor = Color.White;
           
			this.Detail = detailNavigationPage;




            // the side menu page
			SideMenuContentPage masterPage = new SideMenuContentPage();
            
			this.Master = masterPage;
			this.MasterBehavior = MasterBehavior.Popover;

        }
    }
}
