using System;
using System.Collections.Generic;

namespace Exercism
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            Dictionary<int, string> DictionaryResult = new Dictionary<int, string>();

            return DictionaryResult;
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int, string> DictionaryResult = new Dictionary<int, string>
            {
                [1] = "United States of America",
                [55] = "Brazil",
                [91] = "India"
            };

            return DictionaryResult;
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int, string> DictionaryResult = new Dictionary<int, string>();

            DictionaryResult.Add(countryCode, countryName);

            return DictionaryResult;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            string result = "";
            bool IsKey = existingDictionary.ContainsKey(countryCode);

            if (IsKey)
            {
                result = existingDictionary[countryCode];
            }

            //result = IsKey ? existingDictionary[countryCode]: "";     

            return result;
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return (existingDictionary.ContainsKey(countryCode));
            /*
            for(int i = 0; i < existingDictionary.Length; i++)
            {
                if()
            }
            */
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary.Remove(countryCode);
            }
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string name = "";

            foreach (string s in existingDictionary.Values)
            {
                if (s.Length > name.Length)
                {
                    name = s;
                }
            }

            /*
            for(int i = 1; i < existingDictionary.Keys.Count; i++)
            {      
                if(existingDictionary.ContainsKey(countryCode))
                {
                    if(existingDictionary[i].Length > name.Length)
                  {
                      name = existingDictionary[i];
                  }  
                }            
            }
             */
            return name;
        }
    }
}
