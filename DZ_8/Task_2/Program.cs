Console.WriteLine("\nДаны две случайные квадратные матрицы в диапазоне от 1 до 10:");

int strsCount = 2;
int columnsCount = 2;
int strsCount2 = 2;
int columnsCount2 = 2;
Random rnd = new Random();
int[,] firstMatrix = new int[strsCount, columnsCount];
FillArray(firstMatrix);
Console.WriteLine($"\nПервая квадратная матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[strsCount2, columnsCount2];
FillArray(secondMatrix);
Console.WriteLine($"\nВторая квадратная матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int [strsCount,columnsCount2];
ProductMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц: "); 
PrintArray(resultMatrix);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

void ProductMatrix(int[,] firstMatrix, int[,] secondMatrix, int [,] resultMatrix)
{
    for (int i=0;i<resultMatrix.GetLength(0);i++)
    {
        for (int j=0;j<resultMatrix.GetLength(1);j++)
        {
            int product = 0;
            for (int n=0;n<firstMatrix.GetLength(1); n++)
            {
                product=product+(firstMatrix[i,n] * secondMatrix[n,j]);
            }
            resultMatrix[i,j]=product;
        }
    }
}
// int SumLineElements(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int tempSumLine = SumLineElements(array, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }

// Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
