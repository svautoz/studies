// Console.Clear();
// char glif = 'a';
// while (glif <= 'z')
// {
//     Console.WriteLine(glif++);
// }


// 23. Показать таблицу квадратов чисел от 1 до N 
void ShowSquareTable(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write(i * i + " ");
    }
}

//ShowSquareTable(15);

// 24. Найти кубы чисел от 1 до N
void ShowCubeTable(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
// ShowCubeTable(10);

// 25. Найти сумму чисел от 1 до А
Console.WriteLine("25. Найти сумму чисел от 1 до А");
int GetCount(int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
        result += i;
    }
    return result;
}
if (GetCount(5) == 15)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}
if (GetCount(4) != 8)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}
if (GetCount(6) == 21)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

// 26. Возведите число А в натуральную степень B используя цикл
Console.WriteLine("26. Возведите число А в натуральную степень B используя цикл");
double RaseAToDegreeB(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

if (RaseAToDegreeB(2, 3) == 8)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (RaseAToDegreeB(2, 4) != 8)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (RaseAToDegreeB(7, 2) == 49)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}


// 27. Определить количество цифр в числе
Console.WriteLine("27. Определить количество цифр в числе");
int CountDigit(int number)
{
    string str_num = number.ToString();
    return str_num.Length;
}

if (CountDigit(456) == 3)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (CountDigit(45643) == 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (CountDigit(4564) != 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

// 28. Подсчитать сумму цифр в числе
Console.WriteLine("28. Подсчитать сумму цифр в числе");
int CountDigitNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

if (CountDigitNumber(456) == 15)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (CountDigitNumber(45643) == 22)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (CountDigitNumber(4564) != 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

// 29. Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("29. Написать программу вычисления произведения чисел от 1 до N");
int GetMulti(int N)
{
    int sum = 1;
    for (int i = 1; i <= N; i++)
    {
        sum *= i;
    }
    return sum;
}
if (GetMulti(4) == 24)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}
if (GetMulti(5) == 120)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (GetMulti(4564) != 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (GetMulti(4564) != 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}


// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("30. Показать кубы чисел, заканчивающихся на четную цифру");
double GetCubeEvenNumber(int number)
{
    if (number % 10 % 2 == 0)
    {
        return Math.Pow(number, 3);
    }
    else
    {
        return 0;
    }
}

if (GetCubeEvenNumber(3) == 0)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (GetCubeEvenNumber(22) != 8)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (GetCubeEvenNumber(4) == 64)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}

if (GetCubeEvenNumber(4564) != 5)
{
    Console.WriteLine("Все ок");
}
else
{
    Console.WriteLine("Есть проблема");
}
