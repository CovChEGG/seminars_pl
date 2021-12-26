//21. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
int ReadInt(string msg)
{
    Console.Write(msg);
    string? valueString = Console.ReadLine();
    int valueInt = int.Parse(valueString);
    return valueInt;
}

int X = ReadInt("Input x: ");
int Y = ReadInt("Input y: ");



if( (Y > 0) && (X > 0)) Console.WriteLine("Первая четверть");
else if( (Y > 0) && (X < 0)) Console.WriteLine("Вторая четверть");
else if( (Y < 0) && (X < 0)) Console.WriteLine("Третья четверть");
else if( (Y < 0) && (X > 0)) Console.WriteLine("Четвертая четверть");
else Console.WriteLine("Точка находится как минимум на одной из осей");

