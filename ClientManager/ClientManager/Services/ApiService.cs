using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Drawing;

namespace ClientManager.Services
{
    class ApiService: IDisposable
    {
        
        // Tất cả api đều nhận về HttpRespone để xử lý.
        public T Test<T>(string json) where T : class
        {
            var x = JsonConvert.DeserializeObject<T>(json);
            return x;
        }  
     
        // Get
        public HttpResponseMessage getEntity(string url)
        {
            using(HttpClient client = new HttpClient())
            {
                // Tạo Httpheader.
                try
                {
                    HttpRequestMessage message = new HttpRequestMessage();
                    message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    message.Method = HttpMethod.Get;
                    message.RequestUri = new Uri(url);
                    return client.SendAsync(message).Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        // Post 
        public HttpResponseMessage postEntity<T>(string url, T body) where T: class
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Tạo Httpheader.
                    HttpRequestMessage message = new HttpRequestMessage();
                    message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    message.Method = HttpMethod.Post;
                    message.RequestUri = new Uri(url);
                    message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                    return client.SendAsync(message).Result;
                }
                catch
                {
                    return null;
                }
                   
               
            }
        }

        //Put 
        public HttpResponseMessage putEntity<T>(string url, T body) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Tạo Httpheader.
                    HttpRequestMessage message = new HttpRequestMessage();
                    message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    message.Method = HttpMethod.Put;
                    message.RequestUri = new Uri(url);
                    message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                    return client.SendAsync(message).Result;
                }
                catch
                {
                    return null; 
                }
            }
        }

        // Delete 
        public HttpResponseMessage deleteEntity<T>(string url, T body) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Tạo Httpheader.
                    HttpRequestMessage message = new HttpRequestMessage();
                    message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    message.Method = HttpMethod.Delete;
                    message.RequestUri = new Uri(url);
                    message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                    return client.SendAsync(message).Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        // Get Image 
        public Bitmap getImage(string url)
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    var result = client.GetAsync(url).Result;
                    var image = Image.FromStream(result.Content.ReadAsStreamAsync().Result);
                    return new Bitmap(image);
                }
            }catch
            {
                return null;
            }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
