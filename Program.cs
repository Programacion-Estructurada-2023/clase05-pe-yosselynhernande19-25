using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 

            //Declaracion de variables  de tipo texto con captura desde consola
            string? universidad = "";

            //Declarar variables de tipo texto con asignacion desde codigo

            string facultad = "Ingeniería  y Arquitectura";
            string profesion = "Tecnico en desarrollo de Software";

            //Declaracion de variable de variables entera captura desde consola 
            int anioIngreso = 0;

            //Declaracion de variables enteras asignando valores

            int edadIngreso = 23;
            int edadEgreso = 25;


            //Declaracion de variables double asignado valor desde consola 

            double coutaUniversidad = 0.0;

            //Declaracion de variable enteras asignando valores

            double gastoTransporte = 27.20;

            //Captura de datos desde consola

            Console.WriteLine("\n*********************************************");
            Console.WriteLine("\n-------Capturando datos de tipo texto------");
            Console.WriteLine("Ingrese el nombre de la universida donde estudia >> ");
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n----Fin de captura de tipo texto------\n");
            Console.WriteLine("*********************************************\n");



            Console.WriteLine("\n-----Capturando datos de tipo enteros-----\n");
            Console.WriteLine("Ingrese el año que inicio la universidad >> ");
            anioIngreso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------Fin de captura de tipo enteros-----------\n");
            Console.WriteLine("*********************************************\n");


            Console.WriteLine("\n-----Capturando datos de tipo decimal-----\n");
            Console.WriteLine("Ingrese la couta de la universidad >> ");
            coutaUniversidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n------Fin de captura de tipo decimal-----------\n");
            Console.WriteLine("*********************************************\n");

            //Impresion de datos en consola

            Console.WriteLine("*******************************************\n\n");
            Console.WriteLine("\n-------IMPRESION DE DATOS DE TIPO TEXTO-------");
            Console.WriteLine("\n------La Universidad en la que estudia es >>" + universidad);
            Console.WriteLine("\n Pertenece a la facultad de >>" + facultad);
            Console.WriteLine("\n Estudiando la carrera de >>" + profesion);
            Console.WriteLine("\n***************************************************************\n");


            Console.WriteLine("*******************************************\n\n");
            Console.WriteLine("\n-------IMPRESION DE DATOS EN ENTERO-------");
            Console.WriteLine("\n El año que ingreso a la universidad  >>  "   + anioIngreso  + "  años ");
            Console.WriteLine("\n La edad cuando inicio sus estudios es  >>  "   + edadIngreso  + "  años ");
            Console.WriteLine("\n La edad cuando finalice sus estudios sera >>  "   + edadEgreso);
            Console.WriteLine("\n***************************************************************\n");

            Console.WriteLine("*******************************************\n\n");
            Console.WriteLine("\n-------IMPRESION DE DATOS DE DOUBLE-------");
            Console.WriteLine("\n La cuota de su universidad es >>  "  + "$" + coutaUniversidad);
            Console.WriteLine("\n Su gasto en transporte es >> "  +  "$"  + gastoTransporte);
            Console.WriteLine("\n***************************************************************\n");

            Console.ReadKey();



 













        }
    }
}
