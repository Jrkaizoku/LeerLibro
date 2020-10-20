using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        private static Train train;
        static void Main(string[] args)
        {
            int i=0;
            ConsoleKeyInfo key;          
            string illumination = "";
            Light _levels;
            Console.Write("         EJERCICIO POO4 - KODIGO ");
            readData();
            Console.WriteLine(" Digite la iluminacion en las horas de viaje. Separalas por un espacio");          

            // Para  pedir los datos in usar ENTER, lee caracter por caracter y si es numero lo guarda hasta que encuentra un espacio
            do {
                key = Console.ReadKey(true);
                if (Char.IsDigit(key.KeyChar) || key.KeyChar == ' ') {
                    Console.Write(key.KeyChar);
                    if (key.KeyChar == ' ') {
                        _levels = new Light(int.Parse(illumination),i +1);
                        train.addLevel ( _levels);
                        illumination = "";
                        i++;
                    }
                    else illumination += key.KeyChar;
                    if (key.Key == ConsoleKey.Enter) break;
                }
            } while (i<train._hourTrain);

            //***************************************************************************************************************
            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Nivel minimo de luz: {0}", train._minForRead);
            PrintData();
            Console.ReadKey();
        }
        public static void readData(){
            int n, k,ilumination;
            do {
                Console.SetCursorPosition(42, 2);
                Console.Write("    ");
                Console.SetCursorPosition(5, 2);
                Console.Write("Nº de horas en el tren, entre 1 y 1000: ");                
                n = int.Parse(Console.ReadLine());
            } while (n<1 ||n>1000);

            do
            {
                Console.SetCursorPosition(38, 3);
                Console.Write("     ");
                Console.SetCursorPosition(5, 3);
                Console.Write("Nº de horas para leer, entre 1 y {0}: ",n);
                k = int.Parse(Console.ReadLine());
            } while (k < 1 || k > n);
            do
            {
                Console.SetCursorPosition(60, 4);
                Console.Write("     ");
                Console.SetCursorPosition(5, 4);
                Console.Write("Nivel de iluminacion necesaria para leer, entre 0 y 100: ");
                ilumination = int.Parse(Console.ReadLine());
            } while (ilumination < 0 || ilumination > 100);

            train = new Train(n, k, ilumination);

        }
        public static void PrintData()
        {
            int c = 0;
            Console.WriteLine("Horas de lectura Disponibles");
            train.PrintRead();
            Console.WriteLine("\nHoras de lectura Seleccionadas");
            foreach (Light light in train.Levels)
            {
                if (light._level >= train._minForRead && c<=train._hourRead)
                {
                    Console.Write("{0}:{1} ", light._hour, light._level);
                    c++;
                }

            }
            if (c==0) Console.WriteLine("No se encontraron horas de lectura para tu nivel minimo de luz");
            else
                if(c<train._hourRead) Console.WriteLine("\nHoras de lectura para tu nivel minimo de luz insuficientes");

        }
    }
}
