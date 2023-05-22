using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using tennis_ranking.ViewModels;
using Xamarin.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading.Tasks;
using tennis_ranking.View;
using tennis_ranking;
using tennis_ranking.Models;

namespace tennis_ranking.ViewModels
{
    public class top_ten  
    {
        public ObservableCollection<Item> Items { get; set; }

        public top_ten()
        {
            try
            {
                Items = new ObservableCollection<Item>();

                string fn = "data.json";

                var assembly = typeof(MainPage).GetTypeInfo().Assembly;

                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fn}");

                var reader = new StreamReader(stream);

                var js = reader.ReadToEnd();

                stream.Close();

                Items = JsonConvert.DeserializeObject<ObservableCollection<Item>>(js);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }


        }

    }
}
