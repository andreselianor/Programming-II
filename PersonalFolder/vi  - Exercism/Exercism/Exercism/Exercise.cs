namespace Exercism
{
    public class Exercism
    {

    }


    /*
     *  Easy Exercise.
     * 'TRIANGLE'.
     * conditionals.
     */
    public static class Triangle
    {
        public static bool IsScalene(double side1, double side2, double side3)
        {
            double a = side1, b = side2, c = side3;
            if (a + b < c || a + c < b || b + c < a)
                return false;
            if (a == b || a == c || b == c)
                return false;
            return true;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 != side3 && side3 < side1)
                return true;
            if (side2 == side3 && side2 != side1 && side1 < side2)
                return true;
            if (side1 == side3 && side1 != side2 && side2 < side1)
                return true;
            if (IsEquilateral(side1, side2, side3))
                return true;
            return false;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            return (side1 == side2 && side2 == side3 && side1 != 0);
        }

        public static double CalculateTriangleArea(double baseTriangle, double height)
        {
            return (baseTriangle * height) * 0.5;
        }
        public static (double, double) GetCircleMeasures(double radius)
        {
            double length = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;
            return (length, area);
        }
    }


    /*
     *  Learning Exercise.
     * 'BIRD WATCHER'.
     * arrays.
     */

    class BirdCount
    {
        private int[] _birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            _birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public int Today()
        {
            int TodayBirds = _birdsPerDay.Length - 1;
            return _birdsPerDay[TodayBirds];
        }

        public void IncrementTodaysCount()
        {
            int increment = Today() + 1;
            _birdsPerDay = new int[] { 0, 2, 5, 3, 7, 8, increment };
        }

        public bool HasDayWithoutBirds()
        {
            for (int i = 0; i < _birdsPerDay.Length; i++)
            {
                if (_birdsPerDay[i] == 0)
                    return true;
            }
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int result = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                result += _birdsPerDay[i];
            }
            return result;
        }

        public int BusyDays()
        {
            int result = 0;
            for (int i = 0; i < _birdsPerDay.Length; i++)
            {
                if (_birdsPerDay[i] >= 5)
                    result++;
            }
            return result;
        }
    }


    /*
     * Learning Exercise
     * 'INTERNATIONAL CALLING'.
     * dictionarys.
     */

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


    /*
     *  Easy Exercise.
     * 'RESISTOR COLOR'.
     * arrays.
     */

    public static class ResistorColor
    {
        public static int ColorCode(string color)
        {
            string[] colorMatrix = CreateMatrix();
            for (int i = 0; i < colorMatrix.Length; i++)
            {
                if (color == colorMatrix[i])
                    return i;
            }
            return -1;
        }

        public static string[] Colors()
        {
            return CreateMatrix();
        }

        public static string[] CreateMatrix()
        {
            string[] colorMatrix;
            colorMatrix = new string[]
            {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
            };
            return colorMatrix;
        }
    }
}

