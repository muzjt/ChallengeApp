double number = 10981923130;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
List<int> allNumbers = new List<int>(10);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);
allNumbers.Add(0);

Console.WriteLine($"Wyniki dla liczby: {numberInString}");
foreach (char character in letters)
{
    int index = (int)Char.GetNumericValue(character);
    if (character == '0')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }
    else if (character == '1')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '2')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '3')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '4')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '5')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '6')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '7')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '8')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }else if (character == '9')
    {
        allNumbers[index]++;
        Console.WriteLine($"Ilosc cyfr '{character}': {allNumbers[index]}");
    }
};




