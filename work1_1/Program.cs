// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
int res = (num/10);
int result= res%10;
if ((num>99)&&(num<1000))
    Console.WriteLine(result);
else
    Console.WriteLine("Вы ввели неверное число");
    
