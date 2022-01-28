// 39. Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. (Гаусс)

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i]=rnd.Next(min, max);
    }

}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++) Console.Write($"{array[i]} ");
}

int[] MultElement(int[] array)
{
    int len = array.Length;
    int LenResult = len%2 == 0 ? len/2 : len/2+1;  // условие
    int[] temp = new int[LenResult];
    for (int i = 0; i< LenResult; i++)
    {
        temp[i]=array[i]*array[len-1 -i];
    }
    return temp;
}

int[] array = new int[6]; // вводим количество элементов
FillArray(array, 1, 10);
PrintArray(array);
int[] arrResult = MultElement(array);
PrintArray(arrResult);