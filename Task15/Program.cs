// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.Write("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 5 && num>=1)
    System.Console.WriteLine("Рабочий день");
else if (num >= 6 && num <= 7)
    System.Console.WriteLine("Выходной день");
else
    System.Console.WriteLine("Надо ввести от 1 до 7");