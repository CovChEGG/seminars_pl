// 73. Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int EnterInt(string Text) 
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

string StringNumber(int startFirst, int strtSecond, int count)
{
    if(count ==0) return string.Empty;
    count--;
    return $"{strstFirst} {StringNumbers(startSecond)}";
}

int startFirst = EnterIn("Input 1st number: ");
int startSecond = EnterIn("Input 2nd number: ");
string sum = StringNumber(startFirst, startSecond, 5);
Console.WriteLine(sum);
