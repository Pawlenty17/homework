// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] arr = { 1, 2, 3, 4, 5 };
PrintArrayReverse(arr, arr.Length - 1);


void PrintArrayReverse(int[] arr, int index)
{
    if (index < 0)
        return;

    Console.Write(arr[index]);
    PrintArrayReverse(arr, index - 1);
}
    