using System;
using System.Collections.Generic;
using CartezianProductOfStringsNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CartezianProductOfStringsNet_UnitTestProject
{
    [TestClass]
    public class CartezianProductOfStringsNet_UnitTest
    {
        [TestMethod]
        public void TestActualOutputFromToStringMethod()
        {
            List<String> firstNames = new List<String>() { "Anders", "Petter", "Sven" };
            Assert.IsInstanceOfType(value: firstNames, expectedType:(typeof(List<String>)));
            Assert.AreEqual(expected: 3, actual: firstNames.Count);
            Assert.AreEqual(expected: "Anders", actual: firstNames[0]);
            Assert.AreEqual(expected: "Petter", actual: firstNames[1]);
            Assert.AreEqual(expected: "Sven", actual: firstNames[2]);

            List<String> familyNames = new List<String>() { "Andersson", "Pettersson", "Svensson" };
            Assert.IsInstanceOfType(value: familyNames, expectedType: (typeof(List<String>)));
            Assert.AreEqual(expected: 3, actual: familyNames.Count);
            Assert.AreEqual(expected: "Andersson", actual: familyNames[0]);
            Assert.AreEqual(expected: "Pettersson", actual: familyNames[1]);
            Assert.AreEqual(expected: "Svensson", actual: familyNames[2]);

            CartezianProductOfStrings formattedListOfNamesWithBrackets = new CartezianProductOfStrings(firstParts: firstNames, secondParts: familyNames);
            Assert.IsInstanceOfType(value: $"{formattedListOfNamesWithBrackets}", expectedType: (typeof(System.String)));
            const string QUOTE = "\"";
            Assert.AreEqual(expected: $"[ {QUOTE}Anders Andersson{QUOTE}, {QUOTE}Petter Andersson{QUOTE}, {QUOTE}Sven Andersson{QUOTE}, {QUOTE}Anders Pettersson{QUOTE}, {QUOTE}Petter Pettersson{QUOTE}, {QUOTE}Sven Pettersson{QUOTE}, {QUOTE}Anders Svensson{QUOTE}, {QUOTE}Petter Svensson{QUOTE}, {QUOTE}Sven Svensson{QUOTE} ]", actual: $"{formattedListOfNamesWithBrackets}" );

            // Output: 
            // [ "Anders Andersson", "Petter Andersson", "Sven Andersson", "Anders Pettersson", "Petter Pettersson", "Sven Pettersson", "Anders Svensson", "Petter Svensson", "Sven Svensson" ]
        }
    }
}
