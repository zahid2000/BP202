using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalPrice { get; set; }

    }
}
