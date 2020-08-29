using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.VoucherList {
    public class VoucherListSort {
        public string property { get; set; }
        public string direction { get; set; }
        public bool ignoreCase { get; set; }
        public string nullHandling { get; set; }
        public bool ascending { get; set; }
    }
}
