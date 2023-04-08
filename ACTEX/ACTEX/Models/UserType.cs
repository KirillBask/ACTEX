using Newtonsoft.Json;

namespace ACTEX.Models
{
    public class UserType
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        [JsonProperty("allow_edit")]
        public bool? AllowEdit { get; set; }
    }
}
