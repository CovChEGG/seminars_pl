//011. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int Max(int a, int b)
{
    if (a > b) return a;
    return b;
}

Console.WriteLine();

int number = new Random().Next(10, 100);
Console.WriteLine($"Number is: {number}");

int firstDigit = number / 10;
Console.WriteLine($"First digit: {firstDigit}");

int lastDigit = number % 10;
Console.WriteLine($"Last digit: {lastDigit}");

Console.WriteLine($"Maximum digit is: {Max(firstDigit, lastDigit)}");

Console.WriteLine();

