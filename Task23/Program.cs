// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число для того, чтобы посчитать кубы всех чисел от 1 до Вашего числа ->");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("Вы ввели 0, поэтому нам нечего считать :(");
}
else
{
    if (num > 0)
    {
        Console.WriteLine($"Мы посчитали для Вас кубы от 1 до {num}");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i*i*i);
        }
    }
    else 
    {
        Console.WriteLine($"Вы ввели отрицательное число, поэтому мы посчитали для Вас кубы от {num} до -1!");
        for (int i = 0; num < i; num++)
            {
                Console.WriteLine(num*num*num);
            } 
    }
}