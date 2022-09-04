//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] CreateArray(int n)
{
   int[] arr = new int[n];
   for (int i = 0; i < n; i++)
        {
        arr[i] = new Random().Next(100, 1000);    
        }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.Write("\b\b]");
    Console.WriteLine();
}

int evenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count; 
}

Console.WriteLine("Введите количество элементов массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateArray(lengthArr);
PrintArray(newArr);
int count = evenNumber(newArr);
Console.WriteLine($"Количество четных элементов в списке равно {count}");*/

//--------------------------------------------------------------------------------------------------

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] CreateArray(int n)
{
   int[] arr = new int[n];
   for (int i = 0; i < n; i++)
        {
        arr[i] = new Random().Next(-1000, 1001);    
        }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.Write("\b\b]");
    Console.WriteLine();
}

int FuncSum(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) summ += arr[i];
    }
    return summ; 
}

Console.WriteLine("Введите количество элементов массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int [] newArr = CreateArray(lengthArr);
PrintArray(newArr);
int sum = FuncSum(newArr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");*/

//--------------------------------------------------------------------------------------------------------

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*double[] CreateArray(int n)
{
   double[] arr = new double[n];
   for (int i = 0; i < n; i++)
        {
        arr[i] = new Random().Next(0, 101) + Math.Round(new Random().NextDouble(), 2);    
        }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.Write("\b\b]");
    Console.WriteLine();
}

int MaxElement(double[] arr)
{
    int maxInd = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxInd]) maxInd = i;
    }
    return maxInd; 
}

int MinElement(double[] arr)
{
    int minInd = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minInd]) minInd = i;
    }
    return minInd; 
}


Console.WriteLine("Введите количество элементов массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
double [] newArr = CreateArray(lengthArr);
PrintArray(newArr);
int maxInd = MaxElement(newArr);
int minInd = MinElement(newArr);
double difference = Math.Round(newArr[maxInd] - newArr[minInd], 2);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");*/