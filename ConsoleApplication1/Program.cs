using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Task t = new Task(proceso);
            t.Start();

            Console.ReadLine();
            
        }

        static async void proceso()

        {
            
            HttpClient client = new HttpClient();

            string url = "https://api.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=b29d732d8f5f89f1b5922d475f4e4c52&format=json&nojsoncallback=1";

            var muestraURL = string.Format(url);

            string resultado = await client.GetStringAsync(muestraURL);

           
            
            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(resultado);

           


            if (apiData.stat == "ok")
            {
                foreach (Photo data in apiData.photos.photo)
                {
                   
                                    
                    Console.Write("https://farm");
                    Console.Write(data.farm);
                    Console.Write(".staticflickr.com/");
                    Console.Write(data.server);
                    Console.Write("/");
                    Console.Write(data.id);
                    Console.Write("_");
                    Console.Write(data.secret);
                    Console.WriteLine(".jpg");


                 }
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
    }
}
