namespace day01
{
    class Quiz
    {
        //1
        public static void GuessNumber()
        {
            Console.WriteLine("Guess magic number between 0-20");
            Random random = new Random();
            int number = random.Next(0, 20);


            int guess;
            bool answer = true;
            do
            {
                do
                {
                printguess:
                    Console.Write("Enter you guess ? ");
                    string line = Console.ReadLine().Trim();
                    guess = Convert.ToInt32(line);

                    // cek kondisi
                    if (guess == number)
                    {
                        Console.WriteLine("Tebakan kamu benar, angka yg ditebak " + guess);
                        Console.WriteLine("Tebak lagi ?");
                        string input = Console.ReadLine();
                        if (string.Equals(input, "y"))
                        {
                            number = random.Next(0, 20);
                            goto printguess;
                        }
                        else
                        {
                            answer = false;
                            Console.WriteLine("Your quit");
                        }
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("your guess is too hight");
                    }
                    else
                    {
                        Console.WriteLine("your guess is too low");
                    }
                } while (number != guess);
            } while (answer);

        }

        //2
        public static void MaxNumber()
        {
            int max = int.MinValue;
            int result;
            do
            {
                Console.Write("Enter integer [ Type 0 for exit ] : ");
                var line = Console.ReadLine().Trim();
                int.TryParse(line, out result);
                if (result > max)
                {
                    max = result;
                }
            } while (result != 0);

            Console.WriteLine($"angka terbesar : {max}");
        }

        //3
        public static void CountDigits()
        {
            Console.Write("Enter numbers : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int numbers);

            int count = 0;
            int remaining = numbers;
            while (remaining > 0)
            {
                remaining = remaining / 10;
                count++;
            }
            Console.WriteLine($"Total digit : {count}");
        }

        //4 
        public static void ExtractDigit()
        {
            Console.Write("Enter numbers : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int value);

            int remainingValue = value;
            while (remainingValue > 0)
            {
                int digit = remainingValue % 10;
                Console.WriteLine(digit);

                remainingValue = remainingValue / 10;
            }
        }

        //5
        public static void FindDivisor()
        {
            Console.Write("Enter numbers : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int value);

            for (int i = 1; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //6
        public static void ShowPrimeNumberRange()
        {
            Console.Write("Enter limit number : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int value);

            for (int i = 2; i < value; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //6 prime
        static Boolean isPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //7 
        public static void ShowPalindrome()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            bool isPalindrome = true;
            var kata = input.ToUpper().ToCharArray();

            for (int i = 0; i < kata.Length / 2; i++)
            {
                if (kata[i] != kata[kata.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }

        }

        //8 
        public static void CountVowel()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int vowel = 0, consonant = 0;


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input.ToUpper().ElementAt(i);
                if (ch == 'A' || ch == 'I' || ch == 'U' || ch == 'E' || ch == 'O')
                {
                    vowel++;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    consonant++;
                }
            }
            Console.WriteLine($"total vowel : {vowel}");
            Console.WriteLine($"total consonant : {consonant}");

        }

        //9 
        public static void CountWord()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int word = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input.ElementAt(i)) || i == input.Length - 1)
                {
                    word++;
                }
            }

            Console.WriteLine($"Total Words : {word}");
        }

        //10
        public static void ConvertMiddleToStar()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();

            int start = 0, end;
            string cutWord = "", word = "", joinCutWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsWhiteSpace(input.ElementAt(i)) || i == input.Length - 1)
                {
                    if (i == input.Length - 1)
                    {
                        end = i + 1;
                    }

                    else
                    {
                        end = i;
                    }


                    cutWord = input.Substring(start, end - start);
                    start = end + 1;

                    word = "";
                    char ch;
                    for (int j = 0; j < cutWord.Length; j++)
                    {
                        ch = cutWord.ElementAt(j);
                        if (j == 0 || j == cutWord.Length - 1)
                        {
                            word = word + ch;
                        }
                        else if (j > 0 && j < cutWord.Length - 1)
                        {
                            word = word + "*";
                        }
                    }
                    joinCutWord = joinCutWord + " " + word;

                }
            }
            Console.WriteLine(joinCutWord);
        }

        //11. I Hate Monday
        public static void ILoveWeekend()
        {
            // Today's date
            DateTime today = DateTime.Today;
            // Moving day after day until hit on Friday
            DateTime date = today;
            while (date.DayOfWeek != DayOfWeek.Saturday)
            {
                date = date.AddDays(1);
            }
            // Calculating remaining days
            TimeSpan dateDifference = date - today;
            int daysRemaining = dateDifference.Days;
            // Outputs
            Console.WriteLine("Hari Sabtu: " + date.ToShortDateString());
            Console.WriteLine(daysRemaining.ToString() + " hari lagi!");
            if (daysRemaining == 0)
            {
                Console.WriteLine("Alhamdulillah!");
            }
        }

        //12
        public static void CountStringInString()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();
            Console.Write("Find string: ");
            string? findStr = Console.ReadLine();



            int position = 0;
            int count = 0;
            int n = findStr.Length;
            while ((position = input.IndexOf(findStr, position)) != -1)
            {
                position = position + n;
                count++;
            }

            Console.WriteLine($"Total kata yang muncul : {count.ToString()} dari text : {input}");
        }




    }



}