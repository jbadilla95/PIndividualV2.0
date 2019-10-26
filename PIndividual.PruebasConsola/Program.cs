using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.DAL;
using PIndividual.PruebasConsola.PrimerServicio;


namespace PIndividual.PruebasConsola
{
    class Program
    {

        static void Main(string[] args)
        {
            Primer_ServicioSoapClient cliente = new Primer_ServicioSoapClient();
         String respuesta = cliente.HelloWorld();


            //___________________________________________________________________________________________________________
            //Prueba pru = new Prueba();
            //pru.AgregarAviones();
            //pru.AgregarPasajeros();
            //pru.Agregarvuelo();


            //BLDB b = new BLDB();
            //b.remove();

            //using (var context = new DBContextCF())
            //{
            //    try
            //    {
            //        Console.WriteLine("Adding new Students");

            //        var student = new Student
            //        {
            //            FirstMidName = "Angela ",
            //            LastName = "Martina",
            //            EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
            //        };
            //        context.Students.Add(student);
            //        context.SaveChanges(); // en este punto se guarda la infromacion en base de datos                    
            //    }
            //    catch (Exception exp)
            //    {
            //        Console.WriteLine("ERROR:  " + exp.Message);
            //    }
           // }
        }

         


                 
        
               
    }
}
