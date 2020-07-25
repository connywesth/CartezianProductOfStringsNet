using System;
using System.Collections.Generic;

namespace CartezianProductOfStringsNet
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cartezian Product Of Names! (C# .NET Framework 4.8)");

            List<String> firstNames = new List<String>() { "Anders", "Petter", "Sven" };
            List<String> familyNames = new List<String>() { "Andersson", "Pettersson", "Svensson" };

            CartezianProductOfStrings formattedListOfNamesWithBrackets = new CartezianProductOfStrings(firstParts:firstNames, secondParts:familyNames);
            Console.WriteLine($"{formattedListOfNamesWithBrackets}");
            // Output: 
            // Cartezian Product Of Names! (C# .NET Framework 4.8)
            // [ "Anders Andersson", "Petter Andersson", "Sven Andersson", "Anders Pettersson", "Petter Pettersson", "Sven Pettersson", "Anders Svensson", "Petter Svensson", "Sven Svensson" ]
        }
    }
}
