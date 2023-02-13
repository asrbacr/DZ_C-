//____code

int[,] array = GenerateArray(6, 2, 1, 9);
PrintArray2D(array);
System.Console.WriteLine();
System.Console.Write("Наименьшая сумма находится в ");
LineMinSum(array);

//___func

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

void LineMinSum(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строке");
}
