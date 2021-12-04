// ## Рекурсия
// 66. Показать натуральные числа от 1 до N, N задано
System.Console.WriteLine("66. Показать натуральные числа от 1 до N, N задано");

void ShowNaturalNumbers(int N)
{
    if (N == 0) return;
    ShowNaturalNumbers(N - 1);
    System.Console.WriteLine(N);
}

ShowNaturalNumbers(10);
System.Console.WriteLine();
// 67. Показать натуральные числа от N до 1, N задано
System.Console.WriteLine("67. Показать натуральные числа от N до 1, N задано");
void ShowReverseNaturalNumbers(int N)
{
    System.Console.WriteLine(N);
    if (N == 1) return;
    ShowReverseNaturalNumbers(N - 1);
}

ShowReverseNaturalNumbers(10);
System.Console.WriteLine();

// 68. Показать натуральные числа от M до N, N и M заданы
System.Console.WriteLine("68. Показать натуральные числа от M до N, N и M заданы");
void ShowNaturalNumbersInRange(int M, int N)
{
    if (N < M) return;
    ShowNaturalNumbersInRange(M, N - 1);
    System.Console.WriteLine(N);
}

ShowNaturalNumbersInRange(5, 20);
System.Console.WriteLine();

// 69. Найти сумму элементов от M до N, N и M заданы
System.Console.WriteLine("69. Найти сумму элементов от M до N, N и M заданы");
int GetSumInRange(int M, int N)
{
    if (M == N) return M;
    return M + GetSumInRange(M + 1, N);
}

System.Console.WriteLine(GetSumInRange(5, 7));
System.Console.WriteLine();
// 70. Найти сумму цифр числа
System.Console.WriteLine("70. Найти сумму цифр числа");

int GetSumDigitsInNumber(int number)
{
    int digit = number % 10;
    number = number / 10;
    if (digit > 0)
    {
        return digit + GetSumDigitsInNumber(number);
    }
    else
    {
        return digit;
    }
}

System.Console.WriteLine(GetSumDigitsInNumber(173));

System.Console.WriteLine();
// 71. Написать программу вычисления функции Аккермана
System.Console.WriteLine("71. Написать программу вычисления функции Аккермана");

int CalcAkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return CalcAkkermanFunction(m - 1, 1);
    return CalcAkkermanFunction(m - 1, CalcAkkermanFunction(m, n - 1));
}

System.Console.WriteLine(CalcAkkermanFunction(3, 1));

System.Console.WriteLine();
// 72. Написать программу возведения числа А в целую стень B
System.Console.WriteLine("72. Написать программу возведения числа А в целую стень B");

int GetValueInDegree(int A, int B)
{
    if (B == 0) return 1;
    return A * GetValueInDegree(A, B - 1);
}

System.Console.WriteLine(GetValueInDegree(7, 3));
System.Console.WriteLine();

// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
System.Console.WriteLine("73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем");

void PrintModifFib(int N, int first, int second)
{
    if (N == 0) return;
    int sum = first + second;
    System.Console.WriteLine(sum + " ");
    PrintModifFib(N - 1, second, sum);
}

PrintModifFib(10, 3, 5);
System.Console.WriteLine();

// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
System.Console.WriteLine("74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита");
int counter = 0;
string alphabet = "аисв", word = string.Empty;
int n = 4;

void PrintWords(string alphabet, int n, string word)
{
    if (n == 0)
    {
        System.Console.WriteLine(++counter + "  " + word);
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word += alphabet[i];
        PrintWords(alphabet, n - 1, word);
        word = word.Remove(word.Length - 1);
    }

}

PrintWords(alphabet, n, word);
System.Console.WriteLine();