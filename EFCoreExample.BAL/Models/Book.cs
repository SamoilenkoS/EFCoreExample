using System;
using System.Text.Json.Serialization;

namespace EFCoreExample.BAL.Models
{
    public class Book
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
    }
}