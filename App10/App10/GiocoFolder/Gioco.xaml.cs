using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gioco : ContentPage
    {
        public Gioco()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new App10.Play());
        }
        public void Test()
        {
            //metodo aggiunto in branch test
        }
        public void Test2()
        {
            //metodo aggiunto in branch test
        }


        public void Master()
        {
            //metodo aggiunto in branch test
        }

    }
}