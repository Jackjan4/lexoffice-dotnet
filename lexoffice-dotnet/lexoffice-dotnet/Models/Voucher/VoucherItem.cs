using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Voucher {
    public class VoucherItem {

        public double amount { get; set; }
        public double taxAmount { get; set; }
        public double taxRatePercent { get; set; }
        public string categoryId { get; set; }
    }
}
