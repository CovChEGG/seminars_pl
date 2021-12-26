Console.WriteLine("Input 3-digit number: ");

try
{
    int value = int.Parse(Console.ReadLine() ?? "");
    if ((value >=100) && (value < 1000))
    {
        int temp = value % 10;
        int temp1 = value/ 100 * 10;
        Console.Write(temp1+temp);
    }
    else
    {
        throw new FormatException ();
    }
}
catch (FormatException)
{
    Console.WriteLine("Incorrect input!");
}
