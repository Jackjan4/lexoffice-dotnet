using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class PaymentConditions {
        public string paymentTermLabel { get; set; }
        public int paymentTermDuration { get; set; }
        public PaymentDiscountConditions paymentDiscountConditions { get; set; }

    }
}
