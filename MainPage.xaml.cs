using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarosuelView
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Item> Items = new ObservableCollection<Item>();

        private CarouselView carouselView;

        public MainPage()
        {
            InitializeComponent();

            Items.Add(new Item()
            {
                Content = new Label()
                {
                    BackgroundColor = Colors.Yellow,
                    Text = "Item1",
                    VerticalTextAlignment=TextAlignment.Center,
                    HorizontalTextAlignment=TextAlignment.Center,
                    WidthRequest = 300,
                    HeightRequest = 300
                }
            });
            Items.Add(new Item()
            {
                Content = new Label()
                {
                    Text = "Item2",
                    BackgroundColor = Colors.LightSkyBlue,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    WidthRequest = 300,
                    HeightRequest = 300
                }
            });
            Items.Add(new Item()
            {
                Content = new Label()
                {
                    Text = "Item3",
                    BackgroundColor = Colors.Red,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    WidthRequest = 300,
                    HeightRequest = 300
                }
            });

            Items.Add(new Item()
            {
                Content = new Label()
                {
                    Text = "Item4",
                    BackgroundColor = Colors.Violet,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    WidthRequest = 300,
                    HeightRequest = 300
                }
            });

            carouselView = new CarouselView()
            {
                Loop = false,
                IsSwipeEnabled = true,
                WidthRequest=500,
                HeightRequest=500,
                ItemsSource = this.Items.Where(t => t.Content != null),
                HorizontalOptions=LayoutOptions.Center,
                ItemTemplate = new DataTemplate(() =>
                {
                    ContentView contentView = new ContentView();
                    contentView.SetBinding(ContentView.ContentProperty, new Binding("Content"));
                    return contentView;
                })
            };
            
            Content = carouselView; 

        }
    }

    public class Item()
    {
        public View Content { get; set; }
    }
}
