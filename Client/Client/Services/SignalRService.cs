using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System.Configuration;

namespace Client.Services
{
    class SignalRService
    {
        static HubConnection CreateHubConnection()
        {
            var url = "";
            var con = new HubConnectionBuilder().WithUrl(url).Build();
            return con;
        }
    }
}
