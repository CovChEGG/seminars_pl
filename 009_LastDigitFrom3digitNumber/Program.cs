Console.Write("Input 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of digit: ");
int digit = Convert.ToInt32(Console.ReadLine());

// 
for (int i = 1; i < digit; i++)
{
    number = number / 10;
}
number = number % 10;

Console.WriteLine($"Number is: {number} ");