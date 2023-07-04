// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int fifthnum = number % 10;
int firstnum = number / 10000;
int secondnum = (number / 1000) - ((number / 1000) / 10 * 10);
int forthnum = (number / 10) - ((number / 10) / 10 * 10);
if(number<10000 || number>99999)
{start:
    Console.WriteLine("Нужно пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
goto start;}
else if (fifthnum == firstnum && secondnum == forthnum)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число НЕ является палиндромом");
}