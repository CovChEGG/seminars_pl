// Показать таблицу квадратов чисел от 1(0 - красивее) до N 

// Console.WriteLine("{0,10}   |{1,10}", x,y); 10 - количество отступов
// Console.SetCursorPosition(xa, ya);
Console.Clear();

int n = 99;
int i = 0;
int j = 0;
int k = 8; //отступ между колонками
for (; (i < 10) & (i <= n); i++) //вывод единиц по горизонтали
{
    Console.SetCursorPosition(i * k + k, 0);
    Console.Write(i);
}
i = 0;
while ((i * 10 + j) <= n)
{
    Console.SetCursorPosition(j, i + 1);  // вывод десятков
    Console.Write(i * 10);              // по вертикали
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


