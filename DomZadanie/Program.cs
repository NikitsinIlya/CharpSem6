Console.Clear();

// Task 41 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3
/*
Console.WriteLine("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine()), s = 0, n = 0, r = 0;
    int[] array = new int[M];
for(int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число {s + 1}: ");
    n = Convert.ToInt32(Console.ReadLine());
    array[s] = n;
    s++;
        if (n > 0 ) r++;
}
Console.WriteLine($"{string.Join(" ,  ", array)}");
Console.WriteLine($"Количест чисел больше 0 = {r}");
*/

// Task 43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("Введите b1 : ");
    double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1 : ");
    double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 : ");
    double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 : ");
    double k2 = Convert.ToDouble(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($" точка пересечения двух прямых : ({Math.Round(x, 2)} , {Math.Round(y , 2)})");
*/

// Task Рекурсия
// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

