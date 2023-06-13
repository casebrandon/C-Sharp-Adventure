using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;
//Singleton class - A single instance that can be accessed throughout the program.
public static class Text
{
    private static Language _language;

    public static Language Language
    {
        get
        {
            if( _language == null)
            {
                throw new Exception("No language loaded.");
            }
            return _language;
        }
    }
    public static void LoadLanguage(Language language)
    {
        _language = language;
    }
}

