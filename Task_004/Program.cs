Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10) {
    Console.WriteLine(n);
}
else {
    while (n > 0) {
        int currentDigit = n % 10;
        n /= 10;
        if (n > 0)
        {
            Console.Write(currentDigit + ", ");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}