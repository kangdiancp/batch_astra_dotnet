namespace day02
{
    class Arrays
    {
        public static void InitArray()
        {
            // initial element;
            int[] arr;
            int[] array = new int[10];
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = { 2, 3, 5, 7, 11, 13 };

            string[] listNames = { "astri", "bella", "chinthya" };

            DisplayArrayString(listNames);
            DisplayArrayNumber(arr2);

            /*for (int i = 0; i < listNames.Length; i++)
            {
                Console.WriteLine(listNames[i]);
            }*/

        }
        // function
        public static int[] CreateRandomArray()
        {
            Random random = new Random();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,100);
            }

            return arr;
        }

        //2. processing array
        public static void SumElement(int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            Console.WriteLine($"Total Element : {sum}");
        }

        //3 findMaxNumber
        public static int FindMaxNumber(int[] list)
        {
            int max = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        //3 findMaxNumber
        public static int FindIndexMaxNumber(int[] list)
        {
            int max = list[0];
            int indexMax = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }

        public static void CopyArray(int[] list)
        {
            int[] destArr = new int[list.Length];
            /*for (int i = 0; i < list.Length; i++)
            {
                destArr[i] = list[i];
            }*/

            // copy array by reference
            int[] target = list;

            // method copy
            Array.Copy(list, 0, destArr, 0, destArr.Length);

            //sorting
            Array.Sort(destArr);
            Array.Reverse(destArr);
            
            DisplayArrayNumber(destArr);
            
        }

        static void DisplayArrayString(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void DisplayArrayNumber(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i]+" ");
            }
        }
    }
}