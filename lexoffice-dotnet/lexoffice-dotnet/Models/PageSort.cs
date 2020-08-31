using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class PageSort {
        public string property { get; set; }
        public string direction { get; set; }
        public bool ignoreCase { get; set; }
        public string nullHandling { get; set; }
        public bool ascending { get; set; }
    }
}
