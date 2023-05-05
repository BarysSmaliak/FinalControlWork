// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string [] RemoveElementsLongerThatGiven (string [] array, int max)
{
    string [] arrayIntermediate = new string [array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= max)
        {
            arrayIntermediate[j] = array[i];
            j++;
        }
    }
    string [] arrayResult = new string [j];
    for (int i = 0; i < j; i++)
    {
        arrayResult[i] = arrayIntermediate[i];
    }
    return arrayResult;
}

void PrintArray (string [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.Write(array[array.Length-1] + "]");
}

string[]arrayPrimary = new string[] {"ftfi", "ytfd", "it", "", "new", "8658", "aaaa", "arr", ""}; //Задаём массив
int maxElementLength = 3; // Задаем максимальную длину элемента в новом массиве
PrintArray(RemoveElementsLongerThatGiven(arrayPrimary, maxElementLength));
