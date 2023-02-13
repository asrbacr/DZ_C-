//__code

int[,] array = GenerateArray(3, 4, 1, 9);
PrintArray2D(array);
System.Console.WriteLine();
SortArray(array);
PrintArray2D(array);

//__func

void PrintArray2D(int[,] array) //вывод
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateArray(int m, int n, int min, int max) //генерация
{
    int[,] arrNum = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < arrNum.GetLength(0); i++)
    {
        for (int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = random.Next(min, max + 1);
        }
    }
    return arrNum;
}

int[,] SortArray(int[,] array)
{
    // int max = array[0, 0];
    // int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}
