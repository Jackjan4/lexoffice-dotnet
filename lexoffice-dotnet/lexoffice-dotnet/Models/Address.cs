using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class Address {

        public string contactId { get; set; }
        public string name { get; set; }
        public string supplement { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string countryCode { get; set; }
        public string contactPerson { get; set; }
    }
}
