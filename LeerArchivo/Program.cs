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

                //El encargado de tomar el archivo y la clase quien se encarga de recorrer.
                StreamReader archivo = new StreamReader("prueba.txt");

                //Recorre la linea mientras que el resultado no sea nulo.
                while ((linea = archivo.ReadLine()) != null)
                {
                    System.Console.WriteLine("[[LINEA]] " + linea);
                    contador++;
                }
                System.Console.WriteLine("[[FIN]] Cantidad de lineas total: {0} ", contador);
            }
            catch (Exception error)
            {
                //Capturar el error
                System.Console.WriteLine("[[Error]]" + error.Message);
            }

            //Esperar a que se presione una tecla para ver el resultado.
            System.Console.ReadKey();

        }
    }
}