using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace De.Roslan.LexofficeDotnet {
    internal class RestClient {
        public string BaseUrl { get; }

        public string ApiKey { get; }

        private readonly RestSharp.RestClient _client;

        public RestClient(string baseUrl, string apiKey)
        {
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;

            _client = CreateClient();
        }


        private RestSharp.RestClient CreateClient()
        {
            var client = new RestSharp.RestClient(BaseUrl);
            client.AddDefaultHeader("Authorization", $"Bearer {ApiKey}");
            client.AddDefaultHeader("Accept","application / json");
            return client;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resource"></param>
        /// <returns></returns>
        public IRestResponse<T> SendRequest<T>(string resource)
        {
            var req = new RestRequest(resource);
            return _client.Get<T>(req);

        }
    }
}
