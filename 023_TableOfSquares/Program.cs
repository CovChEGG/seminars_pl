// Показать таблицу квадратов чисел от 1(0 - красивее) до N 

Console.Clear();

int ReadIntCH(string msg) // Выводит сообщение переданное на входе, осуществляет
{                         // ввод корректного числа (с проверкой на высоту буфера консоли),
    int valueInt;         // на выходе выдаёт значение в целых числах.
    while (true)
    {
        Console.Write(msg);
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt) && (valueInt < 100000)) //проверка соответствия
        {                                                                   //введёного числа
            if (valueInt < (Console.BufferHeight * 10 - 20)) break;         //высоте консоли
            else
            {
                Console.WriteLine("Incorrect input - small size of console, try  input less number...");
                Console.WriteLine($"Maximum N for this height of console is {Console.BufferHeight * 10 - 21}");
            }
        }
        else Console.WriteLine("Incorrect input, try again...");
    }
    return valueInt;
}

int n = ReadIntCH("Input number N: ");  //предельное число для вычилсения

Console.Clear();
int k = 10; //отступ между колонками
for (int j = 0; (j < 10) & (j <= n); j++) //подписи столбцов с единицами по горизонтали
{
    Console.SetCursorPosition(j * k + k, 0);
    Console.Write(j);
}

for (int i = 0; i <= n; i++)
{
    if (i % 10 == 0)
    {
        Console.SetCursorPosition(0, i / 10 + 1);  // вывод десятков
        Console.Write(i);                          // в первом столбце
    }
        Console.SetCursorPosition(i % 10 * k + k, i / 10 + 1);  // заполнение
        Console.Write(i * i);                                   // по строкам
}
Console.WriteLine();