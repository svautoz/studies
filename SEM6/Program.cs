// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
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
Console.WriteLine("37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел");
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива