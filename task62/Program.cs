// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];
int count = 1;
array[0,0] = count;

int[,] Twist(int[,] arrayIn)
{
    int horizontal = 0;
    int vertical = 0;
    
    while (true)
    {
        if (horizontal < arrayIn.GetLength(1) - 1 && arrayIn[vertical, horizontal + 1] == 0) //ход вправо
        {
            while (horizontal < arrayIn.GetLength(1) - 1 && arrayIn[vertical, horizontal + 1] == 0)
            {
                count += 1;
                arrayIn[vertical, horizontal + 1] = count;
                horizontal += 1;
            }
        }

        else if (vertical < arrayIn.GetLength(0) - 1 && arrayIn[vertical + 1, horizontal] == 0) //ход вниз
        {
            while (vertical < arrayIn.GetLength(0) - 1 && arrayIn[vertical + 1, horizontal] == 0)
            {
                count += 1;
                arrayIn[vertical + 1, horizontal] = count;
                vertical += 1;
            }
        }

        else if (horizontal > 0 && arrayIn[vertical, horizontal - 1] == 0) //ход влево
        {
            while (horizontal > 0 && arrayIn[vertical, horizontal - 1] == 0)
            {
                count += 1;
                arrayIn[vertical, horizontal - 1] = count;
                horizontal -= 1;
            }
        }

        else if (vertical > 0 && arrayIn[vertical - 1, horizontal] == 0) //ход вверх
        {
            while (vertical > 0 && arrayIn[vertical - 1, horizontal] == 0)
            {
                count += 1;
                arrayIn[vertical - 1, horizontal] = count;
                vertical -= 1;
            }
        }
        
        else break;
    }
    return arrayIn;

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

PrintArray(array);
array = Twist(array);
PrintArray(array);