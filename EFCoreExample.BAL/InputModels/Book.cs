using System;
using System.Text.Json.Serialization;

namespace EFCoreExample.BAL.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
    }
}