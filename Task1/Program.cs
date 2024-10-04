internal class Program
{
    static double GetSquare(double x, double y, double z, double p)
    {
        return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длины сторон первого треугольника");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double z1 = Convert.ToDouble(Console.ReadLine());
        double p1 = (x1 + y1 + z1) / 2;
        double s1 = GetSquare(x1, y1, z1, p1);
        Console.WriteLine("Введите длины сторон второго треугольника");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double z2 = Convert.ToDouble(Console.ReadLine());
        double p2 = (x2 + y2 + z2) / 2;
        double s2 = GetSquare(x2, y2, z2, p2);

        if (s1 > s2)
        {
            Console.WriteLine("Площадь первого треугольника больше");
        }
        else
        {
            if (s2 > s1)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
        }
    }
            
}