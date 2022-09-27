Console.WriteLine("\nСлучайный двумерный массив из неповторяющихся двузначных чисел: \n");

int strsCount = 5;
int columnsCount = 10;
int[,] array = new int[strsCount, columnsCount];

FillArray(array);
PrintArray(array);
void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            while (array[i, j] == 0)
            {
                int number = rand.Next(10, 100);
                if (IsNumberInArray(array, number) == false)
                {
                    array[i, j] = number;
                }
            }
        }
    }
}

bool IsNumberInArray(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) return true;
        }
    }
    return false;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" {0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}