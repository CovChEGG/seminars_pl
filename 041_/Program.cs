// 41. Выяснить являются ли три числа сторонами треугольника
int a,b,c;
Random rnd = new Random();
a=rnd.Next(1,10);
b=rnd.Next(1,10);
c=rnd.Next(1,10);

if(a < (b+c) && b <(a+c) && c < (a+b)) Console.WriteLine($"Числа {a}, {b}, {c} являются сторонами треугольника");
else Console.WriteLine($"Числа {a}, {b}, {c} не являются сторонами треугольника");
