// 45 Показать числа Фибоначчи

// ulong Fibonacchi(ulong number)
// {
//     if(number== 1 || number == 2)
//     {
//         return 1;
//     }
//     return Fibonacchi(number-1)+Fibonacchi(number-2);
// }
// Console.Clear();

ulong Fibonacchi(int number)
{
    if(number == 1 || number == 2) return 1;
    ulong num1=1;
    ulong num2=1;
    while(number>2)
    {
        ulong tmp = num1+num2;
        num1=num2;
        num2=tmp;
        --number;
    }
    return num2;
}
Console.Clear();
for(int i = 1; i <= 9 ; i++) Console.Write($"{Fibonacchi(i)} ");