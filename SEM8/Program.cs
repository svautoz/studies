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

void Print3DArrayWithIndex(int[,,] array)
{
    for (int dim_1 = 0; dim_1 < array.GetLength(0); dim_1++)
    {
        for (int dim_2 = 0; dim_2 < array.GetLength(1); dim_2++)
        {
            for (int dim_3 = 0; dim_3 < array.GetLength(2); dim_3++)
            {
                System.Console.Write(array[dim_1, dim_2, dim_3] + $"({dim_1}, {dim_2}, {dim_3}) ");
            }
            System.Console.WriteLine();
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

void PrintArrayWithIndex(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(i + " ");
    }
    System.Console.WriteLine();
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

int[,] TransponSquareMatrix(int[,] matrix)
{
    int temp;
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        System.Console.WriteLine("Матрица не квадратная");
        return matrix;
    }
    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        for (int col = row + 1; col < matrix.GetLength(1); col++)
        {
            temp = matrix[row, col];
            matrix[row, col] = matrix[col, row];
            matrix[col, row] = temp;
        }
    }
    return matrix;
}

int[,] TransponMatrix(int[,] matrix)
{
    int[,] transponMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            transponMatrix[col, row] = matrix[row, col];
        }
    }
    return transponMatrix;
}

int[,] matrix = MakeRandomArray(5, 5, 0, 100);
PrintMatrix(matrix);
PrintMatrix(TransponSquareMatrix(matrix));

matrix = MakeRandomArray(5, 10, 0, 100);
PrintMatrix(matrix);
PrintMatrix(TransponMatrix(matrix));

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
System.Console.WriteLine("59. В прямоугольной матрице найти строку с наименьшей суммой элементов.");
int GetMinSumValuesRow(int[,] matrix)
{
    int minRowSum = 0;
    int minRowIndex = 0;
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        minRowSum += matrix[0, col];
    }
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int rowSum = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            rowSum += matrix[row, col];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowIndex = row;
        }
    }
    return minRowIndex;
}

matrix = MakeRandomArray(5, 4, 0, 10);
PrintMatrix(matrix);
System.Console.WriteLine(GetMinSumValuesRow(matrix));

// 60. Составить частотный словарь элементов двумерного массива
System.Console.WriteLine("60. Составить частотный словарь элементов двумерного массива");
int[] GetFreqDictionary(int[,] matrix, int minValue, int maxValue)
{
    int[] freqDictionary = new int[maxValue - minValue + 1];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            freqDictionary[matrix[row, col]] += 1;
        }
    }
    return freqDictionary;
}

int minValue = 0, maxValue = 10;
matrix = MakeRandomArray(5, 4, minValue, maxValue);
PrintMatrix(matrix);
PrintArrayWithIndex(GetFreqDictionary(matrix, minValue, maxValue));


// 61. Найти произведение двух матриц
System.Console.WriteLine("61. Найти произведение двух матриц");

int[,] GetMultipliedMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        System.Console.WriteLine("Невозможно перемножить");
        return new int[,] { };
    }

    int newMatrixRows, newMatrixCols;
    if (matrixB.GetLength(0) > matrixA.GetLength(0)) newMatrixRows = matrixB.GetLength(0);
    else newMatrixRows = matrixA.GetLength(0);
    if (matrixB.GetLength(1) > matrixA.GetLength(1)) newMatrixCols = matrixB.GetLength(1);
    else newMatrixCols = matrixA.GetLength(1);

    int[,] matrixC = new int[newMatrixRows, newMatrixCols];
    for (int row = 0; row < newMatrixRows; row++)
    {
        for (int col = 0; col < newMatrixCols; col++)
        {
            matrixC[row, col] = GetRowsMultiply(row, col, matrixA, matrixB);
        }
    }
    return matrixC;
}

int GetRowsMultiply(int row, int col, int[,] matrixA, int[,] matrixB)
{
    int result = 0;
    for (int i = 0; i < matrixA.GetLength(1); i++)
    {
        result += matrixA[row, i] * matrixB[i, col];
    }
    return result;
}

int[,] matrixA = MakeRandomArray(3, 2, 0, 10);
PrintMatrix(matrixA);
int[,] matrixB = MakeRandomArray(2, 4, 0, 10);
PrintMatrix(matrixB);
PrintMatrix(GetMultipliedMatrix(matrixA, matrixB));


// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
System.Console.WriteLine("62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");
//Считает для первого наименьшего значения
int[,] GetModifiedArray(int[,] array)
{
    int min = array[0, 0];
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] minIndex = new int[2];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] < min)
            {
                min = array[row, col];
                minIndex[0] = row;
                minIndex[1] = col;
            }
        }
    }
    int rowNew = 0, colNew = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        if (row == minIndex[0]) continue;
        colNew = 0;
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (col == minIndex[1]) continue;
            newArray[rowNew, colNew] = array[row, col];
            colNew++;
        }
        rowNew++;
    }
    return newArray;
}

matrix = MakeRandomArray(6, 5, 1, 10);
PrintMatrix(matrix);
PrintMatrix(GetModifiedArray(matrix));


// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
System.Console.WriteLine("63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента");
int[,,] Make3DArray(int firstDimSize, int SecondDimSize, int thirdDimSize)
{
    if (firstDimSize * SecondDimSize * thirdDimSize > 90)
    {
        System.Console.WriteLine("При таком размере массива невозможно выполнить данную задачу.");
        return new int[,,] { };
    }
    int index = 10;
    int[,,] array3D = new int[firstDimSize, SecondDimSize, thirdDimSize];
    for (int dim_1 = 0; dim_1 < firstDimSize; dim_1++)
    {
        for (int dim_2 = 0; dim_2 < SecondDimSize; dim_2++)
        {
            for (int dim_3 = 0; dim_3 < thirdDimSize; dim_3++)
            {
                array3D[dim_1, dim_2, dim_3] = index++;
            }
        }
    }
    return array3D;
}

int[,,] array3D = Make3DArray(4, 5, 4);
Print3DArrayWithIndex(array3D);

// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
System.Console.WriteLine("64. Показать треугольник Паскаля");
//Сделал на примере определенного размера
int[,] GetPascalTriangle()
{
    int[,] pascalArray = new int[8, 15];
    pascalArray[0, pascalArray.GetLength(1) / 2] = 1;
    int firstValue, secondValue;
    for (int row = 1; row < pascalArray.GetLength(0); row++)
    {
        for (int col = 0; col < pascalArray.GetLength(1); col++)
        {
            if (col - 1 < 0) firstValue = 0;
            else firstValue = pascalArray[row - 1, col - 1];

            if (col + 1 > pascalArray.GetLength(1) - 1) secondValue = 0;
            else secondValue = pascalArray[row - 1, col + 1];

            pascalArray[row, col] = firstValue + secondValue;
        }
    }

    return pascalArray;
}

int[,] pascalArray;
PrintMatrix(GetPascalTriangle());

// 65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
System.Console.WriteLine("65. Спирально заполнить двумерный массив:");
int[,] GetSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int increment = 1;
    int indexRow = 0;
    int indexCol = -1;
    int cycle = 0;
    while (increment <= size * size)
    {
        do
        {
            if(increment > size * size) return array;
            indexCol++;
            array[indexRow, indexCol] = increment++;
        } while (indexCol + 1 < array.GetLength(1) - cycle);

        do
        {
            if(increment > size * size) return array;
            indexRow++;
            array[indexRow, indexCol] = increment++;
        } while (indexRow + 1 < array.GetLength(0) - cycle);

        do
        {
            if(increment > size * size) return array;
            indexCol--;
            array[indexRow, indexCol] = increment++;
        } while (indexCol > cycle);


        do
        {
            if(increment > size * size) return array;
            indexRow--;
            array[indexRow, indexCol] = increment++;
        } while (indexRow > cycle + 1);

        cycle++;
    }
    return array;
}

PrintMatrix(GetSpiralArray(7));