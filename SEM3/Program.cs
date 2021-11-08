//Вывести квадрат числа
int Square(int x)
{
    return x * x;
}

//Console.WriteLine(Square(5));

//По двум введённым числам проверять является ли первое квадратом второго
bool IsSquare(int x, int y)
{
    if (x == y * y) return true;
    else
        return false;
}

//Console.WriteLine(IsSquare(25, 15));

//Даны два числа. Показать большее и меньшее число
int ShowLess(int x, int y)
{
    if (x < y) return x;
    else
        return y;
}
int ShowBiggest(int x, int y)
{
    if (x > y) return x;
    else
        return y;
}

//Console.WriteLine(ShowLess(25, 15));
//Console.WriteLine(ShowBiggest(25, 15));

//По введенному номеру дня недели вывести его название
string DayName(int number)
{
    if (number == 1) return "Понедельник";
    if (number == 2) return "Вторник";
    if (number == 3) return "Среда";
    if (number == 4) return "Четверг";
    if (number == 5) return "Пятница";
    if (number == 6) return "Суббота";
    if (number == 7) return "Воскресенье";
    return "Неправильно указано число";
}

//Console.WriteLine(DayName(3));

//Найти максимальное из трех чисел
int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

//Console.WriteLine(Max(new int[]{43, 55, 77}));

//Написать программу вычисления значения функции y=f(a)
int F(int a)
{
    return a + 1;
}
int a = 10;
int y = F(a);
//Console.WriteLine(y);

// 6. Выяснить является ли число чётным
bool IsEven(int x)
{
    if (x % 2 == 0) return true;
    return false;
}
//Console.WriteLine(IsEven(14));

// 7. Показать числа от -N до N
void ShowN(int N)
{
    for (int i = -N; i <= N; i++) Console.WriteLine(i);
}

//ShowN(9);

//  8. Показать четные числа от 1 до N
void ShowEven(int N)
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);

    }
}
//ShowEven(13);
//  9. Показать последнюю цифру трёхзначного числа
void ShowLast(int number)
{
    Console.WriteLine(number % 10);
}

//ShowLast(457);
// 10. Показать вторую цифру трёхзначного числа
void ShowSecond(int number)
{
    Console.WriteLine(number / 10 % 10);
}

//ShowSecond(44537);

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int GetBiggestNumber(int number)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    if (firstNumber > secondNumber)
        return firstNumber;
    else
        return secondNumber;
}
//Console.WriteLine(GetBiggestNumber(57));

// 12. Удалить вторую цифру трёхзначного числа
void DeleteSecondNumber(int number)
{
    Console.WriteLine((number / 100) * 10 + (number % 10));
}
//DeleteSecondNumber(759);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
void IsMultiple(int number, int divider)
{
    int result = number % divider;
    if (result == 0)
        Console.WriteLine($"Число {number} делиться на {divider} без остатка.");
    else
        Console.WriteLine($"Остаток: {result}");
}
//IsMultiple(15, 5);

// 14. Найти третью цифру числа или сообщить, что её нет
void FindThirdNumber(int number)
{
    int result = Math.Abs(number / 100 % 10);
    if (result == 0)
        Console.WriteLine("Третьей цифры нет.");
    else
        Console.WriteLine(result);
}
//FindThirdNumber(0);

// 15. Дано число. Проверить кратно ли оно 7 и 23
bool IsMultipleSevenAndTwentyThree(int number)
{
    if ((number % 7 == 0) && (number % 23 == 0))
        return true;
    else
        return false;
}
// if (IsMultipleSevenAndTwentyThree(161))
//     Console.WriteLine("Делиться");
// else
//     Console.WriteLine("Не делиться");

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
bool IsWeekend(int number)
{
    if ((number == 6) || (number == 7))
        return true;
    else
        return false;
}
// if (IsWeekend(6))
//     Console.WriteLine("Выходной");
// else
//     Console.WriteLine("Будни");

// 17. По двум заданным числам проверять является ли одно квадратом другого
bool IsSquare(int x, int y)
{
    if (x == y * y)
        return true;
    else
        return false;
}
// if (IsSquare(25, 5))
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("нет");

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool CheckStatement(bool X, bool Y)
{
    if (!(X || Y) == (!X && !Y))
        return true;
    else
        return false;
}
// if (CheckStatement(false, false) && CheckStatement(true, false) && CheckStatement(false, true) && CheckStatement(true, true))
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("нет");

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int Quarter(int x, int y)
{
    if (x < 0 && y < 0) return 4;
    if (x < 0 && y > 0) return 1;
    if (x > 0 && y > 0) return 2;
    if (x > 0 && y < 0) return 3;
    return 0;
}
// Console.WriteLine(Quarter(-3, 7));

// 20. Задать номер четверти, показать диапазоны для возможных координат
string QuaterRange(int quarter)
{
    string[] range = new string[] { "X in (-inf, 0); Y in (0, +inf)", "X in (0, +inf); Y in (0, +inf)", "X in (0, +inf); Y in (-inf, 0)", "X in (-inf, 0); Y in (-inf, 0)" };
    return range[quarter - 1];
}
// Console.WriteLine(QuaterRange(3));

// 21. Программа проверяет пятизначное число на палиндромом.
bool IsPalendrom(int number)
{
    string num_str = Convert.ToString(number);
    int length = num_str.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (num_str[i] != num_str[length - i - 1]) return false;
    }
    return true;
}
// Console.WriteLine(IsPalendrom(12121));

// 22. Найти расстояние между точками в пространстве 2D/3D
double GetDistance(int dim, int[] point_1, int[] point_2)
{
    double sum = 0;
    for (int i = 0; i < dim; i++)
    {
        sum += Math.Pow(point_1[i] - point_2[i], 2);
    }
    return Math.Sqrt(sum);
}
Console.WriteLine(GetDistance(3, new int[] { 3, 6, 98 }, new int[] { 54, 3, 2 }));