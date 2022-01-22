//Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите числа через пробел");
string str = Console.ReadLine();
Console.WriteLine();
int[] ArrayNum = StringToNumbers(str);
Console.WriteLine($"Количество чисел больше 0: {PositiveNumbers(ArrayNum)}");

int[] StringToNumbers(string str)
{
    string[] tmp = str.Split(" ");
    int len = tmp.Length;
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = Convert.ToInt32(tmp[i]);
    }
    return res;
}

int PositiveNumbers(int[] array)
{
    int tmp = 0;
    foreach (int item in array)
    {
        if (item > 0) tmp++;
    }
    return tmp;
}