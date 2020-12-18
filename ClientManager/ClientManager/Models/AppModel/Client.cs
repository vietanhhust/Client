using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Models.AppModel
{
    public class Client
    {
        public int? Id { get; set; }
        public int ClientId { get; set; }
        public int? ClientGroupId { get; set; }
        public string Description { get; set; }
        public bool? IsNew { get; set; }
    }
}
