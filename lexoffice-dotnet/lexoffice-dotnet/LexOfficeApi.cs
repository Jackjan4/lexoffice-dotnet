using De.Roslan.LexofficeDotnet.Endpoints;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Models.Invoice;
using De.Roslan.LexofficeDotnet.Models.VoucherList;

namespace De.Roslan.LexofficeDotnet {
    public class LexOfficeApi {

        public IVoucherListEndPoint VoucherListEndPoint { get; }
        public IInvoiceEndPoint InvoiceEndPoint { get; }

        public IContactsEndPoint ContactsEndPoint { get; }


        public LexOfficeApi(string apiKey) {


            // Create Handler with a RestClient
            RestClient client = new RestClient("https://api.lexoffice.io/v1", apiKey);

            VoucherListEndPoint = new VoucherListHandler(client);
            InvoiceEndPoint = new InvoiceHandler(client);
            ContactsEndPoint = new ContactsHandler(client);

        }

    }
}
