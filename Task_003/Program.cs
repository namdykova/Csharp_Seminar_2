Console.WriteLine("Введите число от 10 до 99 включительно:"); 
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9 && number < 100)
    {
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
} else
{
    System.Console.WriteLine("Не число от 10 до 99 включительно");
}