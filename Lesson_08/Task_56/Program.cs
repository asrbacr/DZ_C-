//____code

int[,] array = GenerateArray(3, 4, 1, 9);
PrintArray2D(array);



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

int[] AverColumnArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];

    int SredNumbs = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SredNumbs += array[i, j];
        }
        newArray[i] = SredNumbs;
    }
    return newArray;
}

int SerchMinIndex(int[] array)
{
    int indMin = 0;
    int numMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {

    }
}