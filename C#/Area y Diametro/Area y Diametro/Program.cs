using Area_y_Diametro;

public class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.Clear();

        List<Figura> figuras = new List<Figura>();

        figuras.Add(new Triangulo(4, 3));
        figuras.Add(new Circulo(6));
        figuras.Add(new Cuadrado(8));

        foreach (Figura figura in figuras)
        {
            Console.WriteLine(figura.ToString());
        }
    }
}
