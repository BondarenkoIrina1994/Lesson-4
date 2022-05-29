// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

int CheckingForCorrectnes(string str)
{
while (true)
{
Console.WriteLine(str);
string num=Console.ReadLine();
    if (int .TryParse(num, out int number) == false)
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
    else
    return number;
}
}
int number_a=CheckingForCorrectnes("Введите первое число: ");
int number_b=CheckingForCorrectnes("Введите второе число: ");

void Degree (int a, int n)
{   
    int result=1;
    for (int i=1; i<=n; i++)
    result=a*result;
    Console.WriteLine($"Возведение числа {a} в степень {n} равно {result}");
}
Degree (number_a, number_b);