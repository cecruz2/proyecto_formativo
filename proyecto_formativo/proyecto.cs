using System;

namespace proyecto_formativo
{
    class proyecto
    {
        #region Propiedades
        public string Nombre { get; set; }
        public int EdadMin { get; set; }
        public int EdadMax { get; set; }

        #endregion
        #region metodos 

        public void IngresaDatos()
        {
            Console.WriteLine("ingrese el nombre de la categoria: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("digite la edad minima: ");
            EdadMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la eada maxima de la categoria: ");
            EdadMax = int.Parse(Console.ReadLine());
        }
        public void ImprimeDatos()
        {
            Console.WriteLine($"nombre: {Nombre}");
            Console.WriteLine($"Edad minima: {EdadMin}");
            Console.WriteLine($"Edad maxima: {EdadMax}");
        }
        public void Modificar()
        {
            Console.WriteLine("digite el rango de edad a modificar");
            EdadMax = int.Parse(Console.ReadLine());
        }

        #endregion
        #region constructores
        public proyecto(string nombre, int edadmin, int edadmax)
        {
            Nombre = nombre;
            EdadMin = edadmin;
            EdadMax = edadmax;
        }
        public proyecto()
        {

        }
        #endregion

    }
}
