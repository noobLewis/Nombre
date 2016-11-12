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



namespace flickr_image
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
                foreach (Photo data in apiData.photos.photo)
                {

                    string uerl = "https://farm" + data.farm + ".staticflickr.com/" + data.server + "/" + data.id + "_" + data.secret + ".jpg";
                                       
                    cadena[i] = uerl;
                    
                    i++;
                    if (i == 10) break;
                }

                textBlock0.Text = cadena[0];
                textBlock1.Text = cadena[1];
                textBlock2.Text = cadena[2];
                textBlock3.Text = cadena[3];
                textBlock4.Text = cadena[4];
                textBlock5.Text = cadena[5];
                textBlock6.Text = cadena[6];
                textBlock7.Text = cadena[7];
                textBlock8.Text = cadena[8];
                textBlock9.Text = cadena[9];

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
            Frame.Navigate(typeof(PaginaImagen), textBlock0.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock1.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock2.Text);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock3.Text);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock4.Text);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock5.Text);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock6.Text);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock7.Text);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock8.Text);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaImagen), textBlock9.Text);
        }

    }

    }

