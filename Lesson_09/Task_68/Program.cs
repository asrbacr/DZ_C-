System.Console.Write("Введите m: ");
int m = UserInput();
System.Console.Write("Введите n: ");
int n = UserInput();

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана: A({m},{n}) = {functionAkkerman}");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");
    return number;
}
