// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();
int size = 20;
// int[] array = new int[size];
int count = 0;
// for (int i = 0; i < size; i++)
int number = 0;
Console.WriteLine("Введите отрицательное или положительное число M");
int [] M = Array.ConvertAll(Console.ReadLine().Split());
number = Convert.ToInt32(m);
for (int i = 0; i < size; i++)
{
    M[i] = new Random().Next(-100, 100);
    Console.Write(M[i] + "\t");
    if (M[i] > 0) count++;
}
Console.WriteLine($"{"\n"}Количество четных чисел в массиве:  {count}");
Console.WriteLine();

////////////////////////////

// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100);
//     Console.Write(array[i] + "\t");
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)