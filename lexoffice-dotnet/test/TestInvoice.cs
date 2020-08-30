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
            LexOfficeApi api = new LexOfficeApi("705a1afd-0636-4766-8bcb-68a7d0b5a6cd");

            var invoice = api.InvoiceEndPoint.RetrieveInvoice("d150ca2a-bf7d-4291-b662-55980bdfde5c");

            Console.WriteLine("Done");
        }
    }
}
