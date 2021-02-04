using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canvas;


namespace Canvas
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewMainForm viewMainForm = new ViewMainForm();
            CanvasPresenter canvasPresenter = new CanvasPresenter(viewMainForm);

            Application.Run(viewMainForm);
        }
    }
}
