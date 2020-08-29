using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    internal abstract class EndPointHandler {

        protected RestClient client { get; set; }

        public EndPointHandler(RestClient client)
        {
            this.client = client;
        }
    }
}
