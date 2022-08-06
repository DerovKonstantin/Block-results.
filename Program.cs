
int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string[] ElementByElementArrayCreation(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + " элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortingThreeCharElementsArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++ )
        if(array[i].Length <= 3)
            size++; 
    string[] newarray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if(array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++; 
        }
    }
    return newarray;
}

void PrintArray(string[] array, string message)
{
    Console.WriteLine(message + ": [" + string.Join(", ", array) + "]");
}


int n = Input("Введите колличество элементов массива: " );
string[] array = ElementByElementArrayCreation(n);
string[] newarray = SortingThreeCharElementsArray(array);
PrintArray(array, "Начальный массив");
PrintArray(newarray, "Конечный массив");
