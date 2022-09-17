 namespace Cv120922
{
    class Program
    {
        static void Main(string[] args)
        {
            Interval i = new Interval(10, 60);
            Interval i2 = new Interval(15, 20); 

            Console.WriteLine(i.ToString());
            Console.WriteLine(i2.ToString());
            Console.WriteLine("Intersection: " + Interval.intersection(i, i2));

            Triangle t = new Triangle(9,9,9);
            Console.WriteLine(t.ToString());
        }
    }
} 