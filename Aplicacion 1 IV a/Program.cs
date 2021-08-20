using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion_1_IV_a
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String Document = "Document created";
                Console.WriteLine("Anote el nombre del archivo");
                string archivo = Console.ReadLine();
                StreamWriter tr;
                tr = File.CreateText(archivo + ".txt");
                tr.WriteLine("Hola");
                tr.WriteLine("Tu archivo a sido creado");
                tr.WriteLine(Document);
                tr.Close();
            }
            catch
            {
                string document = "Failed document";
                Console.WriteLine("Error "+document);
            }
            return;
        }
    }
}