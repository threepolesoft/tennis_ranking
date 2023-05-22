using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tennis_ranking.Models;
using tennis_ranking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tennis_ranking.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class details : ContentPage
    {
        public Item Item { get; set; }

        public details(Item des)
        {
            Item = des;

            InitializeComponent();

            _img.Source = des.img.ToString();
            _title.Text = des.title.Replace("0", "").Replace(".", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "")
                .Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "");
            //_des.Text = des.des;
        }

    }
}