/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void number(int newNumber)
{
    if(newNumber > 99)
    {
        while(newNumber > 999)
        {
            newNumber = newNumber/10;
        }
        Console.WriteLine(newNumber%10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

number(351);