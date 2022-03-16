namespace day01
{
    class Iterator
    {
        //01
        public static void ShowFor()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " : genap");
                }
                else
                {
                    Console.WriteLine(i + " : ganjil");
                }
            }
        }

        //1
        public static void ShowBox()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write((i + j) + " ");
                }
                Console.WriteLine();
            }
        }

        //2
        public static void ShowLeftTriangle()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write((i + j) + "\t");
                }
                Console.WriteLine();
            }
        }

        //3
        public static void ShowRightTriangle()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    Console.Write("\t");
                }

                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write((i + j) + "\t");
                }
                Console.WriteLine();
            }
        }

        //4
        public static void ShowContinueStmt()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void ShowWhileDo()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine("iteration : " + i);
                i++;
                if (i == 10)
                    break;
            }
        }

        public static void ShowDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);
        }



    }



}