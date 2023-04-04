using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.Model
{
    public class ReceiptEntry : ModelEntity
    {        
        public string ProductName { get; set; } = string.Empty;
        public int Qty { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Total { get; set; }
    }
}
