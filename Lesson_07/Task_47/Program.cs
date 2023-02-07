
Console.Write("Введите число строк: ");
int m = UserInput();
Console.Write("Введите число столбцов: ");
int n = UserInput();

float[,] array = GenArray(m, n);
PrintArray2D(array);

//____func

void PrintArray2D(float[,] array) //вывод
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

float[,] GenArray(int m, int n)
{
    float[,] array = new float[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int drobNum = 1;

            float a = new Random().Next(0, 6);
            if (a == 1 || a == 4) drobNum = 10;

            a = new Random().Next(-99, 100);
            array[i, j] = a / drobNum;
        }
    }
    return array;
}

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}
