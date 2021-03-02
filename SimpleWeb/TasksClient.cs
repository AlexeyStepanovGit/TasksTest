using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleWeb
{
    internal class TasksClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public TasksClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Stream> GetStreamAsync(Uri requestUrl) 
        { 
            return await _httpClient.GetStreamAsync(requestUrl);
        }
        public async Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent content)
        {
            return await _httpClient.PostAsync(requestUrl, content);
        }

        public void Dispose()
        {

            _httpClient?.Dispose();

        }
    }
}
