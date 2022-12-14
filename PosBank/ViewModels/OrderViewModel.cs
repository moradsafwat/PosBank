using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public decimal OrderAmount { get; set; }
    }
}
