/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr) // метод, который печатает массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод, который заполняет массив случайными числами от 1 до 9
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1,10)
        }
    }
}

int GetSumNumber(int[,] matrix, int i) //метод, который считает сумму элементов в строке
{
    int sumLine = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumLine = sumLine + matrix[i, j];
    }
    return sumLine;


}
int minSum = 0; // нахождение строки с наименьшей суммой элементов
int resultSum = GetSumNumber(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSum = GetSumNumber(matrix, 0);
    if (minSum > tempSum)
    {
        minSum = tempSum;
        minSum = i;
    }
}

Console.WriteLine($"\n{resultSum + 1} - строкa с наименьшей суммой элементов ");

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
