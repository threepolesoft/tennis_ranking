using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tennis_ranking.Models;
using tennis_ranking.View;
using tennis_ranking.ViewModels;
using Xamarin.Forms;

namespace tennis_ranking
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new top_ten();

        }


        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var dets = e.Item as Item;

            await Navigation.PushAsync(new details(dets));
        }

    }
}
