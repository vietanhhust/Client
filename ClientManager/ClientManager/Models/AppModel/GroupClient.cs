using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Models.AppModel
{
    public class GroupClient
    {
        public int? Id { get; set; }
        public string GroupName { get; set; }
        public string Desciption { get; set; }
        public int Price { get; set; }
    }
}
