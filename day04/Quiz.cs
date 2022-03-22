namespace day04
{
    class Quiz
    {
        //soal 01 
        public static void Soal01(List<int> a, List<int> b)
        {
            // input a : 1,2,5,6,9
            //input b : 1,2,3,4
            //output case1 irisan : 1,2
            var s1 = new HashSet<int>(a);
            s1.IntersectWith(b);
            DisplayHashSet(ref s1);

            var s2 = new HashSet<int>(a);
            s2.UnionWith(b);
            Console.WriteLine();
            DisplayHashSet(ref s2);

            var s3 = new HashSet<int>(a);
            s3.ExceptWith(b);
            Console.WriteLine();
            DisplayHashSet(ref s3);

        }
        
        //soal 02 reverse
        public static List<T> Soal02<T>(ref List<T> inputs)
        {
            //declare variable for return value
            List<T> outputs = new List<T>();

            foreach (var item in inputs)
            {
                outputs.Add(item);
            }

            outputs.Reverse();

            return outputs;
        }

        public static void DisplayList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($" {item} ");
            }
        }

        public static void DisplayHashSet<T>(ref HashSet<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($" {item} ");
            }
        }

        public static void DisplayDictionary(Dictionary<int,int> list)
        {
            foreach (var item in list)
            {
                Console.Write($" {item.Key} = {item.Value} ");
            }
        }

        //soal nomor 03
        public static List<T> Soal03<T>(ref List<T> inputs)
        {
            List<T> result = new List<T>(inputs);
            HashSet<T> numbers = new HashSet<T>();

            foreach (var item in result)
            {
                numbers.Add(item);
            }

            return numbers.ToList();
        }

        //soal nomor 04
        public static List<int> Soal04<T>(ref List<T> values)
        {
            List<int> longestSequence = new List<int>();

            List<int> currentSequence = new List<int>();

            int lastValue = int.MinValue;
            // cast to List<int>
            foreach (int currentValue in values.Cast<int>().ToList())
            {
                if (currentValue >= lastValue)
                {
                    lastValue = currentValue;
                    currentSequence.Add(currentValue);
                }
                else
                {
                    // end of this sequence, start new sequence, check length,

                    if (currentSequence.Count() >= longestSequence.Count())
                    {
                        longestSequence = currentSequence;
                    }
                    currentSequence = new List<int>();
                    lastValue = currentValue;
                    currentSequence.Add(currentValue);
                }
            }

            // if last sequence element smaller than prvioud then do this
            if (currentSequence.Count() >= longestSequence.Count())
            {
                longestSequence = currentSequence;
            }

            return longestSequence;


        }

        //soal nomor 05
        public static void Soal05(List<string> arr1, List<string> arr2, out HashSet<string> same,
            out HashSet<string> different)
        {
            same = new HashSet<string>(arr1);
            different = new HashSet<string>(arr2);

            same.IntersectWith(different);
            different.SymmetricExceptWith(arr1);
        }

        //soal nomor 06
        public static Dictionary<int,int>Soal06(List<int> numbers)
        {
            Dictionary<int,int> valueToCount = new Dictionary<int,int>();
            numbers.ForEach(number =>
            {
                if (valueToCount.ContainsKey(number))
                {
                    valueToCount[number] = valueToCount[number] + 1;
                }
                else
                {
                    valueToCount.TryAdd(number, 1);
                }
                
            });
            return valueToCount;
        }
    }
}