// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задайте двумерный массив размером m-n, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            Console.Write($"{matr[i, j]} " + "\t");
        }
            Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            matr[i,j] = Convert.ToDouble(rnd.Next(0, 100)/10.0);
        }
    }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задайте количество строк двумерного массива:");
int strok1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int stolb1 = Convert.ToInt32(Console.ReadLine());
int[,] NewMassInputs = new int[strok1, stolb1];
Random NewRandomMass = new Random();
void PrintNewMassiv(int[,] NewMatrix)
{ 
    for (int i = 0; i < strok1; i++)
    { 
        for (int j = 0; j < stolb1; j++)
        { 
            Console.Write($"{NewMatrix[i, j]} " + "\t");
        }
            Console.WriteLine();
    }
}
void GotoviMassiv(int[,] NewMatrix)

{ 
    for (int i = 0; i < strok1; i++)
    { 
        for (int j = 0; j < stolb1; j++)
        { 
            NewMatrix[i,j] = Convert.ToInt32(NewRandomMass.Next(0, 100));
        }
    }
}
Console.WriteLine();
GotoviMassiv(NewMassInputs);
Console.WriteLine();
PrintNewMassiv(NewMassInputs);
Console.WriteLine();
Console.WriteLine("Введите позицию двумерного массива: ");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
    if (a>=strok1 || b>=stolb1)
 Console.WriteLine("такого числа нет");
    else
 {
    object c = NewMassInputs.GetValue(a,b);
    Console.WriteLine(c);
 }
Console.WriteLine();


// Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце."); //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задайте количество строк двумерного массива:");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int stolb = Convert.ToInt32(Console.ReadLine());
double sum=0;
int[,] newInputMass = new int[stroka, stolb];
Random randomMass = new Random();
void PrintNewArray(int[,] matr)
{ 
    for (int i = 0; i < stroka; i++)
    { 
        for (int j = 0; j < stolb; j++)
        { 
            Console.Write($"{matr[i, j]} " + "\t");
        }
            Console.WriteLine();
    }
}
void ReadyArray(int[,] matr)

{ 
    for (int i = 0; i < stroka; i++)
    { 
        for (int j = 0; j < stolb; j++)
        { 
            matr[i,j] = Convert.ToInt32(randomMass.Next(0, 100));
        }
    }
}
Console.WriteLine();
ReadyArray(newInputMass);
Console.WriteLine();
PrintNewArray(newInputMass);
for (int i = 0; i < stolb; i++)
   {
        for (int j = 0; j < m; j++)
            {
                sum += newInputMass[j, i];
            }
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое " + (i + 1) + " столбца равна " + sum/stolb);
    sum = 0;
    }