using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel.Figures
{
    public interface IFigure : ICast
    {
        void Draw(Pen pen, Graphics graphics, int centerX, int centerY, int figureWidth, int figureHeight);
    }
}
