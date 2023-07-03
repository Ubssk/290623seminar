// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int start = 1;
Console.WriteLine("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine());

while (start <= end)
{
    Console.Write(Math.Pow(start,3) + " "); // start во степень
    start++; // start = start + 1 - инкремент
}