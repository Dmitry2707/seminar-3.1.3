Console.WriteLine("write number N");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    Console.WriteLine(number % 2); 
}
else
{
    Console.WriteLine("нечетное");
}
