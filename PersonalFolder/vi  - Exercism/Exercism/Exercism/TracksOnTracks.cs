using System;
using System.Collections.Generic;

namespace Exercism
{
    public static class Languages
    {
        public static List<string> NewList()
        {
            return new List<string>();
        }

        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            for (int i = 0; i < languages.Count; i++)
            {
                if (languages[i] == language)
                    return true;
            }
            return false;
        }

        public static List<string> ReverseList(List<string> languages)
        {
            List<string> listResult = new List<string>();
            for (int i = languages.Count - 1; i >= 0; i--)
            {
                listResult.Add(languages[i]);
            }
            return listResult;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages == null || languages.Count == 0)
                return false;
            if (languages[0] == "C#")
                return true;
            if (languages[1] == "C#" && languages.Count > 1 && languages.Count < 4)
                return true;
            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            for (int i = 0; i < languages.Count; i++)
            {
                if (languages[i] == language)
                {
                    languages.RemoveAt(i);
                    i--;
                }
            }
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            for (int i = 0; i < languages.Count - 1; i++)
            {
                for (int j = i + 1; j < languages.Count; j++)
                {
                    if (languages[i] == languages[j])
                        return false;
                }
            }
            return true;
        }
    }
}
