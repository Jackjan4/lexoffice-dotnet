using De.Roslan.LexofficeDotnet.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    internal class InvoiceHandler : EndPointHandler {

        public InvoiceHandler(RestClient client) : base(client) { }


        public Invoice RetrieveInvoice(string id)
        {
            string resource = $"/invoices/{id}";

            return client.SendRequest<Invoice>(resource).Data;
        }
    }
}
