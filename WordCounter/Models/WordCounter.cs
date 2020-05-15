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
      int occurrences = 0;
      for (int i = 0; i <= (TemplateString.Length - ScanningString.Length); i++)
      {
        string candidateSubstring = TemplateString.Substring(i,(ScanningString.Length));
        Console.WriteLine("Candidate: " + candidateSubstring);
        occurrences += 1;
      }
      return occurrences;
    }
  }
}


//Spec 6 options:
//1. .Split template into array using counter as argument, return array.length - 1 as result || 
//2. Take scanningstring.length, use as argument in sub-string accessor for comparison
//EXAMPLE: "Banana", "ana"; for (index < "Banana".Length - "ana".Length - 1; index++) {if ("Banana"[i:i+"ana".length] = "ana") {increase counter by 1}} counter becomes 2
//3. ALTERED: scan string for .IndexOf("ana"), return all entries. Post-process in some way?

//Requires research.

//issues/challenges: 
//1. .Split filter for non-isolated occurrences (cat/cathedral being invalid) requires checking final char of previous entry, and first char of next entry
//for a space; "a catcat" would split into [a ][cat][cat]. The first instance of cat should fail because it isn't followed by a space,
//and the 2nd instance of cat should fail because it wasn't preceded by a space. 
//options to resolve: 
//A. append/prepend space to scanning string ("cat") --> (" cat ") in .split argument. Problem: "this is a cat" fails because there is no space
//at the end of the sentence. 
//B. .split on "cat", check if entries before/after the split end/begin with spaces, respectively; "this is a cat" --> [this is a ][cat]
//Should be true, but includes extra issue with edge case/trying to access an entry out of range (the next entry doesn't exist, so checking it for
//a leading space crashes the program). B.2, wrap the checker in a try/catch [indexoutofrange] that counts the entry as valid if a follow-up entry doesn't exist.

//2. As with others, checking prefix/postfix characters as spaces. After writing issues #3, I can't think of any solution that doesn't have 
//special edge cases if there is a valid entry at the beginning/ending of a sentence, that I can check for, while also not breaking the middle-of-the-sentence
//requirement of being isolated (having spaces on both sides.) Will likely combine solutions #2 and #3 as implemented solution.

//3. Very similar to #1, except! Extra alternatives/processing:
//A.A Pre-filter for edge cases: if templatestring[0:scanningstring.length+1] == scanning string + " ", add 1 to count; "cat in a bag" checks 
//"cat " in the beginning and succeeds. Next check end: if templatestring[templatestring.length - scanningstring.length - 2:templatestring.length - 1] == " cat",
//add 1. "cat in a cat" checks ". . . ' cat'" at end of sentence, adds 1.
//THEN:
//B. prepend/append a space to filter only isolated cases; filter on " cat " occurrences in the middle of templatestring.