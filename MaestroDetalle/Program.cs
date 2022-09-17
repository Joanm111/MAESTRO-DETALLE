using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaestroDetalle
{
    internal class Program :album
    {
        static void Main(string[] args)
        {


            

            album album1 = new album();

            album1.Id = 1;
            album1.nombre = "Un verano sin ti";
            album1.artista = "Bad Bunny";
            album1.fechaSalida = new DateTime(2022, 5, 6);
            album1.canciones.Add(new Canciones()
            {
                Id = 1,
                name = "UN VERANO SIN TI",
                minutos = 3.18
            });

            album1.canciones.Add(new Canciones()
            {
                Id = 2,
                name = "OJITOS LINDOS",
                minutos = 4.20
            });

            album1.canciones.Add(new Canciones()
            {
                Id = 3,
                name = "UN COCO",
                minutos = 2.50
            });
            Console.WriteLine("ALBUM:"+ album1.nombre +" ARTISTA:"+ album1.artista+" FECHA DE SALIDA:" +album1.fechaSalida);
            double duracion = 0;
            foreach (var a in album1.canciones)
            {
                duracion = duracion + a.minutos;
                Console.WriteLine($"ID:{a.Id}   NOMBRE:{a.name}   DURACION: {a.minutos} MINUTOS"  );

              
            }
            Console.WriteLine($"Duracion total del album {duracion}");






            Console.Read();


























        }
        
    }
}

