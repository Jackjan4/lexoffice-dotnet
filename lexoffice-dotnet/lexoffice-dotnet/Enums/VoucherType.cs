using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Enums
{
    [Flags]
    public enum VoucherType {
        SalesInvoice = 1,
        SalesCreditNote = 2,
        PurchaseInvoice = 4,
        PurchaseCreditNote = 8,
        Invoice = 16,
        CreditNote = 32,
        OrderConfirmation = 64,
        Quotation = 128
    }
}
