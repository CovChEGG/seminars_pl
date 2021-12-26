Console.WriteLine("Input day of the Week: ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day > 0) && (day < 8))
{
    if (day > 5) Console.Write("This day is a holiday");
    else Console.Write("This day is'nt holiday");
}
else Console.Write("It's a wrong number");