// 22. Найти расстояние между точками в пространстве 2D/3D
int[] firstPoint = { 0, 0, 1 }; //x1, y1, z1
int[] secondPoint = { 2, 2, 2 }; //x2, y2, z2
double Hypotenuse(double a, double b)
{
    return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); // квадратный корень из суммы 
};
double xy = Hypotenuse(secondPoint[0] - firstPoint[0], secondPoint[1] - firstPoint[1]);
double xy_z = Hypotenuse(xy, secondPoint[2] - firstPoint[2]);
Console.WriteLine(xy);
Console.WriteLine(xy_z);
