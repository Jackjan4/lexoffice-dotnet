using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class LineItem {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public string unitName { get; set; }
        public UnitPriceItem unitPrice { get; set; }
        public int discountPercentage { get; set; }
        public double lineItemAmount { get; set; }
    }
}
