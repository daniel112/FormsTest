using System;
using Xamarin.Forms;
using FormsTest.Models;
using FormsTest.Views;
using FormsTest.Views.Base;

namespace FormsTest
{
	public class SideMenuMasterDetailPage : MasterDetailPage
    {
        public SideMenuMasterDetailPage()
		{
            
            // cast to NavigationPage and change bar color
            this.Detail = new BaseNavigationPage(new HomeContentPage());
         
            // the side menu page
            SideMenuContentPage sideMenuContentPage = new SideMenuContentPage();
            
			this.Master = sideMenuContentPage;
			this.MasterBehavior = MasterBehavior.Popover;
			IsGestureEnabled = true;

        }
    }
}
