using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Contact;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface IContactsEndPoint
    {


        public LexOfficeResponse<PostResponse> CreateContact(Contact contact);

        public LexOfficeResponse<Contact> RetrieveContact(string contactId);

        public LexOfficeResponse<PostResponse> UpdateContact(string contactId, Contact contact);

        public LexOfficeResponse<ResourcePage<Contact>> FilterContacts(string email = null, string name = null, int? number = null, bool? customer = null, bool? vendor = null);
    }
}
