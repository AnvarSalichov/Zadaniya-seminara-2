
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
int result= num%10;
if ((num>99)&&(num<1000))
    Console.WriteLine(result);
else if ((num<-99)&&(num>-1000))
    Console.WriteLine(result);
else
 {
    Console.WriteLine("Третьей цифры в заданном числе нет. Вы ввели неверное число");
 }   

