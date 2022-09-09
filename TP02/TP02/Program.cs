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
            try
            {
                logger.Info("Hello world");
                System.Console.ReadKey();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Goodbye cruel world");
            }

            InterfazDatos instituto = new InterfazDatos();

            instituto.CargarAlumno();
        }
    }
}

