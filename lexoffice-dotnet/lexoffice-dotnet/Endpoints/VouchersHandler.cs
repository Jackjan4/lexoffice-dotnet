using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Voucher;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    internal class VouchersHandler : EndPointHandler, IVouchersEndPoint {

        public VouchersHandler(RestClient client) : base(client) { }


        public LexOfficeResponse<PostResponse> CreateVoucher(Voucher voucher) {
            string resource = "/vouchers";

            var response = client.SendPostRequest<PostResponse>(resource, voucher);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<Voucher> RetrieveVoucher(string voucherId) {
            string resource = $"/vouchers/{voucherId}";

            var response = client.SendGetRequest<Voucher>(resource);
            return new LexOfficeResponse<Voucher>(response);
        }

        public LexOfficeResponse<ResourcePage<Voucher>> FilterVouchers(string voucherNumber, int page = 0, int pageSize = 25) {
            string resource = $"/vouchers?voucherNumber={voucherNumber}&page={page}&size={pageSize}";

            var response = client.SendGetRequest<ResourcePage<Voucher>>(resource);
            return new LexOfficeResponse<ResourcePage<Voucher>>(response);
        }

        public LexOfficeResponse<PostResponse> UpdateVoucher(string voucherId, Voucher voucher) {
            string resource = $"/vouchers/{voucherId}";

            var response = client.SendPutRequest<PostResponse>(resource, voucher);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<DocumentLink> UploadFileToVoucher(string voucherId, string filePath) {
            string resource = $"/vouchers/{voucherId}/files";

            var response = client.SendFileUploadRequest<DocumentLink>(resource, filePath);
            return new LexOfficeResponse<DocumentLink>(response);

        }
    }
}
