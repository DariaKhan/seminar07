// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
 
 // Пишем метод для ввода с консоли чисел M и N.
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Пишем метод, который выведет все натуральные числа в промежутке от M до N. 
void PrintNaturalNumbers (int m, int n)
{
    if (m <= n) 
    {
        System.Console.Write (m + " ");
        PrintNaturalNumbers (m+1, n);
    }
}

//-----------------------------------------
int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");

 if (m <= n)
{
    PrintNaturalNumbers(m, n);
}
else
{
    Console.WriteLine("M должно быть меньше или равно N.");
}
