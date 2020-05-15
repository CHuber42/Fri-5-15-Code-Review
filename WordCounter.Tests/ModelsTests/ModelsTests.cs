using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Models
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounterConstructor__AssignObjectPropertiesDuringConstruction_EmptyStrings()
    {
      RepeatCounter counter = new RepeatCounter("Banana", "anana");
      Assert.AreEqual("Banana", counter.TemplateString);
      Assert.AreEqual("anana", counter.ScanningString);
    }

    // OLD TEST; NEEDS UPDATE FOR ALTERED FUNCTIONALITy
    // [TestMethod]
    // public void CountOccurrences__ReturnsAnInteger_Six()
    // {
    //   RepeatCounter counter = new RepeatCounter("Banana", "anana");
    //   int returnValue = counter.CountOccurrences();
    //   Assert.AreEqual(6, returnValue);
    // }

    [TestMethod]
    public void CountOccurrences__ReturnsAnInteger_Two()
    {
      RepeatCounter counter = new RepeatCounter("Banana", "anana");
      int returnValue = counter.CountOccurrences();
      Assert.AreEqual(2, returnValue);
    }
  }  
}
