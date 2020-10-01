using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDataManager.Library.Models
{
    public class SaleDBModel
    {
        public int Id { get; set; }
        public string cashierId { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}
