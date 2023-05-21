namespace Ejercicio03Fer.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Información de Cuadrados");
                //int lado;
                //int perimetro;
                //double superficie;
                //Ingreso de datos
                Console.Write("Ingrese el valor del lado entre 1 y 100:");
                var lado = int.Parse(Console.ReadLine());
                //Tengo que validar el lado
                if (lado >=1 && lado <= 100)
                {
                    //Procesamiento
                    var perimetro = CalcularPerimetro(lado);
                    var superficie = CalcularSuperficie(lado);

                    //Salida de Información
                    Console.WriteLine($"El perímetro de un cuadrado de lado {lado} es {perimetro}");
                    Console.WriteLine($"La superficie es {superficie}");

                }
                else
                {
                    Console.WriteLine("Valor del lado fuera del rango permitido");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Valor del lado no válido");
            }
            Console.ReadLine();
        }

        private static int CalcularPerimetro(int lado)
        {
            return lado * 4;
        }
        private static double CalcularSuperficie(int lado)
        {
            return Math.Pow(lado, 2);
        }
    }
}