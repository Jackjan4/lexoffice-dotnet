using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models.Contact {
    public class EmailAddresses {
        public List<string> business { get; set; }
        public List<string> office { get; set; }
        public List<string> privateAddresses { get; set; }
        public List<string> other { get; set; }
}
}
