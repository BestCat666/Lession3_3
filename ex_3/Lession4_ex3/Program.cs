// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()); 
int FacterialNum(int kol)
{
    int i = 1;
    int facte = 1;
    while ( i <= kol)
    {
        facte = i * facte;
        //Console.WriteLine(number);
        i++;
    }
    return facte;
}
Console.WriteLine($"{num} -> {FacterialNum(num)}");



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); 

int Factorial(int num)
{
    int count = num;
    while (count > 1)
    {
        count--;
        num *= count;
        Console.WriteLine(num);
    }
    return num;
}

Console.WriteLine($"{number} -> {Factorial(number)}");
