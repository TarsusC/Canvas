using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel.Figures
{
    /// <summary>
    /// Содержит список доступных фигур
    /// для отрисовки.
    /// </summary>
    public class FigureInstanceList
    {
        public List<IFigure> Instances { get; set; }
    }
}
