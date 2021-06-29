using System;

namespace EFCoreExample.BAL.Models
{
  public class Book
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PagesCount { get; set; }
  }
}
