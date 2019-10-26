using PIndividual.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.BL
{
    public class BLDB
    {
        public void AddVuelo(Vuelos v1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
               
                context.Vuelos.Add(v1);
                context.SaveChanges();
            }
        }
        public void AddAvion(Aviones A1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                context.Aviones.Add(A1);
                context.SaveChanges();
            }
        }
        public void AddPasajero(Pasajeros P1)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                context.Pasajeros.Add(P1);
                context.SaveChanges();
            }
        }


        public void UpdateVuelo()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {

                    var vuelo = context.Vuelos.Where(x => x.Id_vuelo == 1).SingleOrDefault();  //first last or tolist
                    vuelo.Escala = "Prueba2";

                    context.Entry(vuelo).State = System.Data.Entity.EntityState.Modified; // le estoy diciendo al entity que fue cambiado 

                    context.SaveChanges();
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ERROR:  " + exp.Message);
                }
            }
        }

        public void where_select()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    //var es una variable no tipificada, esta toma la forma al momento de la asignacion
                    var vuelo = context.Vuelos.Where(x => x.Id_vuelo == 1).Select(e =>
                    new
                    {
                        Escala = e.Escala,
                        Duracion = e.Duracion
                    }
                    ).ToList();

                    
                    context.SaveChanges();
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ERROR:  " + exp.Message);
                }
            }
        }

        public void remove()
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {

                    var vuelo = context.Vuelos.Where(x => x.Id_vuelo == 1).FirstOrDefault();
                    context.Vuelos.Remove(vuelo);
                    context.SaveChanges();
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ERROR:  " + exp.Message);
                }
            }
        }

        public Vuelos where_practica(int id)
        {
            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    //var es una variable no tipificada, esta toma la forma al momento de la asignacion
                    var vuelo = context.Vuelos.Where(x => x.Id_vuelo == id).SingleOrDefault();
                    return vuelo;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ERROR:  " + exp.Message);
                }
                return null;
            }
        }

    }
}
