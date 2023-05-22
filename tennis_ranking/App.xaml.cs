using System;
using tennis_ranking.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tennis_ranking
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new sp());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
