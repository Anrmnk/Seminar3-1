Console.Write ("Введите число");
string usernumber = Console.ReadLine ();
int number = Convert.ToInt32(usernumber);
int max = number;
int min = -number;
while (min <= max)
{
   Console.Write (min + " ");
    min = min + 1;
}
