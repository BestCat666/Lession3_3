// задача 24 на вход число А и выдает сумму чисел от 1 до А
Console.WriteLine("Введите чтсло: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");
int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum = sum + number;
        Console.WriteLine(sum); // выведение суммы в каждом цикле. можно num
        number = number - 1;
    }
    return sum;
}
