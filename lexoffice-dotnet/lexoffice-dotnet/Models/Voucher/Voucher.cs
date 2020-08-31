using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Endpoints;

namespace De.Roslan.LexofficeDotnet.Models.Voucher {
    public class Voucher {
        public string id { get; set; }
        public string organizationId { get; set; }
        public string type { get; set; }
        public string voucherStatus { get; set; }
        public string voucherNumber { get; set; }
        public DateTime voucherDate { get; set; }
        public DateTime dueDate { get; set; }
        public double totalGrossAmount { get; set; }
        public double totalTaxAmount { get; set; }
        public string taxType { get; set; }
        public bool useCollectiveContact { get; set; }
        public string remark { get; set; }
        public List<VoucherItem> voucherItems { get; set; }
        public List<object> files { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public int version { get; set; }
    }
}
