using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    public static class Program
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Main()
        {
            InterfazDatos instituto = new InterfazDatos();

            instituto.CargarAlumno();



        }
    }
}

