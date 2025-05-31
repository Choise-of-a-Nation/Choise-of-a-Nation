using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Profile
{
    [Serializable]
    public class Player
    {
        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("playedHours")]
        public int PlayedHours;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("userName")]
        public string UserName;

        [JsonProperty("id")]
        public string Id;
    }
}
