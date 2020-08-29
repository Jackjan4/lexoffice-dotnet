using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class InvoiceHandler : EndPointHandler, IInvoiceEndPoint {

        internal InvoiceHandler(RestClient client) : base(client) { }


        /// <summary>
        /// Retrieves an invoice by its id.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public LexOfficeResponse<Invoice> RetrieveInvoice(string invoiceId) {
            string resource = $"/invoices/{invoiceId}";

            var response = client.SendGetRequest<Invoice>(resource);
            return new LexOfficeResponse<Invoice>(response);
        }



        /// <summary>
        /// Submits a given invoice to LexOffice. Please refer to the official documentation for which properties must be filled out and which must not.
        /// </summary>
        /// <param name="invoice">The invoice which is meant to be submitted</param>
        /// <param name="finalize">If true, submits the invoice as finalized. Otherwise saves it as a draft</param>
        /// <returns></returns>
        public LexOfficeResponse<PostResponse> CreateInvoice(Invoice invoice, bool finalize = false) {
            string resource = $"/invoices";

            if (finalize) {
                resource += "?finalize=true";
            }

            var response = client.SendPostRequest<PostResponse>(resource, invoice);
            return new LexOfficeResponse<PostResponse>(response);
        }



        /// <summary>
        /// Renders an invoice document as a PDF. This is needed because newly created invoices with status "open" need to trigger the PDF render process manually.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public LexOfficeResponse<DocumentLink> RenderInvoiceDocument(string invoiceId) {
            string resource = $"/invoices/{invoiceId}/document";

            var response = client.SendGetRequest<DocumentLink>(resource);
            return new LexOfficeResponse<DocumentLink>(response);
        }
    }
}
