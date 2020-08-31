using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Voucher;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface IVouchersEndPoint {

        public LexOfficeResponse<PostResponse> CreateVoucher(Voucher voucher);
        public LexOfficeResponse<Voucher> RetrieveVoucher(string voucherId);
        public LexOfficeResponse<ResourcePage<Voucher>> FilterVouchers(string voucherNumber, int page = 0, int pageSize = 25);
        public LexOfficeResponse<PostResponse> UpdateVoucher(string voucherId, Voucher voucher);
        public LexOfficeResponse<DocumentLink> UploadFileToVoucher(string voucherId, string filePath);


    }
}
