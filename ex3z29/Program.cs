// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Заполнение массива производит пользователь.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Домашняя работа семинар 4, Задача 29");
Console.WriteLine("Введите длину массива:");
if (!int.TryParse(Console.ReadLine(), out int prmArrLength) || prmArrLength < 0)
{
    Console.WriteLine("Неверный ввод длины массива");
    return;
}
int[] FillArray(int lenArray)
{
    int[] res = new int[lenArray];
    var i = 0;
    Console.WriteLine("Введите массив через запятую: ");
    var prmArray = Console.ReadLine();
    foreach (var item in prmArray.Split(','))
    {
        if (i >= lenArray)
            return res;
        if (int.TryParse(item, out int arrItem))
        {
            res[i] = arrItem;
            i++;
        }
    }
    return res;
}
void PrintArray(int[] userArray)
{
    Console.WriteLine($"[{string.Join(',', userArray)}]");
}
var arr = FillArray(prmArrLength);
PrintArray(arr);