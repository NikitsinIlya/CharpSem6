Console.Clear();
// меняет местами числа массива
/*
Console.Clear();

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
}

void ReplaceElement(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный масссив: [{string.Join(", ", array)}]");
ReplaceElement(array);
Console.WriteLine($"Конечный масссив: [{string.Join(", ", array)}]");

*/

// Task 40 
// на входе 3 числа может ли существовать треугольник с сторонами такой длинны
/*
Console.WriteLine("Введите 1-е число: ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
    int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
    int numb3 = Convert.ToInt32(Console.ReadLine());
if(numb1 < numb2 + numb3 && numb2 < numb1 + numb3 && numb3 < numb1 + numb2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

*/

// Task 42
/*
Console.WriteLine("Введите число: ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (numb1 > 0)
{
    result = Convert.ToString(numb1 % 2) + result;
    numb1 = numb1 / 2;
}
Console.WriteLine(result);

*/
// Task 44

// Не используя рекурсию выведите первые N чисел фибоначчи. Первые 2 числа фебоначчи 0 и 1.
/*
Console.WriteLine("Введите число: ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < numb1; i++)
{
    Console.Write($"{a0}");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}
*/
// Task 46
//Скопируйте массив
/*
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++) // цикл копирования массива в новый массив
    b[i] = a[i];

b[0] = 100;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));
*/


