//21. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
int ReadInt(string msg)
{
    Console.Write(msg);
    string? valueString = Console.ReadLine();
    int valueInt = Convert.ToInt32(valueString);
    return valueInt;
}

int x = ReadInt("Input x: ");
int y = ReadInt("Input y: ");



if( (y > 0) && (x > 0)) Console.WriteLine("Первая четверть");
else if( (y > 0) && (x < 0)) Console.WriteLine("Вторая четверть");
else if( (y < 0) && (x < 0)) Console.WriteLine("Третья четверть");
else if( (y < 0) && (x > 0)) Console.WriteLine("Четвертая четверть");
else Console.WriteLine("Точка находится как минимум на одной из осей!!!");

