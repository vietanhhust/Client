using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Client.Model.StaticModel
{
    class StaticModels
    {
    }

    public class LoginModel{
        public string Username { get; set; }
        public string Password { get; set; }
    }

    static public class Static
    {
        static public T Convert<T>(string json) where T: class
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
