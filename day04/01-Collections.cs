namespace day04
{
    class Collections
    {
        // List
        public static void InitList()
        {
            // declare
            var number = new List<int>();
            number.Add(1);  
            number.Add(2);

            var words = new List<string> { "code", ".net", "bootcamp" };
        }

        public static void InsertElementToList()
        {
            var numbers = new List<int> { 1, 2, 3 };
            numbers.Add(5);
            numbers.AddRange(new[] { 5, 6, 7 });
            numbers.Insert(5, 100); // sisipkan

            numbers.InsertRange(5, new[] { 10, 20, 30 });
            Console.WriteLine();
        }

        public static void RemoveList()
        {
            var numbers = new List<int> { 13, 17, 19, 2, 3, 5, 7, 1, 1, 11,150,190,180 };
            numbers.Remove(19);
            numbers.RemoveRange(7,2);
            numbers.RemoveAll(e => e > 100);
            numbers.Clear(); // 
            Console.WriteLine();
        }

        public static void FindList()
        {
            var numbers = new List<int> { 1,2,3,5,7,11 };
            var a = numbers.Find(e => e <10);
            var b = numbers.FindLast(e => e < 10);
            var c = numbers.FindAll(e => e < 19);

            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine();
        }

        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(5);
            numbers.Pop();
            Console.WriteLine();

        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            var languages = new Dictionary<int, string>()
            {
                {1,"C#" },
                {2,"Java" },
                {3,"C++" },
            };

            languages.Add(4, "javascript");
            languages.TryAdd(4, "Python");
            languages[5] = "SQL";
            languages[6] = "React";

            Console.WriteLine();
        }


        public static void InitHashSet()
        {
            var numbers = new HashSet<int>() { 1, 2, 2, 1, 3, 4, 4, 5, 5, 6, 7 };
            numbers.Add(10);
            Console.WriteLine();
        } 
      


    }
}