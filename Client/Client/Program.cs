using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Forms;
using System.Threading;
using Client.Services;
using Newtonsoft.Json;
using Client.Model.StaticModel;
using System.Configuration;

namespace Client
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.Run(new LoginForm());

            //while (true)
            //{
            //    var a = Console.ReadKey();
            //    // Nếu để localhost thì gọi api rât chậm, còn nếu set thẳng IP gọi thì rất nhanh. 
            //    // (có lẽ nguyên nhân là do cái kia phải truy cập file host nên chậm) 
            //    Console.WriteLine(service.postEntity<LoginModel>("http://192.168.1.2:5001/api/Authentication/Account", new LoginModel()
            //    {
            //        Password = "VuvietAnh",
            //        Username = "first_user"
            //    }).Content.ReadAsStringAsync().Result);
            //    Console.WriteLine("Lấy được dư lieu");
            //}

           
        }
    }
}
