using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class InvoiceHandler : EndPointHandler, IInvoiceEndPoint {

        internal InvoiceHandler(RestClient client) : base(client) { }


        public LexOfficeResponse<Invoice> RetrieveInvoice(string invoiceId) {
            string resource = $"/invoices/{invoiceId}";

            var response = client.SendGetRequest<Invoice>(resource);
            return new LexOfficeResponse<Invoice>(response);
        }

        public LexOfficeResponse<PostResponse> CreateInvoice(Invoice invoice, bool finalize = false) {
            string resource = $"/invoices";

            if (finalize) {
                resource += "?finalize=true";
            }

            var response = client.SendPostRequest<PostResponse>(resource, invoice);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<DocumentLink> RenderInvoiceDocument(string invoiceId) {
            string resource = $"/invoices/{invoiceId}/document";

            var response = client.SendGetRequest<DocumentLink>(resource);
            return new LexOfficeResponse<DocumentLink>(response);
        }
    }
}
