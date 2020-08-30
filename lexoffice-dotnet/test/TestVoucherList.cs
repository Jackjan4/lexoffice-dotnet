using De.Roslan.LexofficeDotnet;
using De.Roslan.lexofficeDotnet.Enums;
using De.Roslan.LexofficeDotnet.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test {
    [TestClass]
    public class TestVoucherList {



        [TestMethod]
        public void TestVoucherListNormal() {

            LexOfficeApi api = new LexOfficeApi("705a1afd-0636-4766-8bcb-68a7d0b5a6cd");

            var lst = api.VoucherListEndPoint.GetVoucherList(VoucherType.Invoice, VoucherStatus.Open | VoucherStatus.Paid, VoucherListArchived.Both,0,10);

            Console.WriteLine("Done");
        }

        [TestMethod]
        public void TestVoucherListSorted() {

            LexOfficeApi api = new LexOfficeApi("705a1afd-0636-4766-8bcb-68a7d0b5a6cd");

            api.VoucherListEndPoint.GetVoucherListSorted(VoucherType.Invoice, VoucherStatus.Open | VoucherStatus.Paid, VoucherListArchived.Both, false, VoucherListSorter.VoucherDate);
        }
    }
}
