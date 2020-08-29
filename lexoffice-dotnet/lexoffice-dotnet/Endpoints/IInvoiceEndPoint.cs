using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Invoice;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface IInvoiceEndPoint
    {

        public LexOfficeResponse<Invoice> RetrieveInvoice(string id);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="finalize"></param>
        public LexOfficeResponse<PostResponse> CreateInvoice(Invoice invoice, bool finalize);


        public LexOfficeResponse<DocumentLink> RenderInvoiceDocument(string invoiceId);
    }
}
