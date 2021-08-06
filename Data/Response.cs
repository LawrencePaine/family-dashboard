using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Resources;
using System.Reflection;

namespace Family_Dashboard.Data
{
	public class Response
	{
        private readonly HttpClient httpClient;
        public Response()
        {
        }

        public Response(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetJsonResponse()
		{
			try
			{
                string url = Properties.Resources.Url;
                string client_id = Properties.Resources.ClientID;
                string client_secret = Properties.Resources.ClientSecret;
                
                RestClient restclient = new RestClient(url);
                RestRequest request = new RestRequest(Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("client_id", client_id);
                request.AddParameter("client_secret", client_secret);
                request.AddParameter("scope", "https://3A//www.googleapis.com/auth/photoslibrary.readonly");
                request.AddParameter("approval_prompt", "force");
                request.AddParameter("response_type", "code");
                request.AddParameter("redirect_uri", "https://localhost:44300");
                
                Console.WriteLine(request);
                IRestResponse tResponse = restclient.Execute(request);
           
                var responseJson = tResponse.Content;
                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson)["access_token"].ToString();
                Console.WriteLine(token);
                return token;
                //return token.Length > 0 ? token : null;
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex);
				throw new Exception();
			}
            
        }

        public async Task<string> GetImages()
        {
            string URL = string.Empty;
            string response = await httpClient.GetStringAsync(URL);
            return response;
        }

	}
}
