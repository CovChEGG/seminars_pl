// 24. Найти кубы чисел от 1 до N
// Console.WriteLine("{0,10}   |{1,10}", x,y); 10 - количество отступов
// Console.SetCursorPosition(xa, ya);
Console.Clear();

int ReadIntCH(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (можно и ограничеить ввод высотой консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        // if (int.TryParse(valueString, out valueInt) && (valueInt < 100000)) break;
        if (int.TryParse(valueString, out valueInt)) break;
        // {                                                               //проверка соответствия
        // if (valueInt < (Console.BufferHeight * 10 - 20)) break;     //введёного числа
        // else                                                        //высоте консоли
        // {
        //     Console.WriteLine("Incorrect input - small size of console, try  input less number...");
        //     Console.WriteLine($"Maximum N for this console is {Console.BufferHeight * 10 - 21}");
        // }
        // }
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}

int n = ReadIntCH("Input number N: ");  //предельное число для вычилсения

Console.Clear();

if (n < (Console.BufferHeight * 10 - 20)) PrintTable(n, 10);
else PrintColumn(n);


void PrintColumn(double nc)
{
    for (double i = 1; i <= nc; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
        if ((i % 10) == 0) Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintTable(int nt, int k) //печать в виде таблицы
{
    int i;
    int j;
    for (j = 0; (j < 10) & (j <= nt); j++) //подписи столбцов с единицами по горизонтали
    {
        Console.SetCursorPosition(j * k + k, 0);
        Console.Write(j);
    }
    i = 0; //начальное значение десятков
    j = 1; //начальное значение отсчёта едениц - по условию оно равно 1 (но красивее и правильнее с 0)
    while ((i * 10 + j) <= nt)
    {
        Console.SetCursorPosition(j, i + 1);  // добавляет подпись десятков 
        Console.Write(i * 10);                // по вертикали (первый столбец)
        while (((i * 10 + j) <= n) && (j < 10))
        {
            Console.SetCursorPosition(j * k + k, i + 1);
            Console.Write((i * 10 + j) * (i * 10 + j) * (i * 10 + j));
            j++;
        }
        i++;
        j = 0;
    }
    Console.WriteLine();
}
