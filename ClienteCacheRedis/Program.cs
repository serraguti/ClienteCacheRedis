namespace ClienteCacheRedis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente MOVIL de Cache Redis");
            Console.WriteLine("--------------------");
            ServiceCacheRedis service = new ServiceCacheRedis();
            string fin = "y";
            while (fin.ToLower() != "n")
            {
                List<Producto> favoritos = service.GetProductosFavoritos();
                if (favoritos == null)
                {
                    Console.WriteLine("No existe favoritos");
                }
                else
                {
                    int i = 1;
                    foreach (Producto prod in favoritos)
                    {
                        Console.WriteLine(i + ".- " + prod.Nombre);
                    }
                    Console.WriteLine("----------------");
                }
                Console.WriteLine("¿Desea seguir cargando favoritos? (y/n)");
                fin = Console.ReadLine();
            }
            Console.WriteLine("Fin de programa");
        }
    }
}