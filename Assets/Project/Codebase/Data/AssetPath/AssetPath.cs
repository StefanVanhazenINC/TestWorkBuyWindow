using System.Collections.Generic;

public static class AssetPath 
{
    public const string Onion  = "Data_Resources/Onion";
    public const string Potato = "Data_Resources/Potato";
    public const string Radish = "Data_Resources/Radish";
    public const string Turnip = "Data_Resources/Turnip";

    public static List<string> ListResource = new List<string>()
    {
        Onion, Potato, Radish,Turnip
    };

    public const string TenderView = "Windows/TenderView";
}
