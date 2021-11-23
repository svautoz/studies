// 48. Показать двумерный массив размером m×n заполненный целыми числами
System.Console.WriteLine("48. Показать двумерный массив размером m×n заполненный целыми числами");
int[,] GetRandomValuesArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    Random rand = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = rand.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            System.Console.Write(array[row, col] + " ");
        }
        System.Console.WriteLine();
    }
}
PrintArray(GetRandomValuesArray(5, 3, 10, 155));

// 49. Показать двумерный массив размером m×n заполненный вещественными числами
System.Console.WriteLine();
System.Console.WriteLine("49. Показать двумерный массив размером m×n заполненный вещественными числами");
double[,] GetRandomDoubleValuesArray(int rows, int cols, int min, int max)
{
    double[,] array = new double[rows, cols];
    Random rand = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = rand.Next(min, max) + rand.NextDouble();
        }
    }
    return array;
}
void PrintDoubleArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            System.Console.Write(array[row, col] + " ");
        }
        System.Console.WriteLine();
    }
}

PrintDoubleArray(GetRandomDoubleValuesArray(5, 3, 10, 155));
// 50. В двумерном массиве n×k заменить четные элементы на противоположные
System.Console.WriteLine();
System.Console.WriteLine("50. В двумерном массиве n×k заменить четные элементы на противоположные");
int[,] GetEvenOppositArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] % 2 == 0) array[row, col] -= 2 * array[row, col];
        }
    }
    return array;
}
int[,] array_ex50 = GetRandomValuesArray(3, 5, 10, 100);
PrintArray(array_ex50);
System.Console.WriteLine();
PrintArray(GetEvenOppositArray(array_ex50));

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
System.Console.WriteLine();
System.Console.WriteLine("51. Задать двумерный массив следующим правилом: Aₘₙ = m+n");
int[,] GetArrayMPlusN(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = row + col + 2;
        }
    }
    return array;
}

PrintArray(GetArrayMPlusN(4, 5));
// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
System.Console.WriteLine();
System.Console.WriteLine("52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
int[,] GetArrayWithSquareEvenIndexes(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row += 2)
    {
        for (int col = 0; col < array.GetLength(1); col += 2)
        {
            array[row, col] = array[row, col] * array[row, col];
        }
    }
    return array;
}

int[,] array_ex52 = GetRandomValuesArray(4, 5, 0, 100);
PrintArray(array_ex52);
System.Console.WriteLine();
PrintArray(GetArrayWithSquareEvenIndexes(array_ex52));

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
System.Console.WriteLine();
System.Console.WriteLine("53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");
int[,] GetPositionsByValue(int[,] array, int value)
{
    int count = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] == value) count++;
        }
    }
    if (count == 0) return new int[,] { };
    int[,] positions = new int[count, 2];
    int i = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] == value)
            {
                positions[i, 0] = row;
                positions[i, 1] = col;
                i++;
            }
        }
    }
    return positions;
}

int[,] array_ex53 = GetRandomValuesArray(4, 5, 0, 10);
PrintArray(array_ex53);

System.Console.Write("Ведите число для поиска:");
int number = Convert.ToInt32(Console.ReadLine());
int[,] positions = GetPositionsByValue(array_ex53, number);

if (positions.Length == 0)
    System.Console.WriteLine("Такого элемента нет");
else
    PrintArray(positions);
