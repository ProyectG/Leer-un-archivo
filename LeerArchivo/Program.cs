using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leerArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String linea;
            int contador = 0;
            try
            {
                StreamReader archivo = new StreamReader("prueba.txt");

                while ((linea = archivo.ReadLine()) != null)
                {
                    System.Console.WriteLine("[[LINEA]] " + linea);
                    contador++;
                }
                System.Console.WriteLine("[[FIN]] Cantidad de lineas total: {0} ", contador);
            }
            catch (Exception error)
            {
                System.Console.WriteLine("[[Error]]" + error.Message);
            }


            System.Console.ReadKey();

        }
    }
}