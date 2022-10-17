// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits (int num)
{
   int result = num % 10;   
   for (int i = 1; i <= num; i++)
   {
        int step1 = num / 10;
        num = step1;
        int step2 = num % 10; 
        result = result + step2;
   }
   return result;
}

int sumDigits = SumDigits (number);
Console.WriteLine($"Сумма цифр в данном числе: {sumDigits}");