using System;
using Xamarin.Forms;
using FormsTest.Renderers;
using FormsTest.ViewModels;
using FormsTest.Models;
using FormsTest.Views.Base;
using FormsTest.Views;

namespace FormsTest
{
    public class SideMenuContentPage : ContentPage
    {

        #region Variables
        private SideMenuViewModel _viewModel;
        private SideMenuViewModel viewModel {
            get {
                if (_viewModel == null) {
                    _viewModel = new SideMenuViewModel();
                }
                return _viewModel;
            }
        }
		private ListView _listView;
        private ListView listView
        {
			get {

                if (_listView == null) {

					_listView = new NativeListView();
                    _listView.SeparatorColor = Color.GhostWhite;
                    _listView.ItemsSource = viewModel.masterPageItems;
                    _listView.ItemTapped += OnTap;
					_listView.ItemTemplate = new DataTemplate(() => {                        
                        var grid = new Grid { Padding = new Thickness(5, 10) };
                         grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                         //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                         var image = new Image();
                         image.SetBinding(Image.SourceProperty, "IconSource");
                         var label = new Label
                         {
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            TextColor = Color.White,
                            BackgroundColor = Color.Transparent
                          };                         
                        label.SetBinding(Label.TextProperty, "Title");
                         
                        grid.Children.Add(image);
                        grid.Children.Add(label, 1, 0);// wtf is this value

                          return new ViewCell { View = grid };
					});
               
                }
                return _listView;
            }
        }


		#endregion


        public SideMenuContentPage() 
		{
			SetupContent();
            BindingContext = viewModel;
        }


        #region Private API

		private void SetupContent()
        {

            Icon = "nav_menu";
            Title = "Side Menu Content";
			BackgroundColor = Color.Black;

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
       
        private void OnTap(object sender, ItemTappedEventArgs e)
        {
            
            SideMenuItem item = (SideMenuItem)e.Item;
            DisplayAlert("Item Tapped", item.Title, "Ok");
            if (item.TargetType == typeof(HomeContentPage)) {
                ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
                ((MasterDetailPage)Application.Current.MainPage).Detail = new BaseNavigationPage(new HomeContentPage());
            } else if (item.TargetType == typeof(ShopContentPage)) {
                ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
                ((MasterDetailPage)Application.Current.MainPage).Detail = new BaseNavigationPage(new ShopContentPage());
            }

            // deselect
            ListView lst = (ListView)sender;
            lst.SelectedItem = null;

        }
        #endregion
    }
}

