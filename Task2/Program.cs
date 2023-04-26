// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Main();
void Main()
{
    Console.WriteLine("Введите любое число: ");
    int a = int.Parse(Console.ReadLine());
    FindThirdNumber(a);

}
void FindThirdNumber(int n)
{
    if (n < 100) { Console.WriteLine("Третьей цифры нет."); }
    else if (1000 > n && n > 100) { Console.WriteLine(n % 10); }
    else if (10000 > n && n > 1000) { Console.WriteLine((n % 100)/10); }
    else if (100000 > n && n > 10000) { Console.WriteLine((n % 1000)/100); }
    else if (1000000 > n && n > 100000) { Console.WriteLine((n % 10000)/1000); }
    else if (10000000 > n && n > 1000000) { Console.WriteLine((n % 100000)/10000); }
    else if (100000000 > n && n > 10000000) { Console.WriteLine((n % 1000000)/100000); }
}