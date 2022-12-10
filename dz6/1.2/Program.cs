void Tochka(int k1, int k2, int b1, int b2)
{
    int x;
    int y;
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {   
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");
    }
}


Console.WriteLine("Введите коорд.");
int k1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
Tochka(k1,k2,b1,b2);