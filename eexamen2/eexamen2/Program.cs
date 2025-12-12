using System.Diagnostics.Tracing;
using System.Reflection;
using System.Transactions;

namespace eexamen2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            
            
            {
   

            List <pelicula> Listadodepeliculas = new List<pelicula>();
            bool salir = true;
            while (salir)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("= Bienvenido a su lista de Peliculas =");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Agregar Peliculas");
                Console.WriteLine("2. Ver lista");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el titulo de la pelicula:");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese el genero de la pelicula:");
                        string genero = Console.ReadLine();
                        Console.WriteLine("Ingrese el año de la pelicula:");
                        int año = int.Parse(Console.ReadLine());
                        pelicula nuevapeli = new pelicula(titulo, genero, año);
                        Listadodepeliculas.Add(nuevapeli);
                        break;

                    case 2:
                        Console.Clear();
                       Console.WriteLine("Lista de Peliculas:");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("ID           TITUlO          GENERO          AÑO");
                        Console.WriteLine("===============================================");
                        
                        for (int i = 0; i < Listadodepeliculas.Count; i++)

                        {
                            Console.WriteLine($"{i + 1}.           {Listadodepeliculas[i].Titulo} -         {Listadodepeliculas[i].Genero} -        {Listadodepeliculas[i].Año}");
                        }
                        Console.WriteLine("ENTER PARA SALIR");
                        Console.ReadLine();






                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("===============================================");
                        Console.WriteLine("ID           TITUlO          GENERO          AÑO");
                        Console.WriteLine("===============================================");

                        for (int i = 0; i < Listadodepeliculas.Count; i++)

                        {
                            Console.WriteLine($"{i + 1}.           {Listadodepeliculas[i].Titulo} -         {Listadodepeliculas[i].Genero} -        {Listadodepeliculas[i].Año}");
                        }
                        Console.WriteLine("Ingrese el ID de la pelicula que desea editar:");
                        int idEditar = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Ingrese el nuevo titulo de la pelicula:");
                        string nuevoTitulo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo genero de la pelicula:");
                        string nuevoGenero = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo año de la pelicula:");
                        int nuevoAño = int.Parse(Console.ReadLine());
                        Listadodepeliculas[idEditar - 1] = new pelicula(nuevoTitulo, nuevoGenero, nuevoAño);
                        Console.WriteLine("EL PELICULON FUE EDITADO EXITOSAMENTE");
                        Console.WriteLine("ENTER PARA SALIR");
                        Console.ReadLine();







                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("===============================================");
                        Console.WriteLine("ID          TITUlO         GENERO         AÑO");
                        Console.WriteLine("===============================================");

                        for (int i = 0; i < Listadodepeliculas.Count; i++)

                        {
                            Console.WriteLine($"{i + 1}.           {Listadodepeliculas[i].Titulo} -         {Listadodepeliculas[i].Genero} -        {Listadodepeliculas[i].Año}");
                        }
                        Console.WriteLine("INGRESE EL ID Q DESEA ELIMINAR ");
                        int Borrar = int.Parse(Console.ReadLine());
                        Console.WriteLine("ESTA SEGURO DE ELIMINAR ESTA PELICULA? S/N");
                        string confirmar = Console.ReadLine();
                        if (confirmar.ToUpper() != "S")
                        {
                            Console.WriteLine("OPERACION CANCELADA");
                            Console.WriteLine("ENTER PARA SALIR");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Listadodepeliculas.RemoveAt(Borrar - 1);
                            Console.WriteLine("EL PELICULON FUE ELIMIMADO EXITOSAMENTE");
                            Console.WriteLine("ENTER PARA SALIR");
                            Console.ReadLine();
                            break;
                        }
                        
                        
                      
                        








                       

                    case 5:
                        salir = false;

                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("FUERA DE RANGO");
                        Console.WriteLine("ENTER PARA SALIR");
                        Console.ReadLine();
                        break;
                }
            }

        }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("SALIO UN ERROR: " + ex.Message);
                Console.WriteLine("ENTER PARA SALIR");
                Console.ReadLine();
            }
    }
}
}
