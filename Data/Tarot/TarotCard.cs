namespace TarotBlazor.Data.Tarot;


public abstract class TarotCard
{
    protected string? Title;
    protected bool IsReversed;
    
    private const string BigCardsPath = "Media/BigCardsImg";
    private const string SmallCardsPath = "Media/SmallCardsImg";

    public static string GetCardImagePath(TarotCard arc) => arc switch
    {
        TarotBigArcane tarotBigArcane => $"{BigCardsPath}/{TarotEnumerations.BigCardImagesPathDictionary[tarotBigArcane.ArcaneType]}", 
        TarotSmallArcane tarotSmallArcane =>  $"{SmallCardsPath}/{tarotSmallArcane.SuitType}/{tarotSmallArcane.ArcaneType}.png",
        _ => throw new ArgumentOutOfRangeException(nameof(arc), arc, null)
    };
    protected static string TranslateBool(bool b) => b ? "Перевернутая" : string.Empty;
    
}