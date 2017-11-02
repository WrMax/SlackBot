using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SlackBot.Controllers
{
    public class Message 
    {
        public string channel_id { get; set; }
        public string channel_name { get; set; }
        public string command { get; set; }
        public string response_url { get; set; }
        public string team_domain { get; set; }
        public string team_id { get; set; }
        public string text { get; set; }
        public string token { get; set; }
        public string trigger_id { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
    }

    public class ResponseMessage
    { 
        public string text { get; set; }
        public string username { get; set; }
        public string bot_id { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string ts { get; set; }
    }

    public class Response
    {
        public bool ok { get; set; }
        public string channel { get; set; }
        public string ts { get; set; }
        public ResponseMessage message { get; set; }
    }
    [Route("bot")]
    public class BotController : Controller
    {
        // GET bot
        [HttpGet]
        public string Get()
        {
            return "Бот работает.";
        }

        // POST bot
        [HttpPost]
        public async void Post(Message message)
        {
            const string token = "xoxb-265651457460-eXxX2l41umaxAGSH4zXMERAI";
            var uri = new Uri("https://slack.com/api/chat.postMessage?token=" + token + "&channel=" + message.channel_id + "&text=hello");
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(uri).ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var responseObject = JsonConvert.DeserializeObject<Response>(responseString);
        }
    }
}
