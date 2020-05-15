### Project: **Week 9 Code Review - Substring-in-String Counter**
#### Author: **Christopher Huber**

### Github page: https://github.com/CHuber42/Fri-5-15-Code-Review
#### Github repo: You're standing on it.
##### Copyright Christopher Huber, 2020

&nbsp;
     
&nbsp;
         
##### Build instructions/Installation: 

This project is built in C# 8.0 using .netcoreapp3.1 on a system running Ubuntu 18.04.
Dependencies are declared in the wordcounter.csproj and wordcounter.Tests.csproj files in their respective folders;
to install, simply clone (or download) this folder into a new directory, git bash to ./wordcounter.Tests/ folder,
and run dotnet restore.

To run: either build the project using dotnet build and run the .exe, or navigate to the
./wordcounter/ folder in a terminal and enter "dotnet run"


##### Development specs:

** Spec 1: Take in an input string from a user as a template string to scan for words** <done> Input/Output: "Banana" | 
** Spec 2: Take in a second input string as 'what to look for in the first string'** <done> Input/Output: "anana" |
** Spec 3: Create a new object out of a class** <done> Input/Output: N/A
** Spec 4: Use class's constructor to assign taken-in strings to attributes** <done> Input/Output: "Banana" | RepeatCounter.TemplateString = "Banana" 
** Spec 5: Create a method in RepeatCounter to count # of letters in templatestring (test behavior)** <done> Input: "Banana" | Output: 6
** Spec 6: Update Counter Method to count all occurrences of substring in string** Input/Output: "Banana", "anana" | 1 <done>
** Spec 7: Add Filter to #6 to not count any occurrences not bracketed by spaces** Input/Output <done>
** Core Functionality ends here; more Specs may be added post-attainment of functionality goals ** Input/Output: "I am a Banana", "I" | 1 <done>
** Spec 8: PRINT VALUE ON SCREEN** Input/Output: "cat in a cat bag", "cat" || 2 <in progress>
** Spec 1: **



##### _Contact_:

CHuber42.Gmail.com

##### _Copyright Christopher Huber 2020, all rights reserved._