using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Models {
    public class PostResponse {
        public string id { get; set; }
        public string resourceUri { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
        public int version { get; set; }
    }
}
