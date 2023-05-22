using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tennis_ranking.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sp : ContentPage
    {
        public sp()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new MainPage());

            /*await Task.WhenAny<bool>
            (
                image.ScaleTo(1, 2000),
                image.ScaleTo(0.9, 1500, Easing.Linear),
                image.ScaleTo(150, 1200, Easing.Linear)
            );*/
        }
    }
}