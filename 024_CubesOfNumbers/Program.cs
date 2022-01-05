// 24. Найти кубы чисел от 1 до N
//----------------functions-------------------------------------------------------
int ReadIntCH(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (можно и ограничить ввод высотой консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}
void PrintColumn(double nc)  //Вывод в столбец
{
    for (double i = 1; i <= nc; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
        if ((i % 10) == 0) Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintTable(int nt, int k) //Вывод в виде таблицы
{
    for (int j = 0; (j < 10) & (j <= nt); j++) //подписи столбцов с единицами по горизонтали
    {
        Console.SetCursorPosition(j * k + k, 0);
        Console.Write(j);
    }
    for (int i = 0; i <= nt; i++)
    {
        if (i % 10 == 0)
        {
            Console.SetCursorPosition(0, i / 10 + 1);  // вывод десятков
            Console.Write(i);                          // в первом столбце
        }
        Console.SetCursorPosition(i % 10 * k + k, i / 10 + 1);  // заполнение
        Console.Write(i * i * i);                               // по строкам
    }
    Console.WriteLine();
}
//--------------------------------------------------------------------------------
Console.Clear();
int n = ReadIntCH("Input number N: ");  //предельное число для вычилсения
Console.Clear();
if (n < (Console.BufferHeight * 10 - 20)) PrintTable(n, 10); //Вывод таблицей по высоте консоли
else PrintColumn(n);                                         //Иначе вывод в столбик