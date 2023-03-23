// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] array = new int[5, 5];

int[,] FillArray(int[,] arrayForFill)
{
    for (int i = 0; i < arrayForFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForFill.GetLength(1); j++)
        {
            arrayForFill[i, j] = Random.Shared.Next(0, 10);
        }
    }
    return arrayForFill;

}

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(arrayPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

void PrintNumberMinLine(int[,] arrayForWork)
{
    int [] tempArray = new int[arrayForWork.GetLength(0)];
    int indexLine = 0;

    for(int i = 0; i < arrayForWork.GetLength(0); i++)
    {
        for(int j = 1; j < arrayForWork.GetLength(1); j++)
        {
            arrayForWork[i , 0] += arrayForWork[i, j]; 
        }
        if(arrayForWork[indexLine, 0] > arrayForWork[i, 0]) indexLine = i;

    }
    Console.WriteLine((indexLine + 1) + " строка");
}

int[,] fullArray = FillArray(array);
PrintArray(fullArray);
PrintNumberMinLine(fullArray);