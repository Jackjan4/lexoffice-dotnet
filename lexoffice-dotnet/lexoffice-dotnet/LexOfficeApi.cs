using De.Roslan.LexofficeDotnet.Endpoints;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Models.Invoice;
using De.Roslan.LexofficeDotnet.Models.VoucherList;

namespace De.Roslan.LexofficeDotnet {
    public class LexOfficeApi {

        private string _apiKey;
        private readonly VoucherListHandler _voucherListHandler;
        private readonly InvoiceHandler _invoiceHandler;

        public string ApiKey
        {
            get { return _apiKey; }
            set { _apiKey = value; }
        }


        public LexOfficeApi(string apiKey) {
            this._apiKey = apiKey;


            // Create Handler with a RestClient
            RestClient client = new RestClient("https://api.lexoffice.io/v1", apiKey);

            _voucherListHandler = new VoucherListHandler(client);
            _invoiceHandler = new InvoiceHandler(client);

        }


        public VoucherList GetVoucherList(VoucherType type, VoucherStatus status, VoucherListArchived archived, int page = 0, int pageSize = 25) {
            return _voucherListHandler.GetVoucherList(type, status, archived, page, pageSize);


        }



        public VoucherList GetVoucherListSorted(VoucherType type, VoucherStatus status, VoucherListArchived archived, bool desc, VoucherListSorter sorter, int page = 0, int pageSize = 25) {
            return _voucherListHandler.GetVoucherListSorted(type, status, archived, desc, sorter, page, pageSize);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public Invoice RetrieveInvoice(string invoiceId)
        {
            return _invoiceHandler.RetrieveInvoice(invoiceId);
        }
    }
}
