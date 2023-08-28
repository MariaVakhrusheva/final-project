// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateNewArray(string[] array)
{
    int k = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    Array.Resize(ref newArray, k);
    return newArray;
}

void ConvertArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"\"{array[i]}\"");
        else Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("]");
}

string GetInputText(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetInputText("Введите строку массива: ");
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Задайте размер массива: ");
string[] array = CreateArray(size);
ConvertArray(array);
Console.Write(" → ");
string[] newArray = CreateNewArray(array);
ConvertArray(newArray);