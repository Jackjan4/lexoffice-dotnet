using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class CreditNote {

        public string id { get; set; }
        public string organizationId { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public int version { get; set; }
        public string language { get; set; }
        public bool archived { get; set; }
        public string voucherStatus { get; set; }
        public string voucherNumber { get; set; }
        public DateTime voucherDate { get; set; }
        public Address address { get; set; }
        public List<LineItem> lineItems { get; set; }
        public TotalPriceItem totalPrice { get; set; }
        public List<TaxAmountItem> taxAmounts { get; set; }
        public TaxConditions taxConditions { get; set; }
        public string title { get; set; }
        public string introduction { get; set; }
        public string remark { get; set; }
        public DocumentLink files { get; set; }
    }
}
