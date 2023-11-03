namespace Dolphin01
{
    public class CharactersUtils
    {
        public static bool ContainsName(List<Character> list, string name)
        {
            for (int i = 0; i < list.Count; i++)
                return (list[i].name == name);
            return false;
        }

        public static bool ContainsName2(List<Character> list, string name)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].name == name)
                    return true;
            return false;            
        }

        public static Character ContainsCharacter(List<Character> list, string name)
        {
            for (int i = 0; i < list.Count; i++)
                if (ContainsName(list, name))
                    return list[i];
            return null;
        }

        public static bool ContainsDuplicate(List<Character> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                for (int j = i + 1; j < list.Count; j++)
                    if (list[i] == list[j])
                        return true;
            return false;
        }

        public static bool ContainsDuplicate2(List<Character> list)
        {
            for (int i = 0; i < list.Count - 1; i++)                
                    if (list[i] == list[j])
                        return true;
            return false;
        }
    }
}
