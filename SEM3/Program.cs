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
int ShowMore(int x, int y)
{
    if (x > y) return x;
    else
        return y;
}

//Console.WriteLine(ShowLess(25, 15));
//Console.WriteLine(ShowMore(25, 15));

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
int f(int a)
{
    return a + 1;
}
int a = 10;
int y = f(a);
//Console.WriteLine(y);

// 6. Выяснить является ли число чётным
bool isEven(int x)
{
    if (x % 2 == 0) return true;
    return false;
}
//Console.WriteLine(isEven(14));

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

ShowSecond(44537);