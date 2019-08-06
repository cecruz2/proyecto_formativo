using System;

namespace proyecto_formativo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            proyecto categoria = new proyecto();
            proyecto categoria1 = new proyecto("elite", 18, 21);


            //categoria.IngresaDatos();
            //categoria.ImprimeDatos();
            categoria1.Modificar();
            categoria1.ImprimeDatos();
            Console.ReadKey();
        
        }
    }
}
//integrantes del proyecto formatovo:
//Carlos eduardo cruz aguilar
//Miguel Alejandro Luis Lopez
