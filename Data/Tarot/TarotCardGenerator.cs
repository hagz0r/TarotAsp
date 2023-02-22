using TarotBlazor.Data.Tarot;

namespace TarotBlazor.Data.Tarot;

public abstract class TarotCardGenerator
{
    private const double AllCards = 78d;
    private const double SmallCards = 55d;
    private const double BigCards = 22d;

    public enum MultipleGenOptions
    {
        RandomCards,
        BigCards,
        SmallCards
    }

    public enum SingleGenOptions
    {
        Big,
        Small
    }

    public static IEnumerable<TarotCard> GenerateCards(uint cardsCount, MultipleGenOptions options)
    {
        HashSet<TarotCard> tarotCards = new();

        switch (options)
        {
            case MultipleGenOptions.RandomCards:
                while (tarotCards.Count != cardsCount)
                    tarotCards.Add(Random.Shared.NextDouble() <= BigCards / AllCards
                        ? GenerateCard(SingleGenOptions.Big)
                        : GenerateCard(SingleGenOptions.Small));
                break;
            case MultipleGenOptions.BigCards:
                while (tarotCards.Count != cardsCount)
                    tarotCards.Add(GenerateCard(SingleGenOptions.Big));
                break;
            case MultipleGenOptions.SmallCards:
                while (tarotCards.Count != cardsCount)
                    tarotCards.Add(GenerateCard(SingleGenOptions.Small));
                break;
        }

        return tarotCards;
    }


    private static TarotCard GenerateCard(SingleGenOptions options) => options switch
    {
        SingleGenOptions.Big => new TarotBigArcane(RandomBigArcane(), RandomBool()),
        SingleGenOptions.Small => new TarotSmallArcane(RandomSmallArcane(), RandomSuit(), RandomBool())
    };

    #region Random Variables

    private static TarotEnumerations.BigArcanes RandomBigArcane()
    {
        return (TarotEnumerations.BigArcanes)TarotEnumerations.BigArcanesArray.GetValue(
            Random.Shared.Next(TarotEnumerations.BigArcanesArray.Length))!;
    }

    private static TarotEnumerations.SmallArcanes RandomSmallArcane()
    {
        return (TarotEnumerations.SmallArcanes)TarotEnumerations.SmallArcanesArray.GetValue(
            Random.Shared.Next(TarotEnumerations.SmallArcanesArray.Length))!;
    }

    private static TarotEnumerations.Suits RandomSuit()
    {
        return (TarotEnumerations.Suits)TarotEnumerations.SuitsArray.GetValue(
            Random.Shared.Next(TarotEnumerations.SuitsArray.Length))!;
    }

    private static bool RandomBool() => Random.Shared.Next() > int.MaxValue / 2;

    #endregion
}