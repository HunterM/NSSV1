// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (1 > N)
// {
//     Console.WriteLine("Это невозможно");
//     return;
// }
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(1, N));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNumber(string input)
// {
//      Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
//  }

//  void PrintSum(int m, int n, int sum)
//  {
//      sum = sum + n;
//      if (n <= m)
//     {
//          Console.Write($" {sum} ");
//          return;
//      }
//      PrintSum(m, n - 1, sum);

//  }
//  int m = InputNumber("Введите число М: ");
//  int n = InputNumber("Введите число N: ");
//  int temp = m;

//  if (m > n)
//  {
//      m = n;
//      n = temp;
//  }
//  Console.Write($"Сумма элементов между {m} и {n} равна: ");
//  PrintSum(m, n, temp = 0);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int m = InputNumber("Введите число m: ");
Console.WriteLine();
int n = InputNumber("Введите число n: ");
Console.WriteLine();
int akkermanFunction = Akkerman(m, n);
Console.Write($"При m = {m} и  n = {n} вычисления функции Аккермана А(m,n) = {akkermanFunction} ");
Console.WriteLine();
