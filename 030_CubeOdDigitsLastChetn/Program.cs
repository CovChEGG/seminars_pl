// 30. Показать кубы чисел, заканчивающихся на четную цифру

int ReadInt(string msg) //---запрос и проверка введёных симвоолов--------------------------
{                       // Выводит сообщение переданное на входе, осуществляет  
    int valueInt;       // ввод корректного числа (можно и ограничить ввод высотой консоли),  
    while (true)        // на выходе выдаёт значение в целых числах.
    {
        Console.Write(msg + $": ");
        string? valueString = Console.ReadLine();
        if (int.TryParse(valueString, out valueInt)) break;
        else Console.WriteLine("Incorrect input for int, try again...");
    }
    return valueInt;
}
int n = ReadInt("Input last number");
Console.WriteLine("Число\t| Куб числа");

for (int i = 2; i <= n; i += 2)
{
    Console.WriteLine("{0}\t|\t{1}", i, i * i * i);
}