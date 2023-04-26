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
    if (n < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        while (n > 1000)
        {
            n = n - 1000;
            Console.WriteLine(n);
        }
        int m = n % 10;
        Console.WriteLine(m);
    }
}