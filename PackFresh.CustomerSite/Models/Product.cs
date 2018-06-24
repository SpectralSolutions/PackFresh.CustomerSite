using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackFresh.CustomerSite.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string RangeName { get; set; }
        public string Description { get; set; }
        public string Uses { get; set; }
        public List<ProductRange> Range { get; set; }
    }
}
