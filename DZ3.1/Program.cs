/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */


Console.WriteLine($"Введите пятизначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number/10000%10 == number%10 && number/1000%10 == number/10%10)
{
     Console.WriteLine("Да, палиндром");
}
else
{
     Console.WriteLine("Не палиндром");
}


