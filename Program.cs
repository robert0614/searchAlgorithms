namespace searchAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 5, 4, 4, 3, 3, 2, 2, 1, 1 };
            int arrayResult = LinearSearch(arr1, 3);
            int maxVal = arr1.Max();
            int minVal = arr1.Min();
            Console.WriteLine(arrayResult);
            Console.WriteLine(maxVal);
            Console.WriteLine(minVal);
        }

        public static int LinearSearch(int[] arrayToSearch, int target)
        {

            // int i = 0 - initializing our loop condition - in thi case 0
            // next we evealuate if the value meets the condition
            // after each loop we run the update logic
            // Big O - O(n) - is the worst case scenario (run time may differ depending on the the location (index) of they being looked for)
            //Big Omega - O(1) - is the best case scenario (run time of 1 because it is the first item being looked for)

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] == target) return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] arrayToSearch, int target )
        {
            int lower = 0;
            int upper = arrayToSearch.Length - 1;

            while (upper > lower)
            {
                int mid = (lower + upper) / 2;
                if (arrayToSearch[mid] == target) return mid;
                else if (target < arrayToSearch[mid])
                {
                    upper = mid - 1;
                }
                else
                {
                    lower = mid + 1;

                }
            }

            return -1;
        }

    }
}
