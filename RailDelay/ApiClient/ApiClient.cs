using CoreApiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient<T>
    {
        public Uri BaseEndPoint { get; }

        private readonly HttpClient _httpClient; 

        public ApiClient(Uri baseEndPoint)
        {
            BaseEndPoint = baseEndPoint ?? throw new ArgumentNullException("baseEndPoint");
            _httpClient = new HttpClient();
        }

        public async Task<List<T>> GetAsync<T1>(Uri requestUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(data);
        }

        private HttpContent CreateHttpContent<T1>(T Content)
        {
            string json = JsonConvert.SerializeObject(Content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }

        public async Task<Message<T>> PostAsync(Uri requestUrl, T Content)
        {
            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T>(Content));
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T>>(data);
        }

        public async Task<Message<T2>> PostAsync<T2>(Uri requestUrl, T Content)
        {
            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T>(Content));
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Message<T2>>(data);
        }

        private Uri CreateRequestUri (string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndPoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint)
            {
                Query = queryString
            };
            return uriBuilder.Uri;
        }
    }
}
