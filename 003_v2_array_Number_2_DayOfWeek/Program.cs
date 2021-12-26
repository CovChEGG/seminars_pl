Console.WriteLine("Input a number of the day of the week =>");
string valueString = Console.ReadLine() ?? "";
int valueInt = int.Parse(valueString);
string[] NameOfDays = { "Monday", "Tuesday", "Wednesday", "Thusday", "Friday", "Saturday", "Sunday" };
if ((0 < valueInt) & (valueInt < 8))
{
    Console.WriteLine(NameOfDays[valueInt - 1]);
}
else
{
    Console.WriteLine("Wrong input!!!");
}