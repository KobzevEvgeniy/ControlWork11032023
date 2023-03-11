Console.Clear();
Console.WriteLine("Введите слова через пробел: ");
string el = Console.ReadLine();




string[] BaseArray(string stringArray)
{
    string[] word = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[word.Length];

    for (int i = 0; i < word.Length; i++)
    {
        result[i] = Convert.ToString(word[i]);
    }
    return result;
}
