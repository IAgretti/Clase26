namespace Clase26
{

       class Program
    {
        static void Main(string[] args)
        {
            Sistema s = new Sistema("Microsoft", "Windows", "2010", 1500);
            s.Imprimir();


            //IPieza cuadrado = new Cuadrado(5);
            //IPieza triangulo = new TriRec(5, 3);

            //Console.WriteLine($"El área del cuadrado es {cuadrado.Area()}.");
            //Console.WriteLine($"El Perímetro del cuadrado es {cuadrado.Perimetro()}.");

            //Console.WriteLine($"El área del triángulo es {triangulo.Area()}.");
            //Console.WriteLine($"El Perímetro del triángulo es {triangulo.Perimetro().ToString("N2")}.");
            Console.ReadKey();
        }
    }
}