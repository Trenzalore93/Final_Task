// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Threading.Channels;

string[] GetStringArray()
{
    Console.Write("Введите количество элементов массива:\t");
    int count = int.Parse(Console.ReadLine());
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
void PrintArray(string[] array) // выводим массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}

string[] CheckChar(string[] array)
{
    string[] newArray = new string[10];
    for (int i = 0; i < array.Length; i++)
    {
        char[] chars = array[i].ToCharArray();
        if (chars.Length <= 3)
        {
            for (int j = 0; j < newArray.Length; j++)
            {
                newArray[j] = array[i];
            }
        }
    }
    return newArray;
}

string[] str = GetStringArray();
string[] result = CheckChar(str);
PrintArray(result);