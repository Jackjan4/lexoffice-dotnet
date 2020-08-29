using System;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Models.VoucherList;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class VoucherListHandler : EndPointHandler, IVoucherListEndPoint
    {


        internal VoucherListHandler(RestClient client) : base(client) {}


        public LexOfficeResponse<VoucherList> GetVoucherList(VoucherType type, VoucherStatus status, VoucherListArchived archived, int page = 0, int pageSize = 25) {

            var result = PrepareVoucherListString(type, status, archived, page, pageSize);
            var response = client.SendGetRequest<VoucherList>(result);
            return new LexOfficeResponse<VoucherList>(response);

        }


        

        public LexOfficeResponse<VoucherList> GetVoucherListSorted(VoucherType type, VoucherStatus status, VoucherListArchived archived, bool desc, VoucherListSorter sorter, int page = 0, int pageSize = 25) {
            var result = PrepareVoucherListString(type, status, archived, page, pageSize);



            // Parse Sorter
            // Parse Status
            string strSorter = "sort=";
            foreach (VoucherListSorter e in Enum.GetValues(typeof(VoucherListSorter))) {
                if (sorter.HasFlag(e)) {
                    strSorter += e.ToString().ToLower() + ",";
                }
            }
            // TODO: Status "Overdue" cannot be filtered with other status filters
            strSorter = strSorter.Substring(0, strSorter.Length - 1);


            if (desc) {
                strSorter += ",DESC";
            } else {
                strSorter += ",ASC";
            }

            result += $"&{strSorter}&";
            var response = client.SendGetRequest<VoucherList>(result);
            return new LexOfficeResponse<VoucherList>(response);
        }



        /// <summary>
        /// Prepare and populate the REST-resource string that should be send
        /// </summary>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="archived"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        private string PrepareVoucherListString(VoucherType type, VoucherStatus status, VoucherListArchived archived, int page, int pageSize) {
            string resource = "/voucherlist?";



            // Parse Type
            string vouchertype = "voucherType=";
            foreach (VoucherType e in Enum.GetValues(typeof(VoucherType))) {
                if (type.HasFlag(e)) {
                    vouchertype += e.ToString().ToLower() + ",";
                }
            }
            vouchertype = vouchertype.Substring(0, vouchertype.Length - 1);



            // Parse Status
            string voucherstatus = "voucherStatus=";
            foreach (VoucherStatus e in Enum.GetValues(typeof(VoucherStatus))) {
                if (status.HasFlag(e)) {
                    voucherstatus += e.ToString().ToLower() + ",";
                }
            }
            // TODO: Status "Overdue" cannot be filtered with other status filters
            voucherstatus = voucherstatus.Substring(0, voucherstatus.Length - 1);



            // Parse Archived
            string strArchived = "";
            if (archived != VoucherListArchived.Both) {
                switch (archived) {
                    case VoucherListArchived.Archived:
                        strArchived = "archived=true";
                        break;
                    case VoucherListArchived.NonArchived:
                        strArchived = "archived=false";
                        break;
                }
            }



            // Parse PageSize
            string strPageSize = "";
            if (pageSize != 25) {
                if (pageSize > 250) {
                    pageSize = 250;
                }

                if (pageSize < 1) {
                    pageSize = 1;
                }
                strPageSize = $"size={pageSize}";
            }



            // Parse Page
            string strPage = "";
            if (page > 0) {
                strPage = $"page={page}";
            }

            string result = $"{resource}{vouchertype}&{voucherstatus}&{strArchived}&{strPageSize}&{strPage}";

            return result;
        }
    }
}