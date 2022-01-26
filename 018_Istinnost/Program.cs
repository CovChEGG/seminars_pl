// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.Clear();
bool[] valueX = { false, true };
bool[] valueY = { false, true };

for (int i = 0; i < valueX.Length; i++)
{
    for (int j = 0; j < valueY.Length; j++)
    {
        bool leftPart = (!(valueX[i] || valueY[j]));
        bool rightPart = ((!valueX[i]) && (!valueY[j]));
        bool result = ( leftPart == rightPart );

        Console.WriteLine($"! ({valueX[i]}  ||  {valueY[j]}) \t==    ! {valueX[i]}  &&  ! {valueY[j]}\tis {result}   \t({leftPart} == {rightPart})");
    }
}