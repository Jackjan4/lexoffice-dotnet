using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace De.Roslan.LexofficeDotnet {
    public class LexOfficeResponse<T> {

        private readonly IRestResponse<T> _response;

        public T Data => _response.Data;

        public HttpStatusCode StatusCode => _response.StatusCode;

        internal LexOfficeResponse(IRestResponse<T> response) {
            _response = response;

        }


    }
}
