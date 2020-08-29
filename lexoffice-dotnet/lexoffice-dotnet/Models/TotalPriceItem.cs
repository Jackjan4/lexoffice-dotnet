using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class TotalPriceItem {

        public string currency { get; set; }
        public double totalNetAmount { get; set; }
        public double totalGrossAmount { get; set; }
        public double totalTaxAmount { get; set; }
    }
}
