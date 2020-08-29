using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class UnitPriceItem {

        public string currency { get; set; }
        public double netAmount { get; set; }
        public double grossAmount { get; set; }
        public int taxRatePercentage { get; set; }
    }
}
