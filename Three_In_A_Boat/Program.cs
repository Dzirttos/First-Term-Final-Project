// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Console.Clear();

Console.WriteLine("Please enter desired array length:");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = FillArray(n);
ShowArray(array);
string[] newArray = ResultArray(array);
ShowResultArray(newArray);

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

string[] ResultArray(string[] firstArray)
{
    int size = 0;
    string[] secondArray = new string[size];
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            size++;
            Array.Resize(ref secondArray, size);
            secondArray[size - 1] = firstArray[i];
        }
    }
    return secondArray;
}

void ShowResultArray(string[] resultArray)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("The result array with elements shorter or equal to 3 symbols is: [ " + String.Join(", ", resultArray) + " ]");
}