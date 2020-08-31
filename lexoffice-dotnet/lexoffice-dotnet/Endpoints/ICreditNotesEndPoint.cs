using System;
using System.Collections.Generic;
using System.Text;
using De.Roslan.LexofficeDotnet.Models;

namespace De.Roslan.LexofficeDotnet.Endpoints {
    public interface ICreditNotesEndPoint
    {

        public LexOfficeResponse<PostResponse> CreateCreditNote(CreditNote cNote, bool finalize);
        public LexOfficeResponse<CreditNote> RetrieveCreditNote(string cNoteId);
        public LexOfficeResponse<DocumentLink> RenderCreditNoteDocument(string cNoteId);
        
        // Credit Note view deeplink

        // Credit Note Edit deeplink


    }
}
