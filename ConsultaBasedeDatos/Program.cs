using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//David Gomez 20359596 y Brian Johnson 19496477

namespace ConsultaBasedeDatos
{
    public static class global
    {
        public static String nombremaestro = Environment.MachineName;
    }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
