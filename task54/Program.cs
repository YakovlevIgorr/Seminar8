// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] array = new int[6, 7];

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


int[,] IncreasOneLine(int[,] forInsreas, int lineForIncreas)
{
    int temp = forInsreas[lineForIncreas, 0];
    for (int i = 0; i < forInsreas.GetLength(1); i++)
        for (int j = i; j < forInsreas.GetLength(1) - 1; j++)
        {
            {
                if (forInsreas[lineForIncreas, i] >= forInsreas[lineForIncreas, j + 1])
                {
                    temp = forInsreas[lineForIncreas, i];
                    forInsreas[lineForIncreas, i] = forInsreas[lineForIncreas, j + 1];
                    forInsreas[lineForIncreas, j + 1] = temp;

                }

            }
        }
    return forInsreas;

}

int [,] ChangeAllArray(int [,] arrayForChange)
{
    for(int i = 0; i < arrayForChange.GetLength(0); i++)
    {
        arrayForChange = IncreasOneLine(arrayForChange, i);
    }
    return arrayForChange;
}

int[,] fullArray = FillArray(array);
PrintArray(fullArray);
fullArray = ChangeAllArray(fullArray);
PrintArray(fullArray);