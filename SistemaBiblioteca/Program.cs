using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_CRUD
{
    /// <summary>
    /// Classe principal do programa.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread] // Define o modelo de threading do aplicativo como Single Thread Apartment.
        static void Main()
        {
            // Habilita estilos visuais para os controles do Windows Forms.
            Application.EnableVisualStyles();

            // Configura o aplicativo para usar renderização de texto compatível.
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia o formulário principal do aplicativo.
            Application.Run(new Form1());
        }
    }
}
