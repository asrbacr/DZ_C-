int[,,] arr3D = new int[2, 2, 2];
FillArray(arr3D);
System.Console.WriteLine();
PrintArray(arr3D);


//___func
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int count = new Random().Next(10, 100);
                array[k, i, j] = count;
            }
        }
    }
}


