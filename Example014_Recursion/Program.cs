// Собрать строку с числами от а до b, a <= b

// int m = InputIntegerPositiveNum("Please enter A: ");
// int n = InputIntegerPositiveNum("Please enter B: ");

// Console.WriteLine(NumbersFor(m, n));
// Console.WriteLine(NumbersRec(m, n));

// // Функция сборки по старинке
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for(int i = a; i <= b; i++)
//         {
//             result += $"{i} ";
//         }
//     return result;
// }

// // Функция сборки при помощи рекурсии
// string NumbersRec(int a, int b)
// {
//     if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// int InputIntegerPositiveNum(string text)
// {
//     int number;
//     Console.Write(text+ ":");
//     while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
//     {
//         Console.WriteLine("Wrong input, try again!");
//         Console.Write("Please, enter positive integer number: ");
//     }
//     return number;
// }

//Сумма числе от 1 до N

// int n = InputIntegerPositiveNum("Please enter N: ");

// Console.WriteLine(SumFor(n));
// Console.WriteLine(SumRec(n));

// int SumFor(int a)
// {
//     int result = 0;
//     for(int i = 1; i <= a; i++) result += i;
//     return result;
// }

// int SumRec(int a)
// {
//     if(a == 0) return 0;
//     else return a + SumRec(a - 1);
// }

//Факториал числа
//  int n = InputIntegerPositiveNum("Please enter N: ");

//  Console.WriteLine(FactorialFor(n));
//     Console.WriteLine(FactorialRec(n));

//  int FactorialFor(int a)
//     {
//        int result = 1;
//        for(int i = 1; i <= a; i++) result *= i;
//      return result;
//     }

//  int FactorialRec(int a)
//  {
//      if(a == 1) return 1;
//      else return a * FactorialRec(a - 1);
//  }

//Возыедение числа в степень

// int m = InputIntegerPositiveNum("Please enter Число: ");
// int n = InputIntegerPositiveNum("Please enter Степень: ");

// Console.WriteLine(PowerFor(m, n));
// Console.WriteLine(PowerRec(m, n));
// int PowerFor(int a, int b)
// {
//     int result=1;
//     for(int i = 1; i <=n; i++) result *= a;
//     return result;
// }
// int PowerRec(int a, int n)
// {
//     if(n == 0) return 1;
//     else return PowerRec(a, n-1)*a;
// }

//Поиск комбинаци из букв
// int n = 1;
// FindWords("аисв", new char[4]);

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}");
//         return;
//     }

//     for(int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length+1);
//     }
// }

//Рекурсия и директории

// string path = "C://Study//Lesson//Lang//Examples//Example014_Recursion";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for(int i = 0; i < fi.Length; i++)
// {
//  Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo [] catalogs = catalog.GetDirectories();
//     for(int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + "  ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for(int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = @"C:\Study\Lesson\Lang\Examples\Example014_Recursion";

// CatalogInfo(path);

//Рекурсия в игре пирамидки
// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)

// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

//Обход разных структур с испозьзованием рекурсии

// string emp = String.Empty;
// string [] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
// //                 0    1    2     3    4    5    6    7    8    9    10   11

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos +1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();