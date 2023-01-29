// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] get3DArray(int colLenght, int rowLenght, int deepLenght, int start, int finish)
{
    int[,,] array = new int[colLenght, rowLenght, deepLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            for (int k = 0; k < rowLenght; k++)
            {
                array[i, j, k] = new Random().Next(start, finish + 1);
            }            
        }
    }
    return array;
}

void print3DArray(int[,,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {       
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }            
        }     
    }
}

int[,,] array = get3DArray(2, 2, 2, 1, 10);
print3DArray(array);
