//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*int FuncSymbol(int num)
{
   int res = num % 100 / 10;
   return res;
}
Console.Write("Введите число: ");  
int number = Convert.ToInt32(Console.ReadLine());
int result  = FuncSymbol(number);
Console.WriteLine($"Вторая цифра числа {number} равна {result}");*/

//------------------------------------------------------------------------------------------------------------------------

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*void FuncNum(int num)
{
    if(num < 100) 
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        while(num > 999)
            {
                num /= 10;
            }
        Console.WriteLine($"Третья цифра - {num % 10}");
    }
}

Console.Write("Введите число: ");  
int number = Convert.ToInt32(Console.ReadLine());
while(number <= 0)
{
    Console.WriteLine("Число должно быть больше 0. Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

FuncNum(number);*/

//------------------------------------------------------------------------------------------------------------

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*bool FuncDay(int day)
{
    if((day == 6) ^ (day == 7))
        return true;
    return false;
}
Console.Write("Введите номер дня недели (1-7): "); 
int day = Convert.ToInt32(Console.ReadLine());
bool result = FuncDay(day);
if (result)
  Console.WriteLine("Выходной день.");
else
  Console.WriteLine("Рабочий день.");*/

//---------------------------------------------------------------------------------------------------------------

