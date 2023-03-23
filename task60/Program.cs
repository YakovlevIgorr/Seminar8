// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] array = new int[2,2,2];

int[,,] FillArray(int [,,] arra)
{
    int a = 16;

    for(int i = 0; i < arra.GetLength(0); i++)
    {
        for(int j = 0; j < arra.GetLength(1); j++)
        {
            for(int k = 0; k < arra.GetLength(2); k++)
            {
                arra[i, j ,k] = a;
                a = a + 7;//шаг заполнения
            }
        }     
    }
    return arra;
}

void PrintArray(int [,,] arra)
{
    for(int i = 0; i < arra.GetLength(0); i++)
    {
        for(int j = 0; j < arra.GetLength(1); j++)
        {
            for(int k = 0; k < arra.GetLength(2); k++)
            {
                Console.Write($"{arra[i, j ,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }     
    }
}

PrintArray(FillArray(array));