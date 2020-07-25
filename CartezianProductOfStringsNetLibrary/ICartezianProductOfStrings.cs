namespace CartezianProductOfStringsNet
{
    public interface ICartezianProductOfStrings
    {
        string ElementSeparator { get; set; }
        string ListPostFix { get; set; }
        string ListPreFix { get; set; }
        string PostFix { get; set; }
        string PreFix { get; set; }
        string Separator { get; set; }

        string ToString();
    }
}
