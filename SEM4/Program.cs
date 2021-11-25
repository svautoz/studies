int number = 54645;
string str_num = number.ToString();
int length = str_num.Length;
for (int i = 0; i < length / 2; i++)
{
    if (str_num[i] != str_num[length - i - 1])
    {
        Console.WriteLine("Число не палиндром");        
        break;
    }
}


double GetDistance(int[] a, int[] b)
{

    double result = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2));
    return result;
}

int[] a = new[] { 1, 0, 4 };
int[] b = new[] { 0, 1, 5 };

Console.WriteLine(GetDistance(a, b));