namespace day01
{
    class Iterator
    {
        public static void ShowForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {

                }
            }
        }

        public static void ShowBox()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine();
            }
        }

    }

}