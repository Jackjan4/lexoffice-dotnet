using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.VoucherList;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface IVoucherListEndPoint {


        public LexOfficeResponse<ListResponse<VoucherListEntry>> GetVoucherListSorted(VoucherType type, VoucherStatus status,
            VoucherListArchived archived, bool desc, VoucherListSorter sorter, int page = 0, int pageSize = 25);

        public LexOfficeResponse<ListResponse<VoucherListEntry>> GetVoucherList(VoucherType type, VoucherStatus status,
            VoucherListArchived archived, int page = 0, int pageSize = 25);


    }
}
