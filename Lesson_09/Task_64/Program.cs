System.Console.Write("Введите число до которого будем считать от 1-ого: ");
int n = UserInput();
PrintNumber(1, n);

//____func 

void PrintNumber(int M, int N)
{
    if (M > N)
    {
        PrintNumber(M - 1, N);
        Console.Write($", {M}");
    }
    else if (M < N)
    {
        PrintNumber(M, N - 1);
        Console.Write($", {N}");
    }
    else if (M == N)
    {
        Console.Write($"{M}");
    }
}

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");
    return number;
}