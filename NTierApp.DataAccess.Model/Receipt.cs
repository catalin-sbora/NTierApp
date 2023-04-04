using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DataAccess.Model
{
    public class Receipt: ModelEntity
    {
     
        public ICollection<ReceiptEntry>? ReceiptEntries { get; set; }   
        public DateTime GeneratedDateTime { get; set; }
    }
}
