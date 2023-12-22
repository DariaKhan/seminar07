// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

// Пишем метод для ввода с консоли чисел m и n.
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }

    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

//------------------------------------
int m = ReadInt("Введите значение m: ");
int n = ReadInt("Введите значение n: ");
int result = AckermannFunction (m,n);
Console.WriteLine($"Функция Аккермана для m={m}, n={n} равна: {result}");
