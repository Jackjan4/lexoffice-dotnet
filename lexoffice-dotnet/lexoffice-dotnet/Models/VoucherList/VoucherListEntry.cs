using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.VoucherList {



    // TODO: This class is actually just a voucher but in the real voucher the VoucherType is called "type" and here it must be called "voucherType"
    public class VoucherListEntry {
        public string id { get; set; }
        public string voucherType { get; set; }
        public string voucherStatus { get; set; }
        public string voucherNumber { get; set; }
        public DateTime voucherDate { get; set; }
        public DateTime updatedDate { get; set; }
        public DateTime dueDate { get; set; }
        public string contactName { get; set; }
        public double totalAmount { get; set; }
        public string currency { get; set; }
        public bool archived { get; set; }
    }
}
