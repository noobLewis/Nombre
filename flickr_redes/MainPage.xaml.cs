using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;



namespace flickr_redes
{

    public partial class MainPage : Page

    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            proceso();
        }


        public async void proceso()

        {

            HttpClient client = new HttpClient();

            string url = "https://api.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=b29d732d8f5f89f1b5922d475f4e4c52&format=json&nojsoncallback=1";

            var muestraURL = string.Format(url);

            string resultado = await client.GetStringAsync(muestraURL);



            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(resultado);


            

            if (apiData.stat == "ok")
            {
                int i = 0;
                string[] cadena = new string[11];
                string[] titulo = new string [11];

                
                foreach (Photo data in apiData.photos.photo)
                {

                    string uerl = "https://farm" + data.farm + ".staticflickr.com/" + data.server + "/" + data.id + "_" + data.secret + ".jpg";

                    cadena[i] = uerl;

                    titulo[i] = data.title;
                    
                    i++;
                    if (i == 10) break;
                }

                

                textBlock0.Text = cadena[0] + "\n" + titulo[0]; 
                textBlock1.Text = cadena[1] + "\n" + titulo[1];
                textBlock2.Text = cadena[2] + "\n" + titulo[2];
                textBlock3.Text = cadena[3] + "\n" + titulo[3];
                textBlock4.Text = cadena[4] + "\n" + titulo[4];
                textBlock5.Text = cadena[5] + "\n" + titulo[5];
                textBlock6.Text = cadena[6] + "\n" + titulo[6];
                textBlock7.Text = cadena[7] + "\n" + titulo[7];
                textBlock8.Text = cadena[8] + "\n" + titulo[8];
                textBlock9.Text = cadena[9] + "\n" + titulo[9];

                textBlock0.MaxLines = 1;
                textBlock1.MaxLines = 1;
                textBlock2.MaxLines = 1;
                textBlock3.MaxLines = 1;
                textBlock4.MaxLines = 1;
                textBlock5.MaxLines = 1;
                textBlock6.MaxLines = 1;
                textBlock7.MaxLines = 1;
                textBlock8.MaxLines = 1;
                textBlock9.MaxLines = 1;
                

            }

        }

        public class Photo
        {
            public string id { get; set; }
            public string owner { get; set; }
            public string secret { get; set; }
            public string server { get; set; }
            public int farm { get; set; }
            public string title { get; set; }
            public int ispublic { get; set; }
            public int isfriend { get; set; }
            public int isfamily { get; set; }
        }

        public class Photos
        {
            public int page { get; set; }
            public int pages { get; set; }
            public int perpage { get; set; }
            public int total { get; set; }
            public List<Photo> photo { get; set; }
        }

        public class FlickrData
        {
            public Photos photos { get; set; }
            public string stat { get; set; }
        }


        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock0.Text);            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock1.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock2.Text);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock3.Text);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock4.Text);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock5.Text);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock6.Text);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock7.Text);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock8.Text);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(imagen_net), textBlock9.Text);
        }

        private void button_reload_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }

}

