namespace EjercicioInterfaces
{
    public class OperacionesImpl : IOperaciones
    {
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public double CalculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        public double CalculateSurfaceArea(double length, double width, double height)
        {
            return 2 * (length * width + length * height + width * height);
        }

        public double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public void Imprimir(double length, double width, double height, double radius)
        {
            Console.WriteLine($"\nEl Área es: {CalculateArea(length, width)}");
            Console.WriteLine($"El Perímetro es: {CalculatePerimeter(length, width)}");
            Console.WriteLine($"El Volumen es: {CalculateVolume(length, width, height)}");
            Console.WriteLine($"El Área Superficial es: {CalculateSurfaceArea(length, width, height)}");
            Console.WriteLine($"La Circunferencia es: {CalculateCircumference(radius)}");
        }
    }


}
