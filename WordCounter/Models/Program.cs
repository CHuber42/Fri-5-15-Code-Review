using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(
@"                Hello, and welcome to my program!
              Today we're going to scan a given sentence
              to see if (and how many times) a particular
              sequence of letters or symbols in it occurs.
              
      First, give me a series of letters, numbers, or symbols to scan.");
      
      string templateString = Console.ReadLine();

      Console.WriteLine(
@"                
              
      Next: give me a series of letters numbers or symbols to scan for.");
      string scanString = Console.ReadLine();

      RepeatCounter scanner = new RepeatCounter(templateString, scanString);

    }
  }    
}
