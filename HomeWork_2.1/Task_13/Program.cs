Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 1000)
{
    num = num / 10;
}

if (num >= 100)
{
    num = num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}

else
{
    Console.WriteLine("Третьей цифры нет");
}