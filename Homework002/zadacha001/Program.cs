/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

Console.WriteLine("Enter a three-digit number");

string? ThreeDigitNumber = Console.ReadLine();

if (ThreeDigitNumber == null || ThreeDigitNumber.Length != 3)   
{
    Console.WriteLine("this is an incorrect number");
    Environment.Exit(1);
}

Console.WriteLine(ThreeDigitNumber?[1]);







