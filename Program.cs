Console.WriteLine("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

GetPal(number);

void GetPal(int number)
{
    while (number >= 0)
    {
        int m = number % 10;
        int secnumber = number / 10;
        sum = sum * 10 + m;
    }
    if (sum == number) Console.WriteLine("Число - палиндром!");
    else Console.WriteLine("Число -не палиндром!");
}