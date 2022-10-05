using System;
class Cone
{
    public double CalculateVolume(double radius, double height)
    {
        double volume = 0.0;

        volume = (1.0 / 3) * Math.PI * radius * radius * height;

        return volume;
    }
    public static void Main()
    {
        double volume = 0;
        double radius   =   0;
        double height   =   0;

        Cone C = new Cone();

        Console.Write("Enter the radius of a cone: ");
        radius = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of a cone: ");
        height = double.Parse(Console.ReadLine());

        volume = C.CalculateVolume(radius, height);

        Console.WriteLine("Volume of cone is: "+ volume);
    }
}
