// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число, чтобы узнать является ли оно палиндромом:");
string str = Console.ReadLine();
char[] ch = str.ToCharArray();
int num;
bool Num;
if (Num = Int32.TryParse(str, out num))
{
    if (str.Length > 0 && str.Length < 6)
    {
        if (ch[0] == ch[4] && ch[1] == ch[3])
        {
            Console.WriteLine($"Число {str} - является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {str} - НЕ является палиндромом.");  
        }
        }
        else
        {
            Console.WriteLine("Введенное число не является пятизначным. Проверка прервана.");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число, а буквенные символы.");
    }