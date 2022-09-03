//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int FuncMultiplay(int a, int b)
{
    int multiplay = a;
    int count = 1;
    while(count < b)
    {
        multiplay *= a;
        count++;
    }
    if (b == 0) multiplay = 1;
    return multiplay;
}

Console.Write("Введите первое число: ");  
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");  
int b = Convert.ToInt32(Console.ReadLine());
while(b < 0)
{
    Console.Write("Число должно быть больше или равно нулю. Введите степень: ");  
    b = Convert.ToInt32(Console.ReadLine());
}

int result = FuncMultiplay(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {result}");*/

//---------------------------------------------------------------------------------------------------------

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int FuncSum(int number)
{
    int summ = 0;
    while(number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

Console.Write("Введите число: ");  
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number *= (-1);
int result  = FuncSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {result}");*/

//----------------------------------------------------------------------------------------------------------

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int[] CreateArray(int n, int minVal, int maxVal)
{
   int[] arr = new int[n];
   for (int i = 0; i < n; i++)
        {
        arr[i] = new Random().Next(minVal, maxVal+1);    
        }
   return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.Write($"\b\b]");
}

int [] newArr = CreateArray(8, -100, 100);
PrintArray(newArr);
Console.WriteLine();*/


/*int[] CreateArray(int n)
{
   int[] arr = new int[n];
   for (int i = 0; i < n; i++)
        {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
        }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.Write($"\b\b]");
}

Console.WriteLine("Введите количество элементов массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateArray(lengthArr);
PrintArray(newArr);
Console.WriteLine();*/

