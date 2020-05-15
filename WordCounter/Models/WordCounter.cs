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


//Spec 6 options:
//1. .Split template into array using counter as argument, return array.length - 1 as result || 
//2. Take scanningstring.length, use as argument in sub-string accessor for comparison
//EXAMPLE: "Banana", "ana"; for (index < "Banana".Length - "ana".Length - 1; index++) {if ("Banana"[i:i+"ana".length] = "ana") {increase counter by 1}} counter becomes 2
//3. Using Select.Count arguments to auto-scan for substrings.

//Requires research.