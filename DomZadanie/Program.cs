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

/*
int Factorial (int n)  
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);      
}
void Sort(string[] arr , int col)
{
    for (int j = 1; j < col; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            string t = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = t;
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
    
}

Console.WriteLine("Введите количество символов : ");
    int n = Convert.ToInt32(Console.ReadLine());
int col = Factorial(n);
string[] array = new string[n];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите символ : ");
    array[i] = Console.ReadLine();
}
// Console.WriteLine($"[{string.Join(", ", array)}]");

Sort(array , col);

*/

// Task Площадь треугольника
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.
// 2 1 2 4 6 1 -> 6

Console.Write("Введите X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X3: ");
    double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y3: ");
    double y3 = Convert.ToDouble(Console.ReadLine());
double Stor1 = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
double Stor2 = Math.Round(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 2);
double Stor3 = Math.Round(Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)), 2);
double HalfPerim = (Stor1 + Stor2 + Stor3) / 2;
double S = Math.Round(Math.Sqrt(HalfPerim * (HalfPerim - Stor1) * (HalfPerim - Stor2) * (HalfPerim - Stor3)), 2);

Console.WriteLine(S);