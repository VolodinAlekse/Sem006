// Задача 40: Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// metka:
// System.Console.WriteLine("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// if (array.Length != 3)
// {
//     System.Console.WriteLine("Массив введен некоректно ");
//     goto metka;
// }

// if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2]))
// {
//     System.Console.WriteLine("Такой треугольник существует ");
// }
// else
// {
//     System.Console.WriteLine("Такой треугольник не существует ");
// }



// System.Console.WriteLine("Ведите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string st = "";

// while (n != 0)
// {
//     st += n % 2;
//     n = n / 2;
// }
// for (int i = st.Length - 1; i > 0; i--)
// {
//     System.Console.Write(st[i]);
// }
// System.Console.WriteLine();

void GetBinatyView(int number)
{
    if (number <= 0) return;
    GetBinatyView(number / 2);
    System.Console.Write(number % 2);
}

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
GetBinatyView(N);
