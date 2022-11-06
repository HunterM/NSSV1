//рекурсия функция вызывающая саму себя

// факториал произведение чисел от 1 до N  

// int Factorial(int N)
// {
//Базовый случай - случай выхода из рекурсии
//таким образом рекурсия становится конечной
// if (N==1) return 1; //факториал от 1 = 1 происходит выход из рекурсии
// //рекурсивный случай - вызов функции происходит сама через себя
// return (N*Factorial(N-1));
// }

// Console.WriteLine(Factorial(5));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/// <summary> - комментарии к методу
// [1; N]  = 1,2,3,4,5
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     //базовый случай
//     if (start == end) return start.ToString(); //ыефке -int, а метод string
//                                                //рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(1, N));


//     Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число N: ");
 int N = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число M: ");
 int M = Convert.ToInt32(Console.ReadLine());
 if (M>N)
 {
 Console.WriteLine("Это не возможно");
 return;
 }
    string PrintNumbers(int start, int end)
    {
        //базовый случай
        if (start == end) return start.ToString(); //ыефке -int, а метод string
                                                   //рекурсивный случай
        return (start + ", " + PrintNumbers(start + 1, end));
    }
    Console.WriteLine(PrintNumbers(M, N));


// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// [1;N] = 1,2,3,4,5
/// Комментарии к методу
/// start - начало, то есть, число 1 по условию
/// end - конец или число N
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 6, 7, 8"
// // M = 8, N = 4
// if (M > N)
// {
//     Console.WriteLine("Это невозможно");
//     return;
// }
// string PrintNumbers(int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString(); // start - int, а метод возращает строчку
//     // Рекурсивный случай
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(M, N));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int num)
// {
// // базовый случай
// if (num==0) return 0; //45 -> 4+5+0 = 9; sum +0 = sum
// // рекурсивный случай
// return (num%10+SumNumber(num/10)); //num%10 -> это последняя цифра числа

// }
// Console.WriteLine(SumNumber(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = Convert.ToInt32(Console.ReadLine()); // A

// int degree = Convert.ToInt32(Console.ReadLine()); // B

// int Power(int number, int power)
// {
//     // Базовый случай
//     if (power == 0) return 1;
//     if (power == 1) return number;
//     // Рекурсивный случай
//     return (number * Power(number, power - 1));
// }

// Console.WriteLine(Power(number, degree));
