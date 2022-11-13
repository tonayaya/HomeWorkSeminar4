// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Для решения задания использование цикла for является обязательным условием
// 452 -> 11, 82 -> 10, 9012 -> 12

Console.WriteLine("Домашняя работа семинар 4, Задача 27");
    int sum(int numberN)
{
    int result = 0;
    for (int i = 0; numberN != 0; i++)
    {
        result = result + numberN % 10;
        numberN = numberN / 10;
    }
    return result; 
}

System.Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе " + numberN + " = " + sum(numberN));
