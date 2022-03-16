// See https://aka.ms/new-console-template for more information

//call other class

//day01.ConsoleIntro.ShowMultiConsole();

//day01.StoreVariable.StoreCharText();

//Console.WriteLine(day01.StoreVariable.StoreString());

//day01.StoreVariable.ShowDouble();
//day01.StoreVariable.ShowDecimal();
//day01.StoreVariable.ShowDataTypeRange();
//day01.ControlStatement.ValidatePassword("123445654");
//day01.Iterator.ShowBox();
//day01.StoreVariable.ShowDiffDate();
//day01.HandlingException.ShowTryParse();
//day01.ControlStatement.GuessNumber();

// --------------------- day02 ------------//
//day02.Arrays.InitArray();

//int[] list = { 2, 3, 4, 4, 5, 5, 5 };

int[] list = day02.Arrays.CreateRandomArray();
day02.Arrays.DisplayArrayNumber(list);
//day02.Arrays.SumElement(list);
int max = day02.Arrays.FindMaxNumber(list); 
int indexMax = day02.Arrays.FindIndexMaxNumber(list);
Console.WriteLine($"\nMax number : {max}");
Console.WriteLine($"\nMax number position at: {indexMax}");

day02.Arrays.CopyArray(list);

Console.ReadLine();

