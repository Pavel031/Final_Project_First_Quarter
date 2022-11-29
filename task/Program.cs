Console.Clear();
int n = 3;
int size = 5;
string[] firstArray = new string[size];
Console.WriteLine($"Введите {size} элементов массива");
FillArray(firstArray);
Console.Write("Ваш массив: ");
PrintArray(firstArray);
Console.WriteLine();
if (GetArray(firstArray) == 0) 
{
    Console.WriteLine("Элементов с тремя и меньше символами нет");
}
else 
{
    Console.Write("Новый массив элементов с тремя или меньше сомволами: ");
    string[] arrayTwo = ElementsForSecondArray(firstArray);
    PrintArray(arrayTwo);
}

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    for (int i = 0; i < arrLeng; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}

int GetArray(string[] arr)
{
    int sizeTwo = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            sizeTwo++;
        }
    }
    return sizeTwo;
}
string[] ElementsForSecondArray(string[] arr)
{
    string[] arrayTwo = new string[GetArray(firstArray)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
