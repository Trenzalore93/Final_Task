// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Globalization;
using System.Threading.Channels;

string[] GetStringArray()
{
    Console.Write("Введите количество элементов массива:\t");
    int count = int.Parse(Console.ReadLine() ?? "0");
    string[] array = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}:\t");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Вывод массива: ");
    PrintArray(array);
    return array;
}
void PrintArray(string[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}

string[] CheckChar(string[] array, int number)
{
    string[] newArray = new string[10];
    int i = 0;
    for (int j = 0; j < newArray.Length & i < array.Length; j++)
    {
        if (array[i].Length > number) 
        {
            i++;
        }
        else
        {
            newArray[j] = array[i];
            i++;
        }

    }
    newArray = newArray.Where(x => x != null).ToArray();
    return newArray;
}
string[] str = GetStringArray();
string[] result = CheckChar(str, 3);
PrintArray(result);