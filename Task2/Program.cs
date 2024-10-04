internal class Program
{
    static void GetVolumeSquare(double x, out double v,out double s)
    {
        v = x * x * x;
        s = 6 * x * x;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра куба");
        double a = Convert.ToDouble(Console.ReadLine());
        double v;
        double s;
        GetVolumeSquare(a, out v, out s);
        Console.WriteLine("{0} {1}", v,s);

    }
}