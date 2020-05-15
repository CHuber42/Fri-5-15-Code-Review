using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string TemplateString{get;set;}
    public string ScanningString{get;set;}
    public RepeatCounter(string templateString, string scanningString)
    {
      TemplateString = templateString;
      ScanningString = scanningString;
    }

    public int CountOccurrences()
    {
      
      return TemplateString.Length;
    }
  }
}
