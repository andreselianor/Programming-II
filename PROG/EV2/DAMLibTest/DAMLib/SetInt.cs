namespace DAMLibTest
{
    public class SetInt
    {
        public int[] array;
        public int[] hash;

        public SetInt()
        {
            array = new int[0];
            hash = new int[0];
        }

        public void AddInt(int value)
        {
            int count = array.Length;

            int[] arrayResult = new int[count + 1];
            int[] arrayHash = new int[count + 1];

            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = array[i];
                arrayHash[i] = hash[i];
            }
            arrayResult[count] = value;
            arrayHash[count] = GetHashCode();

            array = arrayResult;
            hash = arrayHash;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].GetHashCode() == value.GetHashCode())
                    return i;
            }
            return -1;
        }

        public override int GetHashCode()
        {
            return 10 * array.GetHashCode();
        }
    }
}
