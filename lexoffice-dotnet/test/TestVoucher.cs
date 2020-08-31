using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet;
using De.Roslan.LexofficeDotnet.Enums;

namespace test {

    [TestClass]
    public class TestVoucher {

        [TestMethod]
        public void TestVoucherRetrieval()
        {

        }

        [TestMethod]
        public void TestFileToVoucherUpload()
        {
            LexOfficeApi api = new LexOfficeApi(Properties.Resources.apiKey);

            var lst = api.VouchersEndPoint.UploadFileToVoucher("123", @"C:\Users\Jackj\Downloads\test.jpg");

            Console.WriteLine("Done");
        }
    }
}
