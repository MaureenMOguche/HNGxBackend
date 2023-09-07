using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace stage1.Models
{
    public class HngDetail
    {
        [JsonPropertyName("slack_name")]
        public string SlackName { get; set; } = string.Empty;
        [JsonPropertyName("current_day")]
        public string CurrentDay { get; set; } = string.Empty;
        [JsonPropertyName("utc_time")]
        public DateTime UtcTime { get; set; }
        [JsonPropertyName("track")]
        public string Track { get; set; } = string.Empty;
        [JsonPropertyName("github_file_url")]
        public string GithubFile { get; set; } = string.Empty;
        [JsonPropertyName("github_repo_url")]
        public string GithubRepo { get; set; } = string.Empty;
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }
    }
}