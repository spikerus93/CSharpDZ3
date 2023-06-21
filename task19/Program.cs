//  Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите Пятизначное Число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100000 || number > 99999)
{
    Console.WriteLine("Вы ввели не Пятизначное число");
}
else if (number >= 10000 && number <= 99999)
{
    int num1 = (number / 10000) % 10;
    Console.Write($"Первая цифра: {num1} ");
    int num5 = (number / 1) % 10;
    Console.Write($"Пятая цифра: {num5} ");
    int num2 = (number / 1000) % 10;
    Console.Write($"Вторая цифра: {num2} ");
    int num4 = (number / 10) % 10;
    Console.Write($"Четвертая цифра: {num4} ");
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Ваше Число {number} - это Палиндром");
    }
    else
    {
        Console.WriteLine($"Это Число - {number} не является Палиндромом");
    }
}