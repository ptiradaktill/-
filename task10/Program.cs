/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

void Number(int newNumber)
{
    if (newNumber < 1000 && newNumber > 99)
    {
        int result = newNumber/10;
        Console.WriteLine(result%10);
    }
}

Number(157);