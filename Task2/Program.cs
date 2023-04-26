// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Main();
void Main()
{
    Console.WriteLine("Введите любое число: ");
    int a = int.Parse(Console.ReadLine());
    if (IsNumberValid(a) == true) { Console.WriteLine("Третьей цифры нет!"); }
    else { Console.WriteLine(FindThirdNumber(a)); }
}
int FindThirdNumber(int n)
{
    while (n > 999)
    {
        n /= 10;
    }
    return n % 10;
}

bool IsNumberValid(int n)
{
    if (n < 100) return true;
    else return false;
}
