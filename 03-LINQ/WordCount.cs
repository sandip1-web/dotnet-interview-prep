using System;
using System.Linq;

class Program
{
  public static void Main(string[] args)
  {
    string str = "this is dotnet and this is csharp";

    var result = str.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x).Select(g => new { Word = g.Key, Count = g.Count() });

    foreach (var item in result)
    {
      System.Console.WriteLine(item.Word + " : " + item.Count);
    }
  }
}