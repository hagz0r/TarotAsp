using System.ComponentModel;

namespace TarotBlazor.Data.Enum;

public struct EnumExtensions
{
    //public static string GetEnumDescription(System.Enum enumValue)  
    //{  
    //    var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
    //    var descriptionAttributes = (DescriptionAttribute[])fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)!;
    //    return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();  
    //}
    public static string? GetEnumDescription<T>(T enumValue) where T : struct, IConvertible
    {
        if (!typeof(T).IsEnum) return null;

        var description = enumValue.ToString();
        var fieldInfo = enumValue.GetType().GetField(enumValue.ToString() ?? string.Empty);

        if (fieldInfo == null) return description;
        var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
        
        if (attrs.Length > 0)
            description = ((DescriptionAttribute)attrs[0]).Description;

        return description;
    }
}
