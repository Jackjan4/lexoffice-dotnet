using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public abstract class EndPointHandler {

         protected internal RestClient client { get; }

        internal EndPointHandler(RestClient client)
        {
            this.client = client;
        }
    }
}
