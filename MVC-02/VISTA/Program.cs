using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool salir = false;
            while (!salir)
            {
                frmInicio frmInicio = new frmInicio();
                Application.Run(frmInicio);
                if (frmInicio.successLogin)
                {
                    frmMenu menu = new frmMenu();
                    Application.Run(menu);
                }
                else
                {
                    salir = true;
                }
            }
        }
    }
}
