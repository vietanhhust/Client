using ClientManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using ClientManager.Model.StaticModel;
using System.Threading;
using ClientManager.Services;

namespace ClientManager
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "1282409aslkdjasksjiod-0qwqr3243ui2jhsfsbjs");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                StaticInitializeService.StaticItemInitialize();
                Application.Run(StaticModels.LockForm);
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("instace of app is use");
            }
            //StaticInitializeService.SaveToFile(new ClientInfoModel()
            //{
            //    ClientId = 2,
            //    ServerIp = "192.168.0.2:5001"
            //});
            //var obj = StaticInitializeService.LoadFromFile();
            //Console.Write(obj.ClientId + " : " + obj.ServerIp);
            //Console.ReadLine();
        }

        private static HubConnection CreateConnection()
        {
            var conn = new HubConnectionBuilder().WithUrl("http://192.168.1.2:5001/testhub", option=> {
                option.Headers.Add("Day-la-test", "1");
            }).Build();
            return conn;
          
        }
    }
}
