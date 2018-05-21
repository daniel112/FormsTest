using System;
using Xamarin.Forms;
using System.Collections.Generic;
using FormsTest.Models;

namespace FormsTest
{
    public class SideMenuContentPage : ContentPage
    {

		#region Variables
		private ListView _listView;
        private ListView listView
        {
			get {

                if (_listView == null) {
					_listView = new ListView
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
						SeparatorVisibility = SeparatorVisibility.Default,
						BackgroundColor = Color.Transparent
                    };
                }
                return _listView;
            }
        }

        private List<MasterPageItem> _masterPageItems;
        private List<MasterPageItem> masterPageItems
        {
            get
            {
                if (_masterPageItems == null)
                {
                    _masterPageItems = new List<MasterPageItem>();
                    _masterPageItems.Add(new MasterPageItem
                    {
                        Title = "Home",
                        IconSource = "contacts.png",
                        TargetType = typeof(HomeContentPage)
                    });
                    _masterPageItems.Add(new MasterPageItem
                    {
                        Title = "Item 2",
                        IconSource = "todo.png",
                        TargetType = typeof(HomeContentPage)
                    });
                }
                return _masterPageItems;
            }
        }
		#endregion


        public SideMenuContentPage() 
		{
			SetupContent();            
        }


        #region Private API

		private void SetupContent()
        {

            Icon = "nav_menu";
            Title = "Side Menu Content";
			BackgroundColor = Color.Gray;

			Label labelHeader = new Label
			{
				Text = "Piedmontese",
				TextColor = Color.White,
				FontSize = 20,
				Margin = new Thickness(20),
				HorizontalTextAlignment = TextAlignment.Center

			};

            Content = new StackLayout
            {
                Children = { 
					labelHeader,
					listView 
				}
            };
        }
       
        #endregion
    }
}

