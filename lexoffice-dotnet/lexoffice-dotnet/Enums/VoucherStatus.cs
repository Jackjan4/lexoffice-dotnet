using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Enums {

    [Flags]
    public enum VoucherStatus {
        Draft = 1,
        Open = 2,
        Overdue = 4,
        Paid = 8,
        Paidoff = 16,
        Voided = 32,
        Accepted = 64,
        Rejected = 128
    }
}
