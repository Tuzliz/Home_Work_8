/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

*/
int[,] firstMatrix = new int[4, 4];
Console.WriteLine("Первая матрица: ");
FillArray(firstMatrix);
PrintArray(firstMatrix);

int[,] secondMatrix = new int[4, 4];
Console.WriteLine("Вторая матрица: ");
FillArray(secondMatrix);
PrintArray(secondMatrix);


int[,] resultMatrix = new int[4, 4];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Полученная матрица: ");
PrintArray(resultMatrix);


void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix) //метод, который перемножает две матрицы
{

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {

            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
            }



        }
    }
}


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

