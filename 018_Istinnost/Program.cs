// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool[] value1 = { false, true };
bool[] value2 = { false, true };

for (int i = 0; i < value1.Length; i++)
{
    for (int j = 0; j < value2.Length; j++)
    {
        bool temp1 = (!(value1[i] || value2[j]));
        bool temp2 = ((!value1[i]) && (!value2[j]));
        bool tmp = ( temp1 == temp2 );

        Console.WriteLine($"! ({value1[i]} || {value2[j]}) == !{value1[i]} && !{value2[j]} is {tmp}   {temp1} {temp2}");
    }
}