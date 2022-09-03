//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*void FuncIsPalindrom(int num)
{
    if ((num / 10000 ==  num % 10) && (num / 1000 % 10 == num % 100 / 10))
    {
        Console.WriteLine($"Число {num} является палиндромом"); 
    }
    else
    {
       Console.WriteLine($"Число {num} не является палиндромом"); 
    }
}

Console.Write("Введите пятизначное число: ");  
int num = Convert.ToInt32(Console.ReadLine());
FuncIsPalindrom(num);*/


/*void FuncIsPalindrom(string num)
{
    if ((num[0] ==  num[4]) && (num[1] ==  num[3]))
    {
        Console.WriteLine($"Число {num} является палиндромом"); 
    }
    else
    {
       Console.WriteLine($"Число {num} не является палиндромом"); 
    }
}

Console.Write("Введите пятизначное число: ");  
string? num = Console.ReadLine();
FuncIsPalindrom(num);*/

//------------------------------------------------------------------------------------------------------------------------

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


/*double FuncLength(double x1, double y1, double z1, double x2, double y2, double  z2)
{
  double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
  return result;
}

Console.Write("Введите координату х первой точки: ");  
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");  
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");  
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");  
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");  
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");  
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точек: A({x1}, {y1}, {z1}), B({x2}, {y2}, {z2})"); 

double result = FuncLength(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2)}"); */

//------------------------------------------------------------------------------------------------------------------------

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*void FuncCub(int number)
{
    for(int i=1; i<=number; i++)
   {
     Console.WriteLine($"{i}**3 = {i*i*i}"); 
   }
}

Console.Write("Введите число: ");  
int num = Convert.ToInt32(Console.ReadLine());
FuncCub(num);   */


