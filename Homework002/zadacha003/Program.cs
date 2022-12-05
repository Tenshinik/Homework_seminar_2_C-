/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6, 7 - выходной. НО дня с индексом 0 или 12 не существует. 6 -> да, 7 -> да, 1 -> нет
*/

Console.WriteLine("Enter the number of the day of the week ");

int numberday = Convert.ToInt32(Console.ReadLine());


 static void CheckingTheDayOfTheWeek(int numberday)

 {

{
   if (numberday == 6 || numberday == 7)

  Console.WriteLine("Yes, weekend! ");

else if (numberday < 1 || numberday > 7)

  Console.WriteLine("there is no such day");

else

 if (numberday == 1 || numberday == 5)

  Console.WriteLine("Weekday ");
}

 }

CheckingTheDayOfTheWeek(numberday);

