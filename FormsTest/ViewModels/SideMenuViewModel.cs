using System;
using System.ComponentModel;
using FormsTest.Models;
using System.Collections.Generic;
using FormsTest.Constants;
using FormsTest.Views;

namespace FormsTest.ViewModels
{
    public class SideMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private const string propertySideMenuItem = "sideMenuItem";
        private List<SideMenuItem> _masterPageItems;
        public List<SideMenuItem> masterPageItems
        {
            get
            {
                if (_masterPageItems == null)
                {
                    _masterPageItems = new List<SideMenuItem>();
                    _masterPageItems.Add(new SideMenuItem
                    {
                        Title = "Home",
                        IconSource = ImageSideMenu.Home,
                        TargetType = typeof(HomeContentPage)
                    });
                    _masterPageItems.Add(new SideMenuItem
                    {
                        Title = "Shop",
                        IconSource = ImageSideMenu.Shop,
                        TargetType = typeof(ShopContentPage)
                    });
                }
                return _masterPageItems;
            }
        }

        //private MasterPageItem _sideMenuItem;
        //public MasterPageItem sideMenuItem {
        //    get {
        //        if (_sideMenuItem == null) {
        //            _sideMenuItem = new MasterPageItem();
        //        }
        //        return _sideMenuItem;
        //    }
        //    set {
        //        if (_sideMenuItem != value) {
        //            _sideMenuItem = value;
        //            if (PropertyChanged != null)                                               
        //                PropertyChanged(this, new PropertyChangedEventArgs(propertySideMenuItem));
                    
        //        }

        //    }
        //}


    }
}
