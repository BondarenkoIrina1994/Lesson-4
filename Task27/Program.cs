// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CheckingForCorrectnes(string str)
{
while (true)
{
Console.WriteLine(str);
string num=Console.ReadLine();
    if (int .TryParse(num, out int number_) == false)
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
    else
    return number_;
}
}
int number=CheckingForCorrectnes("Введите число: ");

void Sum_digit (int a)
{ 
    int a_=a;
    int result=0;
    while (a>0)
    {
        int d=a%10;
        a=a/10;
        result=d+result;
    }
    Console.WriteLine($"Сумма цифр в числе {a_} равна {result}");
}
Sum_digit(number);
