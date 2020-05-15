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

    public string CountOccurrences()
    {
      int occurrences = 0;
      for (int i = 0; i <= (TemplateString.Length - ScanningString.Length - 1); i++)
      {              
        string substringBeingTested;
        string modifiedScanningString;
        if (i == 0)
        {
          modifiedScanningString = ScanningString + " ";
        }
        else if (i == (TemplateString.Length - ScanningString.Length - 1))
        {
          modifiedScanningString = " " + ScanningString;
        }
        else
        {
          modifiedScanningString = " " + ScanningString + " ";
        }
        
        substringBeingTested = TemplateString.Substring(i,(modifiedScanningString.Length));        
        if (substringBeingTested == modifiedScanningString)
        {
          occurrences += 1;
        }

      }
      return "Your search string occurs: " + occurrences + " times in the host string.";
    }
  }
}