//Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите числа через пробел (десятые доли через запятую)");
string str = Console.ReadLine() ?? string.Empty;
Console.WriteLine();
double[] ArrayNum = StringToNumbers(str);
Console.WriteLine($"Количество чисел больше 0: {CalcPositiveNumbers(ArrayNum)}");


double[] StringToNumbers(string str)
{
    string[] tmp = str.Split(" ");
    int len = tmp.Length;
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        if (double.TryParse(tmp[i], out res[i])){}
        else res[i] = 0;
    }
    return res;
}

int CalcPositiveNumbers(double[] array)
{
    int tmp = 0;
    foreach (double item in array)
    {
        if (item > 0) tmp++;
    }
    return tmp;
}