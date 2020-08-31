using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;
using De.Roslan.LexofficeDotnet.Models.Contact;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class ContactsHandler : EndPointHandler, IContactsEndPoint {
        public ContactsHandler(RestClient client) : base(client) {
        }

        public LexOfficeResponse<PostResponse> CreateContact(Contact contact) {
            string resource = "/contacts";

            var response = client.SendPostRequest<PostResponse>(resource, contact);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<Contact> RetrieveContact(string contactId) {
            string resource = $"/contacts/{contactId}";

            var response = client.SendGetRequest<Contact>(resource);
            return new LexOfficeResponse<Contact>(response);
        }

        public LexOfficeResponse<PostResponse> UpdateContact(string contactId, Contact contact) {
            string resource = $"/contacts/{contactId}";

            var response = client.SendPutRequest<PostResponse>(resource, contact);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<ResourcePage<Contact>> FilterContacts(string email = null, string name = null, int? number = null, bool? customer = null,
            bool? vendor = null) {

            string resource = $"/contacts/";

            if (email != null || name != null || number != null || customer != null) {
                resource += "?";
            }

            if (email != null) {
                resource += $"email={email}&";
            }

            if (name != null) {
                resource += $"name={name}&";
            }

            if (number != null) {
                resource += $"number={number}&";
            }

            if (customer != null) {
                resource += $"customer={customer}&";
            }

            if (vendor != null) {
                resource += $"vendor={vendor}&";
            }

            if (resource.EndsWith('&')) {
                resource = resource.Substring(0, resource.Length - 1);
            }

            var response = client.SendGetRequest<ResourcePage<Contact>>(resource);
            return new LexOfficeResponse<ResourcePage<Contact>>(response);
        }
    }
}
