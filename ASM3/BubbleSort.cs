namespace ASM3
{
    public class BubbleSort
    {
        public BubbleSort()
        {

        }

        public static void run()
        {
            int tmp, n;
            System.Console.Write("Enter array length (number): ");
            n = int.Parse(System.Console.ReadLine());
            int[] arr = new int[n];

            System.Console.WriteLine("Enter " + n + " numbers with each line:");
            for (var i = 0; i < n; i++)
            {
                arr[i] = int.Parse(System.Console.ReadLine());
            }

            System.Console.WriteLine("\nBefore Sorted:");
            for (var i = 0; i < n; i++)
            {
                System.Console.Write(arr[i] + " ");
            }

            for (var j = 0; j < n - 1; j++)
            {
                for (var i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }

            System.Console.WriteLine("\nSorted Array:");

            foreach (var i in arr)
            {
                System.Console.Write(i + " ");
            }



        }
    }
}