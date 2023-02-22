using System.ComponentModel;

namespace TarotBlazor.Data.Tarot;

public class TarotEnumerations
{
    public enum Suits
    {
        [Description("Мечей")] Swords,
        [Description("Пентаклей")] Pentacles,
        [Description("Кубков")] Cups,
        [Description("Жезлов")] Wands
    }

    public enum SmallArcanes
    {
        [Description("Туз")] Ace,
        [Description("Двойка")] Two,
        [Description("Тройка")] Three,
        [Description("Четверка")] Four,
        [Description("Пятерка")] Five,
        [Description("Шестерка")] Six,
        [Description("Семерка")] Seven,
        [Description("Восьмерка")] Eight,
        [Description("Девятка")] Nine,
        [Description("Десятка")] Ten,
        [Description("Паж")] Page,
        [Description("Рыцарь")] Knight,
        [Description("Королева")] Queen,
        [Description("Король")] King
    }

    public enum BigArcanes
    {
        [Description("Шут")] Fool,
        [Description("Маг")] Magician,
        [Description("Верховная жрица")] Priestess,
        [Description("Императрица")] Empress,
        [Description("Император")] Emperor,
        [Description("Верховный жрец")] Hierophant,
        [Description("Влюбленные")] Lovers,
        [Description("Колесница")] Chariot,
        [Description("Сила")] Strength,
        [Description("Отшельник")] Hermit,
        [Description("Колесо фортуны")] WheelOfFortune,
        [Description("Правосудие")] Justice,
        [Description("Висельник")] HangedMan,
        [Description("Смерть")] Death,
        [Description("Воздержание")] Temperance,
        [Description("Дьявол")] Devil,
        [Description("Башня")] Tower,
        [Description("Звезда")] Star,
        [Description("Луна")] Moon,
        [Description("Солнце")] Sun,
        [Description("Суд")] Judgement,
        [Description("Мир")] World
    }

    

    public static readonly Array SuitsArray = System.Enum.GetValues(typeof(Suits));
    public static readonly Array SmallArcanesArray = System.Enum.GetValues(typeof(SmallArcanes));
    public static readonly Array BigArcanesArray = System.Enum.GetValues(typeof(BigArcanes));


    public static readonly Dictionary<BigArcanes, string> BigCardImagesPathDictionary = new()
    {
        { BigArcanes.Fool,           "BigFool.png" },
        { BigArcanes.Magician,       "BigMagician.png" },
        { BigArcanes.Priestess,      "BigPriestess.png" },
        { BigArcanes.Empress,        "BigEmpress.png" },
        { BigArcanes.Emperor,        "BigEmperor.png" },
        { BigArcanes.Hierophant,     "BigHierophant.png" },
        { BigArcanes.Lovers,         "BigLovers.png" },
        { BigArcanes.Chariot,        "BigChariot.png" },
        { BigArcanes.Strength,       "BigStrength.png" },
        { BigArcanes.Hermit,         "BigHermit.png" },
        { BigArcanes.WheelOfFortune, "BigWheelOfFortune.png" },
        { BigArcanes.Justice,        "BigJustice.png" },
        { BigArcanes.HangedMan,      "BigHangedMan.png" },
        { BigArcanes.Death,          "BigDeath.png" },
        { BigArcanes.Temperance,     "BigTemperance.png" },
        { BigArcanes.Devil,          "BigDevil.png" },
        { BigArcanes.Tower,          "BigTower.png" },
        { BigArcanes.Star,           "BigStar.png" },
        { BigArcanes.Moon,           "BigMoon.png" },
        { BigArcanes.Sun,            "BigSun.png" },
        { BigArcanes.Judgement,      "BigJudgement.png" },
        { BigArcanes.World,          "BigWorld.png" }
    };
    
} 