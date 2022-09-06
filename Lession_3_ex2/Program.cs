Console.WriteLine("Расстояние между двумя точками в 2D");
    
    Console.Write("Введите координаты x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}");



Console.WriteLine("Введите координаты первой точки");
string[] values = Console.ReadLine().Split(new char[] { ',' });
int x1 = int.Parse(values[0]);
int y1 = int.Parse(values[1]);

Console.WriteLine("Введите координаты второй точки");
string[] values_2 = Console.ReadLine().Split(new char[] { ',' });
int x2 = int.Parse(values_2[0]);
int y2 = int.Parse(values_2[1]);
    
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}");
