using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
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
        /// <summary>
        /// Returns the name of the country that is specified by 'countryCode' in the localized version of this .NET installation
        /// </summary>
        public string localizedCountryName => new RegionInfo(countryCode).DisplayName;
    }
}
