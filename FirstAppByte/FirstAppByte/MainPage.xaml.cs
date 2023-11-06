using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstAppByte
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();

            Label label = new Label();

            label.Text = "Подписка";
            label.TextColor = Color.Red;
            label.FontSize = 20;
            label.FontAttributes = FontAttributes.Bold;
            label.HorizontalOptions = LayoutOptions.Center;

            Entry input = new Entry();
            input.Placeholder = "Пароль";
            input.IsPassword = true;

            Entry input1 = new Entry
            {
                IsEnabled = false,
                Text = "Что-то написано"

            };

            StackLayout horizontLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
            };

            Label sub = new Label
            {
                Text = "Полписаться",
                FontSize = 25,
                FontAttributes = FontAttributes.Bold,
            };

            CheckBox checkBox = new CheckBox
            {
                IsChecked = true
            };

            horizontLayout.Children.Add(sub);
            horizontLayout.Children.Add(checkBox);


            layout.Children.Add(label);
            layout.Children.Add(input);
            layout.Children.Add(input1);
            layout.Children.Add(horizontLayout);

            Content = layout;

        }
    }
}
