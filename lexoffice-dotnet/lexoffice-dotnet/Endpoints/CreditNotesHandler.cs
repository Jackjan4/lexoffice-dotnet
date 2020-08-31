using De.Roslan.LexofficeDotnet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public class CreditNotesHandler : EndPointHandler, ICreditNotesEndPoint {

        public CreditNotesHandler(RestClient client) : base(client) {
        }
        public LexOfficeResponse<PostResponse> CreateCreditNote(CreditNote cNote, bool finalize) {
            string resource = $"/credit-notes";

            if (finalize) {
                resource += "?finalize=true";
            }

            var response = client.SendPostRequest<PostResponse>(resource, cNote);
            return new LexOfficeResponse<PostResponse>(response);
        }

        public LexOfficeResponse<DocumentLink> RenderCreditNoteDocument(string cNoteId) {
            string resource = $"/credit-notes/{cNoteId}/document";

            var response = client.SendGetRequest<DocumentLink>(resource);
            return new LexOfficeResponse<DocumentLink>(response);
        }

        public LexOfficeResponse<CreditNote> RetrieveCreditNote(string cNoteId) {
            string resource = $"/invoices/{cNoteId}";

            var response = client.SendGetRequest<CreditNote>(resource);
            return new LexOfficeResponse<CreditNote>(response);
        }


    }
}
