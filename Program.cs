Console.WriteLine("Введите числа: ");
int Num2 = int.Parse(Console.ReadLine());

int result = ReturnThreeNumber(Num2);
if (result == 0)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write($"Третья цифра числа {Num2} -> {result}");
}
int ReturnThreeNumber(int num)
{
    int result = 0;
    while (num > 999) { num /= 10; }
    if (num > 99) { result = num % 10; }
    return result;
}