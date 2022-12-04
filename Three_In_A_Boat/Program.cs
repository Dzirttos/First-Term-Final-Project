// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Console.Clear();



string[] FillArray(int size)
{
    string[] userArray = new string[size];
    for (int j = 0; j < userArray.Length; j++)
    {
        Console.WriteLine($"Please enter array element {j + 1}:");
        userArray[j] = (Console.ReadLine());
    }
    return userArray;
}

void ShowArray(string[] userArray)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("You have created the following array: [ " + String.Join(", ", userArray) + " ]");
}