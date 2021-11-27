// ## Двумерные массивы
void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            System.Console.Write(array[row, col] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


int[,] MakeRandomArray(int rows, int cols, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[rows, cols];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = rand.Next(min, max + 1);
        }
    }
    return array;
}

int[,] array = MakeRandomArray(5, 5, 0, 100);

// 54. В матрице чисел найти сумму элементов главной диагонали
System.Console.WriteLine("54. В матрице чисел найти сумму элементов главной диагонали");
int SumMainDiagonal(int[,] array)
{
    int result = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (row == col) result += array[row, col];
        }
    }
    return result;
}
PrintMatrix(array);
System.Console.WriteLine(SumMainDiagonal(array));

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
System.Console.WriteLine("55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
int[] GetAverage(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            result[col] += array[row, col];
        }
    }
    return result;
}

PrintMatrix(array);
PrintArray(GetAverage(array));
// 56. Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.WriteLine("56. Написать программу, которая обменивает элементы первой строки и последней строки");
int[,] ChangeFirstAndLast(int[,] array)
{
    int temp;
    if (array.GetLength(0) < 2) return array;
    for (int col = 0; col < array.GetLength(1); col++)
    {
        temp = array[0, col];
        array[0, col] = array[array.GetLength(1) - 1, col];
        array[array.GetLength(1) - 1, col] = temp;
    }
    return array;
}

PrintMatrix(array);
PrintMatrix(ChangeFirstAndLast(array));

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
System.Console.WriteLine("57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");

int[] GetRowFromMatrix(int[,] matrix, int row)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = matrix[row, i];
    }
    return array;
}

int[,] SetRowToMatrix(int[] array, int[,] matrix, int row)
{
    for (int i = 0; i < array.Length; i++)
    {
        matrix[row, i] = array[i];
    }
    return matrix;
}

int[] SortDescArray(int[] array)
{
    int min, minIndex, temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        min = array[0];
        minIndex = 0;
        for (int j = 0; j < array.Length - i; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                minIndex = j;
            }
        }
        temp = array[minIndex];
        array[minIndex] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

int[,] SortRowsInMatrix(int[,] matrix)
{
    int[] array;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        array = GetRowFromMatrix(matrix, row);
        array = SortDescArray(array);
        matrix = SetRowToMatrix(array, matrix, row);
    }
    return matrix;
}
PrintMatrix(array);
PrintMatrix(SortRowsInMatrix(array));


// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
System.Console.WriteLine("58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить");
// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
System.Console.WriteLine("59. В прямоугольной матрице найти строку с наименьшей суммой элементов.");
// 60. Составить частотный словарь элементов двумерного массива
System.Console.WriteLine("60. Составить частотный словарь элементов двумерного массива");
// 61. Найти произведение двух матриц
// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
// 65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 