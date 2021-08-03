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
			//RestClient client = new RestClient("https://www.googleapis.com/tasks/v1/");
			try
			{
                string url = Properties.Resources.Url;
                string client_id = Properties.Resources.ClientID;
                string client_secret = Properties.Resources.ClientSecret;
                //string activeURL = Properties.Resources.app
                //request token
                RestClient restclient = new RestClient(url);
                RestRequest request = new RestRequest("request/oauth") { Method = Method.GET };
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("client_id", client_id);
                request.AddParameter("client_secret", client_secret);
                request.AddParameter("grant_type", "client_credentials");
                request.AddParameter("scope", "https % 3A//www.googleapis.com/auth/drive.metadata.readonly");
                request.AddParameter("access_type", "offline");
                request.AddParameter("include_granted_scopes", "true");
                request.AddParameter("response_type", "code");
                request.AddParameter("state", "state_parameter_passthrough_value");
                request.AddParameter("redirect_uri", "https % 3A//oauth2.example.com/code&");
                Console.WriteLine(request);
                var tResponse = restclient.Execute(request);
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
