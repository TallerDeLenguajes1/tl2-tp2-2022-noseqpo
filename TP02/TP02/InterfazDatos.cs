using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP02
{
    public class InterfazDatos
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


        public void CargarAlumno()
        {
            Alumno temp = new Alumno();

            temp.Nombre = Texto("nombre");
            temp.Apellido = Texto("apellido");
            temp.Dni = Numero("DNI");
            temp.Curso = Numero("curso");

        }

        private string Texto(string atributo)
        {
            string temp = "";

            Console.WriteLine("Ingrese " + atributo + ":");

            try
            {
                temp = Console.ReadLine();
            }
            catch(Exception ex)
            {
                logger.Info(ex, "Eror en Texto");
            }

            return temp;
        }

        private int Numero(string atributo)
        {
            int n = 0;
            string temp = Texto(atributo);

            try
            {
                n = Int32.Parse(temp);
            }
            catch(FormatException ex)
            {
                logger.Info(ex, "Error en formato");
            }

            return n;
        }

    }
}
