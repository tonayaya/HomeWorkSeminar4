// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. 
// Не использовать встроенный метод возведения в степень
// 3, 5 -> 243 (3⁵), 2, 4 -> 16


Console.WriteLine("Домашняя работа семинар 4, Задача 25");
void degree(int a, int b)
{
    int result = 1;
    while (b > 0)
    {
        result = result * a;
        b--;
    }
    Console.WriteLine("ответ данной задачи: " + result);
}

Console.Write("введите число которое нужно возвести в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень в которую нужно возвести число: ");
int numBdegree = Convert.ToInt32(Console.ReadLine());
degree(numA, numBdegree);