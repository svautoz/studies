﻿// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.WriteLine("33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива");
int[] MakeArray(int first_number, int last_number, int array_size)
{
    int[] array = new int[array_size];
    Random rand = new Random();
    for (int i = 0; i < array_size; i++)
    {
        array[i] = rand.Next(first_number, last_number + 1);
    }
    return array;
}

double[] MakeDoubleArray(int first_number, int last_number, int array_size)
{
    double[] array = new double[array_size];
    Random rand = new Random();
    for (int i = 0; i < array_size; i++)
    {
        array[i] = rand.Next(first_number, last_number + 1) + rand.NextDouble();
    }
    return array;
}

int PositiveNumbersSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int NegativeNumbersSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[] array = MakeArray(-5, 9, 12);
PrintArray(array);
Console.WriteLine(PositiveNumbersSum(array));
Console.WriteLine(NegativeNumbersSum(array));

// 34. Написать программу замену элементов массива на противоположные
Console.WriteLine("34. Написать программу замену элементов массива на противоположные");
int[] OppositeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] - array[i] * 2;
    }
    return array;
}

array = MakeArray(-5, 15, 12);
PrintArray(array);
PrintArray(OppositeArray(array));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 
Console.WriteLine("35. Определить, присутствует ли в заданном массиве, некоторое число ");
bool IsNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

array = MakeArray(-5, 15, 12);
PrintArray(array);
Console.WriteLine(IsNumberInArray(array, 15));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел");
int EvenNumbers(int[] array)
{
    int even_numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even_numbers++;
    }
    return even_numbers;
}

int OddNumbers(int[] array)
{
    int odd_numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) odd_numbers++;
    }
    return odd_numbers;
}

array = MakeArray(100, 999, 12);
PrintArray(array);
Console.WriteLine($"Кол-во четных чисел: {EvenNumbers(array)}");
Console.WriteLine($"Кол-во нечетных чисел: {OddNumbers(array)}");
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
array = MakeArray(0, 999, 123);
PrintArray(array);
int FindBetween(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] <= 99) && (array[i] >= 10)) count++;
    }
    return count;
}
Console.WriteLine(FindBetween(array));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("38. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
array = MakeArray(0, 999, 15);
PrintArray(array);
int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}
Console.WriteLine(SumOddPositions(array));

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
array = MakeArray(0, 10, 7);
PrintArray(array);
int[] MultiPair(int[] array)
{
    int[] mult_array = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        mult_array[i] = array[i] * array[array.Length - i - 1];
    }
    return mult_array;
}
PrintArray(MultiPair(array));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");

double[] array_float = MakeDoubleArray(0, 10, 8);
PrintDoubleArray(array_float);
double DifMinMax(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

Console.WriteLine(DifMinMax(array_float));


// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("41. Выяснить являются ли три числа сторонами треугольника");
//насколько понимаю, что каждая из сторон должна быть не больше суммы двух других.
bool IsSidesOfTriangle(int a, int b, int c)
{
    if ((a > b + c) || (b > a + c) || (c > b + a)) return false;
    return true;
}
Console.WriteLine(IsSidesOfTriangle(4, 3, 5));

// 42. Определить сколько чисел больше 0 введено с клавиатуры
// Console.WriteLine("42. Определить сколько чисел больше 0 введено с клавиатуры");
// int CountOverZero(int times)
// {
//     int number, count = 0;
//     for (int i = 0; i < times; i++)
//     {
//         number = Convert.ToInt32(Console.ReadLine());
//         if (number > 0) count++;
//     }
//     return count;
// }
// Console.WriteLine(CountOverZero(5));

// 43. Написать программу преобразования десятичного числа в двоичное
// Console.WriteLine("43. Написать программу преобразования десятичного числа в двоичное");
// Console.Write("Введите число для преобразования: ");
// int number = Convert.ToInt32(Console.ReadLine());
// //Первый вариант
// Console.WriteLine(Convert.ToString(number, 2));
// //Второй вариант
// byte[] GetBinaryNumber(int number)
// {
//     int div = number, i = 0;
//     while (div > 0)
//     {
//         div /= 2;
//         i++;
//     }
//     byte[] bit_number = new byte[i];
//     div = number;
//     while (div > 0)
//     {
//         i--;
//         bit_number[i] = Convert.ToByte(div % 2);
//         div /= 2;        
//     }
//     return bit_number;
// }

// byte[] bit_number = GetBinaryNumber(number);
// for (int i = 0; i < bit_number.Length; i++)
// {
//     Console.Write(bit_number[i] + "");
// }

// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
Console.WriteLine("44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы");
double[] CrossPoint(int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] { x, y };
}
double[] point = CrossPoint(2, 7, 4, 5);
Console.WriteLine($"X= {point[0]}, Y= {point[1]}");
// 45. Показать числа Фибоначчи
Console.WriteLine("45. Показать числа Фибоначчи");
int[] GetFibonachi(int size)
{
    if (size < 2) size = 2;
    int[] fib_array = new int[size];
    fib_array[0] = 1;
    fib_array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        fib_array[i] = fib_array[i - 1] + fib_array[i - 2];
    }
    return fib_array;
}
PrintArray(GetFibonachi(10));
//Вариант с рекурсией
Console.WriteLine("45. Показать числа Фибоначчи. Вариант с рекурсией");
void FibRecur(int a, int b, int limit)
{
    if (a + b < limit)
    {
        Console.Write(a + b + " ");
        FibRecur(b, a + b, limit);
    }
}
Console.Write("1 1 ");
FibRecur(1, 1, 2000);

// 46. Написать программу масштабирования фигуры
void ChangeScale()
{

}
// 47. Написать программу копирования массива
int[] CopyArray(int[] array)
{
    int[] array_copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array_copy[i] = array[i];
    }
    return array_copy;
}