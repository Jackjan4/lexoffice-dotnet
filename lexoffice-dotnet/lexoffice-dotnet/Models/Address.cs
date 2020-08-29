using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Invoice {
    public class Address {

        public string name { get; set; }
        public string supplement { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string countryCode { get; set; }
    }
}
