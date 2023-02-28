Console.Write ("Введите первое число");
string user1 = Console.ReadLine ();
int number1 = Convert.ToInt32(user1);
Console.Write ("Введите второе число");
string user2 = Console.ReadLine ();
int number2 = Convert.ToInt32(user2);
if (number1 == number2 * number2)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}