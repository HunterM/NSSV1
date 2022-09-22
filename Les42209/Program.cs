// string[,] table = new string[2, 5];
// //table[0,0] table[0,1] table[0,2]..table[0,4]
// //table[1,0]
// table[1, 2] = "слово";
// for (int rows = 2; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {

//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLongLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// ????????????????????????????????



// int[,] matrix = new int[3, 4];
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLongLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]} ");
//             }
//          Console.WriteLine();
//         }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }

//     }
    
// }
// // int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


int [,] pic = new int[,];
void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength; i++)
{
    for (int j = 0; j <image.GetLength; j++)
    {
        if (image [i,j] ==0) Console.Write($" ");
        else Console.Write($"+");
    }
Console.WriteLine();
}
}

PrintImage(image);