using System;
using System.Text.Json.Serialization;

namespace TasksWeb.Model
{
    public sealed class TaskModel
    {
        /// <summary>Task identifier</summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("priority")]
        public ushort Priority { get; set; }

        [JsonPropertyName("status")]
        public TaskStatus Status { get; set; }

    }

   
}
