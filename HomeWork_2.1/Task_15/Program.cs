Console.WriteLine("Введите  значение дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7)
{
    Console.WriteLine("В неделе не может быть больше 7 дней, введите другое число");
}
if (num > 5)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("нет ");
}