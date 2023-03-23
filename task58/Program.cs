// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
int a = 5;
int b = 5;
int[,] arrayFirst = new int[a, b];
int[,] arraySecond = new int[a, b];
int[,] arrayResult = new int[a, b];

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

int[, ] SummArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayTotal = new int[a, b];

    for(int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for(int j = 0; j < arrayOne.GetLength(1); j++)
        {
            arrayTotal[i, j] = arrayOne[i, j] * arrayTwo[i, j];
        }
    }
    return arrayTotal;
}


PrintArray(FillArray(arrayFirst));
PrintArray(FillArray(arraySecond));
PrintArray(SummArray(arrayFirst, arraySecond));