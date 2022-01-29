// 46. Написать программу масштабирования фигуры
// 
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// 



Console.Clear();
Console.Write("Input Fugure Coordinates thrue spaces: ");
string coordinatesStr = Console.ReadLine();
var coordArray = coordinatesStr.Split(new char[] { ',', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

Printarray(coordArray);

Console.WriteLine();
Console.Write("Input multiplier: ");
int multi = Convert.ToInt32(Console.ReadLine());

int[] result = new int[coordArray.Length];
for (int i = 0; i < coordArray.Length; i++)
{
    result[i] = Convert.ToInt32(coordArray[i]);
    result[i] *= multi;
}

PrintarrayInt(result);

void PrintarrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}


void Printarray(string[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

