    using TarotBlazor.Data.Enum;

namespace TarotBlazor.Data.Tarot;

public class TarotSmallArcane : TarotCard
{
    public readonly TarotEnumerations.SmallArcanes ArcaneType;
    public readonly TarotEnumerations.Suits SuitType;
    public TarotSmallArcane(TarotEnumerations.SmallArcanes title, TarotEnumerations.Suits suit, bool isReversed)
    {
        Title = EnumExtensions.GetEnumDescription(title);
        _suit = EnumExtensions.GetEnumDescription(suit);
        IsReversed = isReversed;
        ArcaneType = title;
        SuitType = suit;
    }

    
    
    private readonly string? _suit;

    public override string ToString() => $"{Title} {_suit} {TranslateBool(IsReversed)}";
    public override int GetHashCode() => HashCode.Combine(_suit.GetHashCode(),  Title.GetHashCode());
    public override bool Equals(object? obj)
        => obj is TarotSmallArcane arcane && arcane.Title == Title && arcane._suit == _suit;
}