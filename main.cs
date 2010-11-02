using System;

namespace proyectoOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string archivo="";
            while (archivo != "salir")
            {
                Console.WriteLine("Introduzca nombre del archivo: ");
                archivo = Console.ReadLine();
                if (archivo != "salir")
                {
                    Scanner scanner = new Scanner(archivo);
                    Parser parser = new Parser(scanner);
                    parser.Parse();
                    
                }
            }
       }
    }
}