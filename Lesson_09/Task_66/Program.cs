System.Console.Write("Введите число от которого будем считать: ");
int m = UserInput();
System.Console.Write("Введите число до которого будем считать: ");
int n = UserInput();
System.Console.Write("Сумма ");
FuncSummElements(m, n);

//____func 
void FuncSummElements(int M, int N)
{
    System.Console.Write(SummElements(M - 1, N));
}

int SummElements(int M, int N)
{
    int summ = M;
    if (M == N)
    {
        return 0;
    }
    else
    {
        M++;
        summ = M + SummElements(M, N);
        return summ;
    }

}

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");
    return number;
}