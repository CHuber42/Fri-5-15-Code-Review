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
    }
  }  
}
