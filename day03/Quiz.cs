namespace day03
{
    class Quiz
    {
        //soal 1
        public static void MatrixDiagonal1()
        {
            int[,] matrix = new int[5, 5];
            int counter = 1;
            int sum = 0;

            // init diagonal matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }

            DisplayMatrix(matrix);

        }

        //soal 2;
        public static void MatrixDiagonal2()
        {
            int[,] matrix = new int[5, 5];
            int counter = 1;
            int sum = 0;

            // init diagonal matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }

            DisplayMatrix(matrix);

        }

        //soal 3;
        public static void MatrixDiagonal3()
        {
            int[,] matrix = new int[5, 5];
            int counter = 5;
            int sum = 0;

            // init diagonal matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }

            DisplayMatrix(matrix);

        }

        //soal4
        public static void MatrixBox()
        {
            int[,] matrix = new int[7, 7];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = i + j;
                    }
                    else if (j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = i + j;
                    }
                    else if (j == 0)
                    {
                        matrix[i, j] = i + j;
                    }
                    else if (i == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = i + j;
                    }
                }
            }

            DisplayMatrix(matrix);


        }


        //no 7
        public static void MatrixBox2()
        {
            int n = 7;
            int m = 3;
            int o = 2;
            int counter = o;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == 0)
                    {

                        if (j == 0)
                        {
                            matrix[i, j] = o;
                        }
                        else
                        {
                            if (j == m)
                            {
                                matrix[i, j] = m;
                                counter -= m;
                            }
                            else
                            {
                                matrix[i, j] = counter;
                            }
                        }
                        counter += 3;

                    }
                    else if (j == matrix.GetLength(1) - 1)
                    {
                        if (i == 1)
                        {
                            matrix[i, j] = m;
                        }
                        else
                        {
                            if (i == matrix.GetLength(1) - 2)
                            {
                                matrix[i, j] = m;
                                counter -= m;
                            }
                            else
                            {
                                matrix[i, j] = counter;
                            }
                            counter += m;
                        }
                    }

                }
            }

            for (int i = matrix.GetLength(0) - 1, j = matrix.GetLength(0) - 2; j >= 0; j--)
            {
                if (j == m)
                {
                    matrix[i, j] = m;
                    counter -= m;
                }
                else
                {
                    matrix[i, j] = counter;
                }
                counter += m;
            }

            for (int j = 0, i = matrix.GetLength(1) - 2; i > 0; i--)
            {
                if (i == matrix.GetLength(1) - 2 || i == 1)
                {
                    matrix[i, j] = 3;
                }
                else
                {
                    matrix[i, j] = counter;
                    counter += 3;
                }
            }

            DisplayMatrix(matrix);
        }


        //SOAL 5
        public static void MatrixTotalSum()
        {
            int n = 8;
            int sum = 0;

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {

                for (int j = 0; j <= matrix.GetLength(1) - 2; j++)
                {

                    if (j == 0)
                    {
                        matrix[i, j] = i;

                    }
                    else
                    {
                        matrix[i, j] = i + j;

                    }
                    sum += matrix[i, j];
                }
                matrix[i, matrix.GetLength(1) - 1] = sum;
                matrix[matrix.GetLength(1) - 1, i] = sum;
                sum = 0;

                DisplayMatrix(matrix);

            }
        }


        public static void StudentExam()
        {
            // deklarasikan variable jawaban berupa matrix untuk hold data jawaban siswa
            char[,] jawaban = { { 'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                                { 'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D' },
                                { 'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D' },
                                { 'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D' },
                                { 'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                                { 'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                                { 'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' },
                                { 'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' }
                               };
            // kunci jawaban    
            char[] kunci = { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };

            // point untuk nilai
            for (int i = 0; i < jawaban.GetLength(0); i++)
            {
                // hold correct answer
                int correctCount = 0;
                for (int j = 0; j < jawaban.GetLength(1); j++)
                {
                    if (jawaban[i, j] == kunci[j])
                        correctCount++;
                }
                Console.WriteLine($"Jawaban siswa " + (i + 1) + " yang benar : " + correctCount);
            }
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}