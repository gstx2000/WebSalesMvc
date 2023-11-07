using System.Collections.Generic;
using WebSalesMvc.Models;

namespace WebSalesMvc.Models
{
    public class SalesRecordsCreateViewModel
    {
        public List<Seller> Sellers { get; set; }
        public SalesRecord SalesRecord { get; set; }
    }

}