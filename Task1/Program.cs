// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Main();
void Main()
{
int a = new Random().Next(100,1000);
Console.WriteLine(a);
Console.WriteLine(FindSecondNumberOf(a));
}
int FindSecondNumberOf(int n)
{
    while(n>100){
        n = n-100;
    }
    int rand = n/10;
    return rand;
}
