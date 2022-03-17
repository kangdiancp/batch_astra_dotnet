namespace day02
{
    class Quiz
    {
        //1 randomize
        public static void InitArrayRandom(int[] list)
        {
            Console.WriteLine("Before Random");
            PrintArray(list);

            Random random = new Random();
            for (int i = 0; i < list.Length; i++)
            {
                //generate an index j randomly
                int j = random.Next(0, list.Length);
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            // after random
            Console.WriteLine();
            Console.WriteLine("After Random Position element change");
            PrintArray(list);
        }

        // gunakan untuk display
        public static void PrintArray(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }

        //2 shifting element
        public static void ShiftingElement(int[] list)
        {
            Console.WriteLine("Before Shifting");
            PrintArray(list);


            int temp = list[0];
            // shift element left
            for (int i = 1; i < list.Length; i++)
            {
                list[i - 1] = list[i];
            }
            list[list.Length - 1] = temp;

            Console.WriteLine();
            Console.WriteLine("After Shifting");
            PrintArray(list);
        }

        //3 rotate shifting element
        public static void RotateShiftingElement(int[] list, int rotate)
        {
            Console.WriteLine($"Rotate Shifting {rotate}x");
            PrintArray(list);

            for (int i = 0; i < rotate; i++)
            {
                int temp = list[0];
                // shift element left
                for (int j = 1; j < list.Length; j++)
                {
                    list[j - 1] = list[j];
                }
                list[list.Length - 1] = temp;

                Console.WriteLine();
                Console.WriteLine($"Rotate ke {i + 1} : ");
                PrintArray(list);
            }
        }

        //4 right rotate, ubah index reverse

       

        public static void removeDuplicate(int[] list)
        {
            
            int writeIndex = 1;
            for (int i = 0; i < list.Length; i++)
            {
                int currentValue = list[i];
                int prevValue = list[writeIndex - 1];

                if (prevValue != currentValue)
                {
                    list[writeIndex] = currentValue;
                    writeIndex++;
                }
            }

            //marker position 
            for (int i = writeIndex; i < list.Length; i++)
            {
                list[i] = -1;
            }

            PrintArray(list);
        }

        //soal occurence
        public static void CountOcurence(int[] list)
        {
            for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] == i)
                        count += 1;
                }
                if (count != 0)
                    Console.WriteLine($"{i} muncul {count} kali");
            }

        }

        // eliminate duplicate
        public static int[] eliminateDuplicates(int[] list)
        {
            int[] list2 = new int[list.Length];
            int x = 0;

            for (int i = 0; i < list.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < list.Length; j++)
                {
                    if (list2[j] == list[i])
                    {
                        isDuplicate = true;
                    }
                }
                if (!isDuplicate)
                {

                    list2[x++] = list[i];
                }
            }

            int[] resultArray = new int[x];
            for (int i = 0; i < x; i++)
            {
                resultArray[i] = list2[i];
            }

            return resultArray;
        }

   
        //8. Count Letter in Arrays
        public static void countLetter()
        {
            char[] chars = createArray();
            displayArray(chars);
            int[] counts = new int[26];

            for (int i = 0; i < chars.Length; i++)
            {
                counts[chars[i] - 'a']++;
            }

            Console.WriteLine("-------- Result ----------");
            displayCounts(counts);
        }

        // use for soal no 8
        static char[] createArray()
        {
            char[] chars = new char[100];
            Random random = new Random();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)random.Next('a', 'z');
            }

            return chars;
        }

        // use for soal no8
        static void displayArray(char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if ((i + 1) % 20 == 0)
                {
                    Console.WriteLine(chars[i]);
                }
                else
                {
                    Console.Write(chars[i] + " ");
                }
            }
        }

        // use for no 8
        static void displayCounts(int[] counts)
        {
            for (int i = 0; i < counts.Length; i++)
            {
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine(counts[i] + " " + (char)(i + 'a'));
                }
                else
                {
                    Console.Write(counts[i] + " " + (char)(i + 'a') + " ");
                }
            }
        }


    }
}