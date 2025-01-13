using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

static class Global
{
    public static string userLogin;

}

namespace RentacarDefinitivo
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
            
            login lg = new login();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new nuevoDisenyo());
            }
        }
    }
}
