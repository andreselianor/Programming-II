namespace ResumenFunciones
{
    public class Exam
    {
        #region Random
        private static Random random = new Random();

        public static int GetRandom(int min, int max)
        {
            return random.Next(min, max);
        }

        public static double GetRandomDouble()
        {
            return random.NextDouble();
        }

        public static double GetRandomDouble(double min, double max)
        {
            return min + random.NextDouble() * (max - min);
        }
        #endregion

        #region List
        public static List<int> MakeList()
        {
            List<int> listResult = new List<int>
            {
                10,
                20,
                30
            };
            return listResult;

        }
        public static int GetListCount(List<int> list)
        {
            //if (list == null)
            //    return 0;
            return list.Count;
        }

        public static int GetElementAt(List<int> list, int index)
        {
            return list[index];
        }

        public static List<int> InsertElementAt(List<int> list, int element, int index)
        {
            List<int> listResult = new List<int>();

            for(int i = 0; i < index; i++)
            {
                listResult.Add(list[i]);
            }

            listResult.Add(element);

            for(int i = index; i < list.Count; i++)
            {
                listResult.Add(list[i]);
            }

            return listResult;
        }

        public static List<int> RemoveAt(List<int> list, int index)
        {
            list.RemoveAt(index);
            return list;
        }

        public static List<int> InsertElement(List<int> list, int element)
        {
            list.Insert(3, 100);
            return list;
        }

        public static List<int> MakeListRandom(int number)
        {
            List<int> listResult = new List<int>();

            for(int i = 0; i < number; i++)
            {
                int value = GetRandom(100, 200);
                listResult.Add(value);
            }
            return listResult;
        }

        public static List<int> SortList(List<int> list)
        {
            int aux;
            int listCount = 3;
            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
                
            }

            return list;
        }

        #endregion

        #region Array

        public static int[] MakeArray(int number)
        {
            int[] array = new int[number];

            for(int i = 0; i < number; i++)
            {
                array[i] = GetRandom(5, 20);
            }
            return array;
        }
        public static void ListArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }

        #endregion
    }
}
