namespace OOPAdventure;

public static class Text
{
    private static Language? slanguage;
    public static Language Language
    {
        get
        {
            if (slanguage == null)
                throw new Exception("No language found");
            return slanguage;
        }
    }

    public static void LoadLanguage(Language language)
    {
        slanguage = language;
    }
}