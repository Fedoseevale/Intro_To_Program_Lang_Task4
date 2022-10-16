// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int NumberAPowB (int numA, int numB)
{
   int result = 1;   
   for (int i = 1; i <= numB; i++)
   {
        result = result*numA;
   }
   return result;
}


int numberAPowB = NumberAPowB(numberA, numberB);

if (numberB >= 1)
{
    Console.WriteLine ($"Результатом возведения числа A в натуральную степень B является число {numberAPowB}");
}
else Console.WriteLine ("Число B не является натуральным");







