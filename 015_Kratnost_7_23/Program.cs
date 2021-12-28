// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Input number: ");
int number;
if(int.TryParse(Console.ReadLine(), out number))
{
if ((number % 7 == 0) && (number % 23 == 0)) Console.Write("Число кратно 7 и 23");
else Console.Write("Условие кратности нарушено!!!");
}
else Console.Write("Некорректный ввод");
