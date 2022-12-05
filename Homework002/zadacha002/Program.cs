/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter a  number");

string? NumberText = Console.ReadLine();

if (NumberText == null || NumberText.Length < 3)   
{
    Console.WriteLine("there is no third digit");
    Environment.Exit(1);
}

Console.WriteLine(NumberText?[2]);