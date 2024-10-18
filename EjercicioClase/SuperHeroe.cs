

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string ciudad {  get; set; }
        public bool puedeVolar {  get; set; }

        public void imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede Volar?: {puedeVolar} ");
            Console.WriteLine();
        }

    }
}
