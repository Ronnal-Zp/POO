namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Point point = new Point();  
            point.x = 10;
            point.y = 20;
            

            PointStructure pointStructure = new PointStructure();
            pointStructure.x = 5;
            pointStructure.y = 10;

            sumarCoord(pointStructure);

            Console.WriteLine($"Point.z: {point.z}");
            Console.WriteLine($"PointStructure.x: {pointStructure.x}");
            Console.WriteLine($"PointStructure.y: {pointStructure.y}");
        }

        static void sumarCoord(PointStructure pointStructure)
        {
            pointStructure.x += 10;
            pointStructure.y += 10;
        }
    }
}
