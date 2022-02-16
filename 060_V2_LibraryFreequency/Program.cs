// 060. Составить частотный словарь элементов двумерного массива
// Число 1 встречаетсся 38 раз. Частота 11.38%

void FillTwoDimArray(int[,] array, int minNumber, int maxNumber)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] ConvertToSimpleArray(int[,] arrayTwoDims)
{
    int i = -1;
    int[] simpleArray = new int[arrayTwoDims.GetLength(0) * arrayTwoDims.GetLength(1)];
    foreach (var item in arrayTwoDims)
    {
        i++;
        simpleArray[i] = item;
    }
    return simpleArray;
}

void PreSortingSimpleArray(int[] array)
{
    int lastIndex = array.Length;
    int tmp;
    int swap = 0;
    int i = 1;
    while (true)
    {
        swap = 0;
        for (i = 1; i < lastIndex; i++)
            if (array[i - 1] < array[i])
            {
                tmp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = tmp;
                swap = 1;
            }
        if (swap == 0) break;
        lastIndex--;
    }
}

int[,] FindInfoAboutElements(int[] array)
{
    int i;
    int numberOfUniqueElement = 1;
    int[] uniqueElementsArray = new int[] { array[0] };
    uniqueElementsArray[0] = array[0];
    int[] uniqueElementsQuantityArray = new int[] { 1 };

    for (i = 1; i < array.Length; i++)
    {
        if (array[i - 1] == array[i])
        {
            uniqueElementsQuantityArray[numberOfUniqueElement - 1]++;
        }
        else
        {
            numberOfUniqueElement++;
            Array.Resize(ref uniqueElementsArray, numberOfUniqueElement);
            uniqueElementsArray[numberOfUniqueElement - 1] = array[i];
            Array.Resize(ref uniqueElementsQuantityArray, numberOfUniqueElement);
            uniqueElementsQuantityArray[numberOfUniqueElement - 1] = 1;
        }
    }
    int[,] resultArray = new int[numberOfUniqueElement, 2];
    for (i = 0; i < numberOfUniqueElement; i++)
    {
        resultArray[i, 0] = uniqueElementsArray[i];
        resultArray[i, 1] = uniqueElementsQuantityArray[i];
    }
    return resultArray;
}

void SortingArray(int[,] array, int sortingBy = 0)    // 0 - sorting by Numbers (by default), 
{                                                     // 1 - sorting by Frequency.
    if (sortingBy == 0 || sortingBy == 1)
    {
        // if (sortingBy == 1) SortingArray(array, 0);   // sorting by Numbers before sorting by Frequency
        int minElement = 0;
        int minQuantity = 0;
        int lastElement = array.GetLength(0);
        int swap;
        while (true)
        {
            swap = 0;
            for (int i = 1; i < lastElement; i++)
            {
                if (array[i - 1, sortingBy] < array[i, sortingBy])
                {
                    minElement = array[i - 1, 0];
                    minQuantity = array[i - 1, 1];
                    array[i - 1, 0] = array[i, 0];
                    array[i - 1, 1] = array[i, 1];
                    array[i, 0] = minElement;
                    array[i, 1] = minQuantity;
                    swap = 1;
                }
            }
            if (swap == 0) break;
            lastElement--;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Wrong sortingBy second parameter!!! Program will stop!");
        Console.WriteLine("Send second argument to method 'SortingArray' 0 or 1 only (or without this element!");
        Console.WriteLine("'0' - for sorting by Numbers (by default, if no input), '1' - by Frequency");
        Console.WriteLine();
        Environment.Exit(1);
    }
}

bool CheckingLastDigitsForRuLnangExeption(int number)
{
    string numberInString = Convert.ToString(number);
    int numberOfDigits = numberInString.Length;
    if (numberOfDigits >= 2)
    {
        int beforeLastDigitInNumber = Convert.ToInt16(numberInString[numberOfDigits - 2]) - 48; // - Convert.ToInt16('0');
        if (beforeLastDigitInNumber == 1) return false;
    }
    int lastDigitInNumber = Convert.ToInt16(numberInString[numberOfDigits - 1]) - 48; // - Convert.ToInt16('0');
    if (lastDigitInNumber >= 2 && lastDigitInNumber < 5) return true;
    return false;
}

void FormatedPrint(int[,] array, double numberOfElements)
{
    string msg234 = "раза";
    string msgAll = "раз";
    string endOfMsg = string.Empty;
    double quontity;
    double frequency;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string str = Convert.ToString(array[i, 1]);
        if (CheckingLastDigitsForRuLnangExeption(array[i, 1])) endOfMsg = msg234;
        else endOfMsg = msgAll;
        Console.Write($"Число {array[i, 0]} встречается {array[i, 1]} {endOfMsg}. ");
        quontity = array[i, 1];
        frequency = 100 * quontity / numberOfElements;
        Console.Write($"Частота {frequency:N2}%");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
DateTime now = DateTime.Now;
int rows = 15;
int columns = 13;
int minRnd = 145;
int maxRnd = 150;
int sortingParam =0; // 0 - sorting by Numbers, 1 - sorting by Frequency
int[,] workArray = new int[rows, columns];
FillTwoDimArray(workArray, minRnd, maxRnd);
PrintTwoDimArray(workArray);
int[] simpleArray = ConvertToSimpleArray(workArray);
PreSortingSimpleArray(simpleArray);
int[,] elementsAndQuontity = FindInfoAboutElements(simpleArray);
SortingArray(elementsAndQuontity, sortingParam);
FormatedPrint(elementsAndQuontity, rows * columns);
Console.WriteLine(DateTime.Now - now);
