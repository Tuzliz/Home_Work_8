/* 
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
 */

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int firstDemension = GetDemension("Введите размер первого разряда x: ");
int secondDemension = GetDemension("Введите размер второго разряда y: ");
int thirdDemension = GetDemension("Введите размер третьего разряда z: ");

int GetDemension(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());

}


int[,,] array3Demensional = new int[firstDemension, secondDemension, thirdDemension];

// Не разобралась как заполнить массив неповторяющимися двухзначными числами?
void FillArray(int[,,] array3Demensional)
{

    int[,,] matrix3D = new int[firstDemension, secondDemension, thirdDemension];
    Random rnd = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rnd.Next(10, 100);


            }



        }
    }
}
// вывод построчно с индексами: ???







void PrintArray(int[,,] array3Demensional)
{
    for (int i = 0; i < array3Demensional.GetLength(0); i++)
    {
        for (int j = 0; j < array3Demensional.GetLength(1); j++)
        {
            for (int k = 0; k < array3Demensional.GetLength(2); k++)
            {
                Console.Write($"{array3Demensional[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


FillArray(array3Demensional);
PrintArray(array3Demensional);

