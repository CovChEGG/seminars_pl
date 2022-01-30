// 74.Некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
int charsInWords = 3;
FindWords("аисв", new char[charsInWords], 0);

void FindWords(string alphabet, char[] word, int lenght)
{
    if (lenght == word.Length)
    {
        Console.WriteLine(new String(word));
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
}