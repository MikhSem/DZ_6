// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

/* Console.WriteLine("Введите числа через пробел");
string numbers = Console.ReadLine()!;
string[] numStirng = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] intNumbers = Array.ConvertAll(numStirng, s => int.Parse(s));

int count = 0;
for (int i = 0; i < intNumbers.Length; i++)
{
    if (intNumbers[i] > 0) count++;
}
Console.WriteLine($"Чисел больше нуля {count}");
*/

// Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив,но отсортированный по возрастанию(от меньшего числа к большему).

Console.WriteLine("Введите количество чисел в массиве равное или больше 6 : ");
int sizemasive = int.Parse(Console.ReadLine()!);

if (sizemasive < 6)
{
    Console.WriteLine("Вы ввели число меньше 6, попрбуйте снова");
}
else
{
    int[] array = GetArray(sizemasive, 0, 101);
    Console.WriteLine($" Массив до сортировки [{String.Join("  ", array)}]");
    selectionSort(array);
    Console.WriteLine($" Массив после сортировки [{String.Join("  ", array)}]");
}
// ------ Метод для наполнения массива задача 2 -------

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVal, maxVal);
    }
    return res;
}

// ------ Метод для сортировки массива задача 2 -------
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}











 




/* int[] GetArray (int size)
{
    int[] res  = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next (minVal, maxVal);
    }
    return res;
} */
