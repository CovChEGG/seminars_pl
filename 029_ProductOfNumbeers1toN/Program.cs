// 29. Написать программу вычисления произведения чисел от 1 до N
int ReadInt(string msg) //---запрос и проверка введёных симвоолов--------------------------
{                       // Выводит сообщение переданное на входе, осуществляет  
    int valueInt;       // ввод корректного числа (можно и ограничить ввод высотой консоли),  
    while (true)        // на выходе выдаёт значение в целых числах.
    {
        Console.Write(msg + $": ");
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}
// double Factorial(int f) //проверка первых вариантов факториала не требующих вычислений
// {
//     if (f == 0) return 0;
//     if (f == 1) return 1;
//     if (f == 1 || f == 2) return f;
//     return Product(2, f);
// }
// double Product(int Left, int Right) //рекурсивная функция
// {                                   //разбиения и произведения левой и правой 
//     if (Left > Right) return 1;     //части ряда последовательных чисел (длинная арифметика)
//     if (Left == Right) return Left;
//     if ((Right - Left) == 1) return (double)Left * Right;
//     int Middle = (Left + Right) / 2;
//     return Product (Left, Middle) * Product (Middle + 1, Right);
// }
// Console.WriteLine("Product of numbers from 1 to N is: {0}",Factorial(ReadInt("Input nuber N")));

// double FactorialFor(int f)
// {
//     double F=1;
//     for (int i = 2; i <= f; i++) F *= i;
//     return F;
// }
// Console.WriteLine("Product of numbers from 1 to N is: {0}",FactorialFor(ReadInt("Input nuber N")));

double FactRec(double range)
{
    if (range <= 1) return 1;
    return FactRec(range-1) * range;
}
Console.WriteLine("Product of numbers from 1 to N is: {0}",FactRec(ReadInt("Input nuber N")));