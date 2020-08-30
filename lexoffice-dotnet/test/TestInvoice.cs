using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet;

namespace test {

    [TestClass]
    public class TestInvoice {

        [TestMethod]
        public void TestInvoiceRetrieval()
        {
            LexOfficeApi api = new LexOfficeApi(Properties.Resources.apiKey);

            var invoice = api.InvoiceEndPoint.RetrieveInvoice("d150ca2a-bf7d-4291-b662-55980bdfde5c");

            Console.WriteLine("Done");
        }
    }
}
