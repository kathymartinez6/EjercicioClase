namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }

        public SuperPoder poder;

        public SuperHeroe()
            {
            poder = new SuperPoder ();
            }


        public void imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar?: {PuedeVolar} ");
            Console.WriteLine($"Nombre del SuperPoder: {poder.NombrePoder}");
            Console.WriteLine($"Descripcion: {poder.Descripcion}");
            Console.WriteLine($"Nivel: {poder.Nivel} ");
            Console.WriteLine();
        }

    }
}
