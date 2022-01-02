// 22. Найти расстояние между точками в пространстве 2D/3D
int[] firstPoint = { -2, -2, -2 }; //x1, y1, z1
int[] secondPoint = { 2, 2, 2 }; //x2, y2, z2
double Hypotenuse(double a, double b) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); //квадратный корень из суммы квадратов катетов;
double xy = Hypotenuse(secondPoint[0] - firstPoint[0], secondPoint[1] - firstPoint[1]);
double xz = Hypotenuse(secondPoint[0] - firstPoint[0], secondPoint[2] - firstPoint[2]);
double yz = Hypotenuse(secondPoint[1] - firstPoint[1], secondPoint[2] - firstPoint[2]);
double xyz = Hypotenuse(xy, secondPoint[2] - firstPoint[2]);
Console.WriteLine($"Растояение в плоскости XY: {xy}");
Console.WriteLine($"Растояение в плоскости XZ: {xz}");
Console.WriteLine($"Растояение в плоскости YZ: {yz}");
Console.WriteLine($"Расстояние в пространстве XYZ: {xyz}");


// округление
//Math.Round(число, кол-во знаков)
