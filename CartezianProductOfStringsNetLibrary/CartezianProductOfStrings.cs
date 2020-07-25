using System;
using System.Collections.Generic;

namespace CartezianProductOfStringsNet
{
    [Serializable]
    public class CartezianProductOfStrings : List<string>, ICartezianProductOfStrings
    {
        public string PreFix { get; set; }
        public string Separator { get; set; }
        public string ElementSeparator { get; set; }
        public string PostFix { get; set; }
        public string ListPreFix { get; set; }
        public string ListPostFix { get; set; }
        public CartezianProductOfStrings(IEnumerable<String> firstParts, IEnumerable<String> secondParts, string preFix = "\"", string separator = " ", string elementSeparator = ", ", string postFix = "\"", string listPreFix = "[", string listPostFix = "]")
        {
            this.PreFix = preFix;
            this.Separator = separator;
            this.PostFix = postFix;
            this.ElementSeparator = elementSeparator;
            this.ListPreFix = listPreFix;
            this.ListPostFix = listPostFix;

            foreach (string secondPart in secondParts)
            {
                foreach (string firstPart in firstParts)
                {
                    Add($"{preFix}{firstPart}{separator}{secondPart}{postFix}");
                }
            }
        }

        public override string ToString()
        {
            string allStrings = "";
            foreach (string str in this)
            {
                // Här kan man "snygga till koden" så man använder StringBuilder...
                if (allStrings.Length > 0)
                {
                    allStrings += this.ElementSeparator;
                }
                allStrings += $"{str}";
            }
            return $"{this.ListPreFix}{this.Separator}{allStrings}{this.Separator}{this.ListPostFix}";
        }
    }
}
