// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
 
//  [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

 // Пишем метод для ввода с консоли чисел size, min, max 
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Пишем метод для создания массива:
int[] CreateArray(int size, int min, int max)
{
   int[] array = new int[size];
    for (int i = 0; i < size; i++)
   {
         array[i] = new Random().Next(min, max);
   }
   return array;
}

// Пишем метод для отображения созданного одномерного массива.
void PrintArray(int [] array)
{
     System.Console.Write ("Созданный массив : [ ");
    for (int i =0; i<array.Length; i++)
    {
        System.Console.Write (array[i] + " ");
    }
    System.Console.Write ("]");
}
// РЕКУРСИЯ!!!
// Пишем метод, который выведет элементы массива, начиная с конца. 
void PrintArrayReversedOrder (int [] array, int i)
{
    if (i >= 0) 
    {
        System.Console.Write (array [i] + " ");
        PrintArrayReversedOrder(array, i-1);
    }
}

//--------------------------------------
int size = ReadInt("Введите длину массива: ");
int min = ReadInt("Введите минимальное значение массива: ");
int max = ReadInt("Введите максимальное значение массива: ");
int [] MyArray = CreateArray(size, min, max);
PrintArray (MyArray);
System.Console.WriteLine ();
System.Console.WriteLine("Вывод массива в обратном порядке:");
PrintArrayReversedOrder (MyArray, MyArray.Length-1);
