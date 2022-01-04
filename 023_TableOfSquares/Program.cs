// Показать таблицу квадратов чисел от 1(0 - красивее) до N 

// Console.WriteLine("{0,10}   |{1,10}", x,y); 10 - количество отступов
// Console.SetCursorPosition(xa, ya);
Console.Clear();

int ReadIntCH(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (с проверкой на высоту буфера консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        // if (int.TryParse(valueString, out valueInt) && (valueInt < 100000)) break;
        if (int.TryParse(valueString, out valueInt) && (valueInt < 100000)) //проверка соответствия
        {                                                                   //введёного числа
            if (valueInt < (Console.BufferHeight * 10 - 10)) break;         //высоте консоли
            else
            {
                Console.WriteLine("Incorrect input - small size of console, try less number...");
            }
        }


        else Console.WriteLine("Incorrect input, try again...");
    }
    return valueInt;
}

int n = ReadIntCS("Input number N: ");  //предельное число для вычилсения

// Console.WriteLine($"Current buffer size: {Console.BufferWidth}x{Console.BufferHeight}");
// Console.BufferHeight = 1000; //для Windows только!!! - для создания большей высоты в консоли

Console.Clear();
int i;
int j;
int k = 8; //отступ между колонками
for (j = 0; (j < 10) & (j <= n); j++) //подписи столбцов с единицами по горизонтали
{
    Console.SetCursorPosition(j * k + k, 0);
    Console.Write(j);
}
i = 0; //начальное значение десятков
j = 1; //начальное значение отсчёта едениц - по условию оно равно 1 (но красивее и правильнее с 0)
while ((i * 10 + j) <= n)
{
    Console.SetCursorPosition(j, i + 1);  // вывод десятков 
    Console.Write(i * 10);                // в первом столбце
    while (((i * 10 + j) <= n) && (j < 10))
    {
        Console.SetCursorPosition(j * k + k, i + 1);
        Console.Write((i * 10 + j) * (i * 10 + j));
        j++;
    }
    i++;
    j = 0;
}
Console.WriteLine();
//s += ($"{i,5}^2 = {i*i}") - суммирует в строку
