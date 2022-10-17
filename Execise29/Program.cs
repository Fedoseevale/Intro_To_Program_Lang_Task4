// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

FillArrayRandom(array);
PrintArray(array);

void FillArrayRandom(int[] arr)
{
    var rnd = new Random();
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(0, 100); // задаём в качестве примере диапазон чисел от 0 до 99
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i <= arr.Length - 2; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}