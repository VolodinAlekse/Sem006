// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// System.Console.WriteLine("Введите число n: ");
// int Fibonachi1 = 0;
// int Fibonachi2 = 1;
// int FibonachiN;

// int n = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("0 1 ");
// for (int i = 0; i < n - 2; i++)
// {
//     int sum = Fibonachi1 + Fibonachi2;
//     System.Console.Write(sum + " ");
//     Fibonachi1 = Fibonachi2;
//     Fibonachi2 = sum;
// }

//  Задача 45: Напишите программу, 
//  которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int CopyPaste(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int[] arr = GenerateArray(5, 0, 10);
int[] arrCopy = arr[..];
int[] arrCopy2 = arr;

arr[0] = 100;

PrintArray(arr);
PrintArray(arrCopy);

arrCopy[0] = 200;
PrintArray(arr);
PrintArray(arrCopy);
