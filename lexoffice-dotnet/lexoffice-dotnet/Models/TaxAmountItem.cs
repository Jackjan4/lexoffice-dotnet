using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class TaxAmountItem {
        public int taxRatePercentage { get; set; }
        public double taxAmount { get; set; }
        public double netAmount { get; set; }
    }
}
