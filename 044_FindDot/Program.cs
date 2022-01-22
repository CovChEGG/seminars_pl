// 44. Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
//  https://www.interestprograms.ru/source-codes-tochka-peresecheniya-dvuh-pryamyh-na-ploskosti
// Если k1 = k2, то прямые параллельны!!! Если k различны, то прямые будут пересекаться
// Если b1 = b2, то прямые пересекаются в точке

if(k1 != k2) // исключение параллельности прямых
{
    x = (b1 - b2) / (k2 - k1);
    y = k1 * x +b1;
    //координаты пересечения прямых
}


// Console.WriteLine("Даны две прямые, заданные уравнением y = k1 * x + b1, y = k2 * x + b2: "); 
// Console.WriteLine("Введите угловой коэффициент k1 "); 
// int k1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите величину отрезка b1 "); 
// double b1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите угловой коэффициент k2 "); 
// double k2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите величину отрезка b2 "); 
// double b2 = Convert.ToInt32(Console.ReadLine()); 
// double x = 0; 
// double y = 0; 
 
// if(k1 != k2) //исключение параллельности прямых 
// { 
//  x = (b1 - b2) / (k2 - k1); 
//  y = k1 * x + b1; 
//  Console.WriteLine($"Координаты точки пересечения прямых: x '{x}' , y '{y}' "); 
// } 
// else 
// { 
//  Console.WriteLine("Прямые не пересекаются "); 
// }