using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Contact {
    public class Addresses {
        public List<Address> billing { get; set; }
        public List<Address> shipping { get; set; }
    }
}
