// Написать программу копирования массива

int EntryNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number;   
}

int[] CreateArray(int length, int minimal, int maximum)
{
    int[] array = new int [length];
    var random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minimal, maximum + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return array;
}

void PrintArray(string text, int[] array)
{
    Console.WriteLine(text);
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

Console.Clear();
int length = EntryNumber("Enter length of array ");
int minimal = EntryNumber("Enter minimal number of array ");
int maximum = EntryNumber("Enter maximal number of array ");

int[] array = CreateArray(length, minimal, maximum);
int[] copyArray = CopyArray(array);

Console.WriteLine();
PrintArray("Array:", array);
PrintArray("Copy of array:", copyArray);