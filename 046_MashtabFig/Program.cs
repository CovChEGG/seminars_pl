Console.Clear();
Console.Write("Input Fugure Coordinates thrue spaces: ");
string coordinatesStr=Console.ReadLine();
var coordArray = coordinatesStr.Split(new char[] {',', ' ', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);

Printarray(coordArray);

Console.WriteLine();
Console.Write("Input multiplier: ");
int multi=Convert.ToInt32(Console.ReadLine());

int[] result=new int[coordArray.Length];
for(int i=0; i<coordArray.Length; i++)
{
    result[i]=Convert.ToInt32(coordArray[i]);
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

