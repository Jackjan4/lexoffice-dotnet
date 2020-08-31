using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Contact {
    public class ContactPerson {

        public string salutation { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool primary { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
    }
}
