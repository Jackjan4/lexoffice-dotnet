using System.Collections.Generic;

namespace De.Roslan.LexofficeDotnet.Models.VoucherList {
    public class VoucherList {
        public List<VoucherListEntry> content { get; set; }
        public bool first { get; set; }
        public bool last { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public int numberOfElements { get; set; }
        public int size { get; set; }
        public int number { get; set; }
        public List<VoucherListSort> sort { get; set; }
    }
}
