using TarotBlazor.Data.Enum;

namespace TarotBlazor.Data.Tarot;

public class TarotBigArcane : TarotCard
{
    public TarotEnumerations.BigArcanes ArcaneType;
    public TarotBigArcane(TarotEnumerations.BigArcanes title, bool isReversed)
    {
        Title = EnumExtensions.GetEnumDescription(title);
        IsReversed = isReversed;
        ArcaneType = title;
    }

    public override int GetHashCode() => Title!.GetHashCode(); 
    public override string ToString() => $"{Title} {TranslateBool(IsReversed)}";
    public override bool Equals(object? obj) => obj is TarotBigArcane arcane && arcane.Title == Title;
}