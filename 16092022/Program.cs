// // // // Задача 39: Напишите программу, которая перевернёт одномерный массив 
// // // //(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // // // [1 2 3 4 5] -> [5 4 3 2 1]
// // // // [6 7 3 6] -> [6 3 7 6]

// // // int size = Convert.ToInt32(Console.ReadLine());

// // // int[] array = new int[size];
// // // for (int i = 0; i < size; i++)
// // // {
// // //     array[i] = new Random().Next(11);
// // //     Console.Write(array[i] + "\t");
// // // }

// // // //1. Перевернутая копия массива
// // // System.Console.WriteLine();
// // // Console.WriteLine("Перевернутый массив");
// // // int[] reverseArray = new int[size]; //размер копии совпадаетт с оригиналом\
// // // int lastIndex = size -1;
// // // for (int i=0; i <size ; i++)
// // // {
// // //     reverseArray[i] = array[lastIndex - i];
// // //     Console.Write(reverseArray[i] + "\t");
// // // }

// // int[] array = GetArray(10, 0, 10); // size = 10, диапазон элементов: [0;10]
// // Console.WriteLine(String.Join(" ", array));

// // int[] reversArray = CopyArray(array);
// // Console.WriteLine(String.Join(" ", reversArray)); // С копией массива, оригинал не изменяется

// // ReverseArray(array);
// // Console.WriteLine(String.Join(" ", array));
// // // Меняете исходный массив, но дополнительный массив не создается

// // int[] GetArray(int size, int minValue, int maxValue)
// // {
// // int[] res = new int[size];

// // for (int i = 0; i < size; i++)
// // {
// //     res[i] = new Random().Next(minValue, maxValue + 1);
// // }
// // return res;
// // }

// // void ReverseArray(int[] inArray)
// // {
// // for (int i = 0; i < inArray.Length / 2; i++)
// // {
// // int temp = inArray[i];
// // inArray[i] = inArray[inArray.Length - i - 1];
// // inArray[inArray.Length - i - 1] = temp;
// // }
// // }

// // int[] CopyArray(int[] inArray)
// // {
// // int[] result = new int[inArray.Length];
// // for (int i = 0; i < inArray.Length; i++) // inArray.Length = size
// // {
// // result[i] = inArray[inArray.Length - 1 - i]; // size - 1
// // }
// // return result;
// // }

// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// //может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// // int a=3;

// // int b=4;
// // int c =5;
// // //bool возвращает либо тру либо фолс
// // bool IsTringle(int a, int b, int c)
// // {
// // return ((a+b>c)&&(a+c>b)&&(c+b>a));
// // }

// // Console.WriteLine(IsTringle(a,b,c));

// // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// // Если N = 5 -> 0 1 1 2 3
// // Если N = 3 -> 0 1 1
// // Если N = 7 -> 0 1 1 2 3 5 8

// // int n = Convert.ToInt32(Console.ReadLine());
// // int[] arr = new int[n];

// // arr[0] = 0;
// // arr[1] = 1;

// // for(int i = 2; i < n; i++)
// // {
// //     arr[i] = arr[i-1] + arr[i-2];     
// // }
// // System.Console.WriteLine(String.Join(" ", arr));

// //через чиссла

// int number = 10;
// int firstNumber = 0;
// int secomdNumber = 1;
// Console.WriteLine(firstNumber);
// Console.WriteLine(secomdNumber);
// for (int i = 3; i < number; i++)
// {
//     int nextNumber = firstNumber + secomdNumber;
//     Console.Write(nextNumber + "\t");
//     firstNumber = secomdNumber;
//     secomdNumber = firstNumber;
// }


// ,,,,,,
int number = -10; // Кол-во чисел Фибоначчи
//if (number < 2) return;// от -бесконечности до 1 включительно
int firstNumber = 0;  // Первое число

int secondNumber = 1; // Второе число

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
// i = 3
for (int i = 3; i < number; i++)
{
    int nextNumber = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = nextNumber;
    Console.Write(nextNumber + "\t");
}



