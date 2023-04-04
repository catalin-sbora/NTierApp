using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.Model
{
    public class Sale: ModelEntity
    {
       
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public Receipt? Receipt { get; set; }
        public string? CashierName { get; set; }
    }
}
