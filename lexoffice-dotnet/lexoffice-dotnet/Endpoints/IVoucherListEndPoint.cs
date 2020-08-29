using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Models.VoucherList;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface IVoucherListEndPoint {


        public LexOfficeResponse<VoucherList> GetVoucherListSorted(VoucherType type, VoucherStatus status,
            VoucherListArchived archived, bool desc, VoucherListSorter sorter, int page = 0, int pageSize = 25);

        public LexOfficeResponse<VoucherList> GetVoucherList(VoucherType type, VoucherStatus status,
            VoucherListArchived archived, int page = 0, int pageSize = 25);


    }
}
