// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы через пробел : ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//Console.ReadLine() - считывание с консоли введеные данные
//Split() - разбивает строку на подстроки, разделителем в данном случае служит пробел
//int.Parse - Преобразует строковое представление числа в эквивалентное 32-битовое знаковое целое число , 
//была строка 1234, а стало число 1234
// Array.ConvertAll - Массив целевого типа, содержащий преобразованные элементы исходного массива.
int count = 0;
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов больше 0: {count}");
Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите  координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите  координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine("\n" + $"Прямые пересекутся в точке: ({x};{y})");
Console.WriteLine();

Console.WriteLine("************************************************************");
Console.WriteLine();
Console.WriteLine();


Console.Write("Введите через пробел координаты X и Y двух точек : ");
double[] array = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
Console.WriteLine();
double crossX = 0;
double crossY = 0;
double Dot1 = 0;
double Dot2 = 0;
for (int i = 0; i < array.Length; i++)
{
    Dot1 = array[0] * array[1];
    Dot2 = array[2] * array[3];
     if (array[0] * array[3] - array[2] * array[1] == 0)
    {
        Console.WriteLine("Линии параллельны");
    }
    if (array[0] * array[3] - array[2] * array[1] == 0 && array[2] * array[1] - array[0] * array[3] == 0)
    {
        Console.WriteLine("Линии совпадают");
    }
    if (i > 8)
    {
        Console.WriteLine("Вы ввели координаты более чем двух точек");
    }
    else
    {
        crossX = -(array[0] - array[2]) / (array[1] - array[3]);
      
        crossY = (array[3] * crossX + array[2]);
      
        Console.WriteLine($"Искомая точка: {crossX},{crossY}");
    }
}

Console.WriteLine();