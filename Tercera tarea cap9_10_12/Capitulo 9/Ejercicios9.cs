using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo_9
{
    public class Ejercicios9
    {
        public static string entrada = String.Empty;
        /*estructura de productos 
         perteneciente al Ejercicio9_1*/
        public struct Productos 
        {   
            public string Descripcion { get; set; }
            public float Precio { get; set; }

            public Productos(string descripcion, float precio) : this()
            {
                Descripcion = descripcion;
                Precio = precio;
            }
        };

        public static void Ejercicio9_1()
        {
            List<Productos> productos = new List<Productos>();
            
            string descripcion = String.Empty;
            float precio = 0;

            do
            {
                Console.WriteLine("Ingrese el Precio del Producto:");
                entrada = Console.ReadLine();
                precio = Convert.ToSingle(entrada);
                Console.WriteLine("Ingrese Descripcion del Producto:");
                descripcion = Console.ReadLine();
                productos.Add(new Productos(descripcion, precio));                
            } while (precio != 0);

            foreach (var item in productos)
            {
                Console.WriteLine("Descripcion del producto:");
                Console.WriteLine(item.Descripcion);
                Console.WriteLine("Precio del producto:");
                Console.WriteLine(item.Precio);
            }
        }

        public struct Mascota
        {
            public String nombre;
            public String TipoMascota;
            public String FechaDeNacimiento;
        }

        public struct Propietario
        {
            public String Nombre;
            public String Direccion;
            public String telefono;
            public Mascota mascota;
        }

        public static void Ejercicio9_3()
        {
            Propietario dueno = new Propietario();

            Console.WriteLine("Ingrese el nombre del propietario ");
            dueno.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion del propietario ");
            dueno.Direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono del propietario ");
            dueno.telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la mascota ");
            dueno.mascota.nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de la mascota ");
            dueno.mascota.TipoMascota = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento de la mascota ");
            dueno.mascota.FechaDeNacimiento = Console.ReadLine();


            Console.WriteLine("Nombre del propietario: {0}\nDireccion del propietario: {1}\nTelefono Del propietario: " +
                "{2}\nNombre de la mascota: {3}\n Tipo de mascota: {4}\nFecha de nacimiento de la mascota:" +
                "{5}\nColor de la mascota: {6} ", dueno.Nombre, dueno.Direccion, dueno.telefono, dueno.mascota.nombre
                , dueno.mascota.TipoMascota, dueno.mascota.FechaDeNacimiento);


        }

        enum Neumaticos { TodoTerreno = 1, DeInvierno, DeVerano, DeAllSeason, De4x4, DePerfilAncho, DePerfilBajo };

        private void Ejercicio9_4()
        {
            string opcion;
            int opciones;
            Neumaticos goma;
            do
            {
                Console.WriteLine("Los tipos van del 1 al 7\nDigite 0 para salir");
                Console.WriteLine("Ingrese el tipo a saber");
                opcion = Console.ReadLine();
                opciones = Convert.ToInt32(opcion);

                switch (opciones)
                {
                    case 1:
                        {
                            goma = Neumaticos.TodoTerreno;
                            Console.WriteLine("{0}" goma); break;
                        }

                    case 2:
                        {
                            goma = Neumaticos.DeInvierno;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 3:
                        {
                            goma = Neumaticos.DeVerano;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 4:
                        {
                            goma = Neumaticos.DeAllSeason;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 5:
                        {
                            goma = Neumaticos.De4x4;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 6:
                        {
                            goma = Neumaticos.DePerfilAncho;
                            Console.WriteLine("{0}", goma); break;
                        }

                    case 7:
                        {
                            goma = Neumaticos.DePerfilBajo;
                            Console.WriteLine("{0}", goma); break;
                        }
                }
            } while (opciones != 0);
        }
    }
}
