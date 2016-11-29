using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
using System.Threading;



//using System.Windows.Input.MouseEventArgs;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace flickr_redes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class imagen_net : Page
    {
       

        public imagen_net()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

                        

            var direccion = (string)e.Parameter;

            string tamanio = direccion.Length.ToString();
            int tamanio_numero = int.Parse(tamanio.ToString());
            int titulo_longitud = tamanio_numero - 62;

            string link_imagen = direccion.Substring(0, 62);
            string titulo_imagen = direccion.Substring(62, titulo_longitud);
            

            CargarImagen.Source = new BitmapImage(new Uri(link_imagen));

                
            btn_Face.NavigateUri = new Uri("https://www.facebook.com/sharer/sharer.php?u=" + link_imagen);
            btn_Twit.NavigateUri = new Uri("https://twitter.com/?status=" + link_imagen);
            btn_Goog.NavigateUri = new Uri("https://plus.google.com/share?url=" + link_imagen);
            btn_Link.NavigateUri = new Uri("http://www.linkedin.com/shareArticle?url=" + link_imagen);


            textBlock_Titulo.Text = titulo_imagen;
            
            

        }
        




        private void buttonRetorno_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
            
        }




       
    }
}
