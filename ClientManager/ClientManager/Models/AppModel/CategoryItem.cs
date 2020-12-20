using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Models.AppModel
{
    public class CategoryItem
    {
        public int? Id { get; set; }
        public string CategoryItemName { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        public Bitmap Image { get; set; }
    }
}
