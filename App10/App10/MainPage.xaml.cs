using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gioco());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePersonAsync(new Test.Persona()
                {
                    Nome = nameEntry.Text,
                    Età = int.Parse(ageEntry.Text)
                });
            }

            nameEntry.Text = ageEntry.Text = "";
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }
}
