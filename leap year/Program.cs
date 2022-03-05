

Console.WriteLine("Enter Year : ");
int Year = int.Parse(Console.ReadLine());


if (DateTime.IsLeapYear(Year))
{
    Console.WriteLine("This is leap year");
}
else
{
    Console.WriteLine("This is not leap year");
}




if (((Year % 4 == 0) && (Year % 100 == 0)) || (Year % 400 == 0))
{
    Console.WriteLine("{0} is a leap Year. ", Year);

}
else
{
    Console.WriteLine("{0} is not a Leap Year. ", Year);
    Console.ReadLine();

}