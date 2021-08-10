using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Google.Apis;
using System.Net;
using System.Web;
using System.Text;
using System.IO;

namespace Family_Dashboard.Data
{
	public class Response
	{
        private readonly HttpClient httpClient;

        private System.Net.HttpListener _listener = null;
        private string _accessToken = null;
        private string _errorResult = null;
        private string _apiKey = null;
        private string _clientSecret = null;
        private string _redirectUri = null;
        public Response()
        {
        }

        public Response(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string ReceiveTokenGmail()
        {
            string postString = "code=" + code + "&client_id=" + Properties.Resources.ClientID + @"&client_secret=" + Properties.Resources.ClientSecret + "&redirect_uri=" + Properties.Resources.RedirectUrl;

            string url = "https://accounts.google.com/o/oauth2/token";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url.ToString());
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            UTF8Encoding utfenc = new UTF8Encoding();
            byte[] bytes = utfenc.GetBytes(postString);
            Stream os = null;
            try
            {
                request.ContentLength = bytes.Length;
                os = request.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
            }
            catch
            { }
            string result = "";

            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
            Stream responseStream = webResponse.GetResponseStream();
            StreamReader responseStreamReader = new StreamReader(responseStream);
            result = responseStreamReader.ReadToEnd();

            return result;
        }

        public async Task<string> GetJsonResponse()
		{
			try
			{
				//var client = new RestClient("https://photoslibrary.googleapis.com/v1/albums");
				//client.Timeout = -1;
				//var request = new RestRequest(Method.GET);
				//request.AddHeader("Authorization", "Bearer ya29.a0ARrdaM84Mud6p6KftnPJNxUErxpelxwgr6g5M9q0_pVGRJIaB06sQgx5s1PbemN8uMuk5_66tYs3RHLUIkuLRL0kJw5bl8Hq2tH-8ZHI2VmSA4nYAgbIdgfII9HEwU61nYYjfdTgmXH9TT3d45F8fIiJRiRdPAo");
				//IRestResponse response = client.Execute(request);
				//Console.WriteLine(response.Content);
                //Google.Apis.Auth.OAuth2Auth2.Requests auth = new Google.Apis.Auth.OAuth2.Requests
				string url = Properties.Resources.AuthURL;
				string client_id = Properties.Resources.ClientID;
				string client_secret = Properties.Resources.ClientSecret;
                _redirectUri = Properties.Resources.RedirectUrl.TrimEnd('/');
                _listener = new System.Net.HttpListener();
                _listener.Prefixes.Add(Properties.Resources.RedirectUrl + "/");
                _listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
                RestClient restclient = new RestClient(url);
				RestRequest request = new RestRequest(Method.GET);
				request.RequestFormat = DataFormat.Json;
				request.AddParameter("client_id", client_id);
				request.AddParameter("client_secret", client_secret);
				request.AddParameter("scope", "https://3A//www.googleapis.com/auth/photoslibrary.readonly");
				request.AddParameter("approval_prompt", "force");
				request.AddParameter("response_type", "code");
				request.AddParameter("redirect_uri", "https://localhost:44300");

				IRestResponse tResponse = restclient.Execute(request);
                
				string jsonstring = tResponse.Content;                
                return jsonstring;
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex);
				throw new Exception();
			}
            
        }

        public string GetToken()
        {
            var url = string.Format(@"https://api.surveymonkey.net/oauth/authorize?redirect_uri={0}&client_id=sm_sunsoftdemo&response_type=code&api_key=svtx8maxmjmqavpavdd5sg5p",
                    HttpUtility.UrlEncode(Properties.Resources.RedirectUrl));
            System.Diagnostics.Process.Start(url);

            _listener.Start();
            Task.Run(() => ListenLoop(_listener));
            //AsyncContext.Run(() => ListenLoop(_listener));
            _listener.Stop();

            if (!string.IsNullOrEmpty(_errorResult))
                throw new Exception(_errorResult);
            return _accessToken;
        }

        private async void ListenLoop(HttpListener listener)
        {
            while (true)
            {
                var context = await listener.GetContextAsync();
                var query = context.Request.QueryString;
                if (context.Request.Url.ToString().EndsWith("favicon.ico"))
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.Close();
                }
                else if (query != null && query.Count > 0)
                {
                    if (!string.IsNullOrEmpty(query["code"]))
                    {
                        _accessToken = await SendCodeAsync(query["code"]);
                        break;
                    }
                    else if (!string.IsNullOrEmpty(query["error"]))
                    {
                        _errorResult = string.Format("{0}: {1}", query["error"], query["error_description"]);
                        break;
                    }
                }
            }
        }

        private async Task<string> SendCodeAsync(string code)
        {
            var GrantType = "authorization_code";
            //client_secret, code, redirect_uri and grant_type. The grant type must be set to “authorization_code”
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.surveymonkey.net");
            var request = new HttpRequestMessage(HttpMethod.Post, string.Format("/oauth/token?api_key={0}", _apiKey));

            var formData = new List<KeyValuePair<string, string>>();
            formData.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));
            formData.Add(new KeyValuePair<string, string>("code", code));
            formData.Add(new KeyValuePair<string, string>("redirect_uri", _redirectUri));
            formData.Add(new KeyValuePair<string, string>("grant_type", GrantType));
            formData.Add(new KeyValuePair<string, string>("client_id", "sm_sunsoftdemo"));

            request.Content = new FormUrlEncodedContent(formData);
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                _errorResult = string.Format("Status {0}: {1}", response.StatusCode.ToString(), response.ReasonPhrase.ToString());
                return null;
            }

            var data = await response.Content.ReadAsStringAsync();
            if (data == null)
                return null;
            Dictionary<string, string> tokenInfo = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            return (tokenInfo["access_token"]);
        }

        public async Task<string> GetImages()
        {
            string URL = string.Empty;
            string response = await httpClient.GetStringAsync(URL);
            return response;
        }

	}
}
