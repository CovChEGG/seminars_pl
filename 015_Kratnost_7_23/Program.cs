// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0)) Console.Write("Число кратно 7 и 23");
else Console.Write("Условие кратности нарушено!!!");

