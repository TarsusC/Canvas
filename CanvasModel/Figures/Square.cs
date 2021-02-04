using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel.Figures
{
    public class Square : IFigure
    {
        public string Name => "Square";

        public void Draw(Pen pen, Graphics graphics, int centerX, int centerY, int figureWidth, int figureHeight)
        {
            graphics.DrawRectangle(pen, centerX - figureWidth/2, centerY - figureHeight/2, figureWidth, figureHeight);
        }
    }
}
