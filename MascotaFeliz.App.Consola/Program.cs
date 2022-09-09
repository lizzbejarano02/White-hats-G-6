using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        //private static IRepositorioVisitasPyP _repoVisitasPyP = new RepositorioVisitasPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            ListarMascotas();
            BuscarMascota(2);
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1313",
                Nombres = "El chavo",
                Apellidos = "Del ocho",
                Direccion = "El vecindario",
                Telefono = "3345643210",
                Correo = "elchavo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                
                Nombres = "Lola",
                Apellidos = "Mento",
                Direccion = "Cali",
                Telefono = "3367893045",
                TarjetaProfesional = "1234567890"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "Sasha",
                Color = "Blaco",
                Especie = "Gato",
                Raza = "Angora",
                //DuenoId = "1",
                //VeterinarioId = "1",
                //HistoriaId = "1"
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Color + " " + m.Especie + " " + m.Raza);
            }
          
        }
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
        }


    }
}
