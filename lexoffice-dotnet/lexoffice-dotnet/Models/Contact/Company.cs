using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Contact {
    public class Company {

        public string name { get; set; }
        public string taxNumber { get; set; }
        public string vatRegistrationId { get; set; }
        public bool allowTaxFreeInvoices { get; set; }
        public List<ContactPerson> contactPersons { get; set; }

    }
}
