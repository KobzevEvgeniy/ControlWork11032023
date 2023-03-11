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

string [] FindWord (string [] basicText)
{
    int count = 0;
    int size = 0;
    for (int i = 0; i < basicText.GetLength(0); i++)
    {
        if (basicText[i].Length <=3){
            count++;
        }
    }
    string [] finalArray = new string [count];
    for (int i = 0; i < basicText.GetLength(0); i++)
    {
        if (basicText[i].Length <=3)
        {
            finalArray[size] = basicText[i];
            size++;
        }
    }
    return finalArray;
}
