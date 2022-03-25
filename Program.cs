// See https://aka.ms/new-console-template for more information

using day08;
using Fundamental.day09;

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

/*int[] list = day02.Arrays.CreateRandomArray();
day02.Arrays.DisplayArrayNumber(list);*/
//day02.Arrays.SumElement(list);
/*int max = day02.Arrays.FindMaxNumber(list); 
int indexMax = day02.Arrays.FindIndexMaxNumber(list);
Console.WriteLine($"\nMax number : {max}");
Console.WriteLine($"\nMax number position at: {indexMax}");*/

//day02.Arrays.CopyArray(list);

/*day03.Array2D.InitMatrix();

int[,] matrix2 =
            {
                {1, 2, 3, 4, 5},
                {11, 12, 13, 14, 15},
                {21, 22, 23, 24, 25},
                {31, 32, 33, 34, 35},
                {41, 42, 43, 44, 45}
            };

int sum = day03.Array2D.SumMatrix(matrix2);
Console.WriteLine($"Total Sum : {sum}");

day03.Array2D.DisplayMatrix(day03.Array2D.RandomMatrix());*/

//day04.Collections.InitHashSet();

//----------------- quiz day04 -------//

/*day04.Quiz.Soal01(new List<int> { 1, 2, 5, 6, 9 }, new List<int> { 1, 2, 3, 4 });


List<int> c = new List<int> { 1, 2, 3, 4 };
List<int> s02 = day04.Quiz.Soal02(ref c);*/
//day04.Quiz.DisplayList(ref s02);

/*List<string> str1 = new List<string> { "code", "bootcamp", "id", "net" };
List<string> s03 = day04.Quiz.Soal02(ref str1);
Console.WriteLine();*/
//day04.Quiz.DisplayList(ref s03);

//soal 2
//Dictionary<int,int> numbers1 = day04.Quiz.Soal06(new List<int>(){1,1,1,2,2,2,3,3,3,3,3});
//day04.Quiz.DisplayDictionary(numbers1);



//soal04
/*List<int> e = new List<int> { 7, 2, 7, 1, 2, 5, 7, 1 };
List<int> soal4 = day04.Quiz.Soal04(ref e);
day04.Quiz.DisplayList(ref soal4);
Console.WriteLine()*/
;
//soal05
/*List<string> arr1 = new List<string> { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
List<string> arr2 = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
day04.Quiz.Soal05(arr1, arr2, out HashSet<string> same, out HashSet<string> different);*/

/*Console.Write("same : ");
day04.Quiz.DisplayHashSet(ref same);
Console.WriteLine();
Console.Write("different : ");
day04.Quiz.DisplayHashSet(ref different);
//soal 06
var v6 = new List<int>() { 1, 1, 2, 2, 2, 3, 3, 4, 5, 6 };
List<int> l6 = day04.Quiz.Soal03(ref v6);
Console.WriteLine();*/
//day04.Quiz.DisplayList(ref l6);

// ------------- OOP -----------------/

// create new object employee instance
/*Employee emp1 = new Employee();
emp1.EmpId = 1;
emp1.Name = "Agus";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 15_000_000;
emp1.Role = "Manager";*/

// constructor with params
/*Employee emp2 = new Employee("Budi",6_000_000,new DateTime(2015,3,12),"Asisten");
Employee emp3 = new Employee("Charlie", 5_500_000, new DateTime(2018, 3, 12), "Sales");
Employee emp4 = new Employee("Dian", 4_500_000, new DateTime(2018, 3, 12), "Sales");*/
// insert to list
//List<Employee> listEmployee = new List<Employee>() { emp1, emp2, emp3, emp4};

//var junior = listEmployee.FindAll(e => e.BasicSalary < 6_000_000);

// object instance employee permanent
/*Permanent emp5 = new Permanent("Herlis", 15_000_000, new DateTime(2019, 8, 11), "Net Developer");
listEmployee.Add(emp5);*/

/*Employee emp6 = new Permanent("Viona", 11_000_000, new DateTime(2019, 8, 11), "Mobile App Developer");
listEmployee.Add(emp6);*/


// polymorphism
//Employee emply = emp5;

// parent class employee can not be cast to childclass permanent
//Permanent pm1 = (Permanent)emp2; // getting error
// int i = (int)45M;

/*Console.WriteLine(emp4.ToString());
Console.WriteLine(emp6.ToString());

var totalEmployee = Employee.totalEmployee;*/


// call interface
/*IEmployee empInf = new EmployeeImpl();

List<Employee> empList = empInf.GetAll();

var empFilter = empInf.FindEmployeeByRole(empList, "Developer");
*/

//study case solution juragan mobil

// create object angkot
Angkot angkot1 = new Angkot("D1234UM", "2015", "ANGKOT", 4_500, 20);
Angkot angkot2 = new Angkot("D1256UM", "2017", 4_500, 100);

SUV suv1 = new SUV("D111UX", "2017", 500_000, 100_000);
SUV suv2 = new SUV("D222UX", "2019", 600_000, 100_000);

//declare interface
ICar carInf = new CarImpl();

var listCar = carInf.InitListCar(new Car[] { angkot1, angkot2, suv1, suv2 });

//search by nomor polisi
var myCar = carInf.FindCarByNomor(listCar, "D111UX");

//search car by type
var listAngkot = carInf.FindCarByType(listCar, EnumCar.ANGKOT);
var listSuv = carInf.FindCarByType(listCar, EnumCar.SUV);

//revenue
var totalRevenueAngkot = carInf.TotalPendapatan(listCar, EnumCar.ANGKOT);
var totalRevenueSuv = carInf.TotalPendapatan(listCar, EnumCar.SUV);
var totalRevenueCar = carInf.TotalPendapatan(listCar, EnumCar.ALL_CAR);

carInf.DisplayCar();

/*Console.WriteLine(angkot1);
Console.WriteLine(suv1);*/

Console.ReadLine();

