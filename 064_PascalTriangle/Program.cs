// 64. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void CalcLines(int[] line, int n)
{
    int[] nextLine = new int[line.Length + 1];
    nextLine[0] = line[0];
    nextLine[line.Length] = line[line.Length - 1];
    for (int i = 0; i < (line.Length - 1); i++)
    {
        nextLine[i + 1] = line[i] + line[i + 1];
    }

    PrintLine(nextLine);
    n = n - 1;
    if (n > 1) CalcLines(nextLine, n);
}

void PrintLine(int[] line)
{
    string lineString = ($" {line[0]}");
    for (int i = 1; i < line.Length; i++)
    {
        lineString = lineString + $" {line[i]}";
    }
    int horisontalCenterPosition = (Console.BufferWidth - lineString.Length) / 2;
    int verticalPosition = line.Length;
    if (horisontalCenterPosition < 0)
    {
        Console.WriteLine("Больше не возможно вывести, не хватает ширины консоли");
        Environment.Exit(1);
    }
    Console.SetCursorPosition(horisontalCenterPosition, verticalPosition);
    Console.WriteLine(lineString);
}

int pyramidHeight = 40;

Console.Clear();
int[] firstLine = { 1 };
PrintLine(firstLine);
CalcLines(firstLine, pyramidHeight);