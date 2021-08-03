using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Family_Dashboard.Data;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;


namespace Family_Dashboard.Services
{
	public class ImageService 
	{
        private readonly HttpClient httpClient;

        public ImageService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetImages()
        {
            string URL = string.Empty;
            string s = await httpClient.GetStringAsync(URL);
            return s;
        }
    }
}
