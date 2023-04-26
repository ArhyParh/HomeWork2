// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Main();
void Main()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    IsNumberOfDayWeekend(a);
}
void IsNumberOfDayWeekend(int a)
{
    while (a > 7) { a -= 7; }
    if (a < 6) { Console.WriteLine("Нет"); }
    else { Console.WriteLine("Да"); }
}
