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
            //BuscarDueno(4);
            //BorrarDueno(11);
            //AddVeterinario();
            //BuscarVeterinario(6);
            //BorrarVeterinario(12);
            //AddMascota();
            //BorrarMascota(4);
            //ListarMascotas();
            //BuscarMascota(2);
            //BuscarMascotaPorFiltro("Firulay");
            //AddHistoria();
            //BorrarHistoria(2);
            //ListarHistorias();
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

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Correo);
        }

        private static void BorrarDueno(int idDueno)
        {
            _repoDueno.DeleteDueno(idDueno);             
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

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " "+ veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void BorrarVeterinario(int idVeterinario)
        {
            _repoVeterinario.DeleteVeterinario(idVeterinario);             
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

        private static void BorrarMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);             
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

        private static void BuscarMascotaPorFiltro(string filtro)
        {
            var mascota = _repoMascota.GetMascotasPorFiltro(filtro);
            foreach (Mascota m in mascota)
            {
                Console.WriteLine(m.Nombre + " " + m.Color + " " + m.Especie + " " + m.Raza);
            }
        }

        private static void AddHistoria()
        {

            var historia = new Historia
            {
                
                FechaInicial = new DateTime(2022,09,12)
            };
            _repoHistoria.AddHistoria(historia);
            
        }

        private static void BorrarHistoria(int idHistoria)
        {
            _repoHistoria.DeleteHistoria(idHistoria);             
        }

        private static void ListarHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias)
            {
                Console.WriteLine(h.FechaInicial);
            }
          
        }


    }
}
