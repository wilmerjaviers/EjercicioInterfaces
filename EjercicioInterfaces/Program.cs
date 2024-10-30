using EjercicioInterfaces;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la longitud: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el ancho: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Ingresa la altura: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el radio: ");
        double radius = double.Parse(Console.ReadLine());

        OperacionesImpl operations = new OperacionesImpl();
        operations.Imprimir(length, width, height, radius);
    }
}