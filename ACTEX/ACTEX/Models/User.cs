using Newtonsoft.Json;

namespace ACTEX.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
        [JsonProperty("last_visit_date")]
        public DateTime LastVisitDate { get; set; }
    }
}
