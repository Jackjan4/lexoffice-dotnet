using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Contact {
    public class Contact {

        public string id { get; set; }
        public string organizationId { get; set; }
        public int version { get; set; }
        public Role roles { get; set; }
        public Company company { get; set; }
        public Addresses addresses { get; set; }
        public EmailAddresses emailAddresses { get; set; }
        public PhoneNumbers phoneNumbers { get; set; }
        public string note { get; set; }
        public bool archived { get; set; }
    }
}
