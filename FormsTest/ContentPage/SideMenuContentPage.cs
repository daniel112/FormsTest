using System;
using Xamarin.Forms;
using System.Collections.Generic;
using FormsTest.Models;

namespace FormsTest
{
    public class SideMenuContentPage : ContentPage
    {
		public ListView ListView { get { return listView; } }
        ListView listView;

        public SideMenuContentPage()
        {
			SetupData();
            SetupContent();
        }


        #region Private API

        private void SetupData()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "contacts.png",
                TargetType = typeof(HomeContentPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Item 2",
                IconSource = "todo.png",
                TargetType = typeof(HomeContentPage)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };
        }

        private void SetupContent()
        {         

			Icon = "nav_menu";
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                Children = { listView }
            };
        }
        #endregion
    }
}

