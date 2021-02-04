using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel
{
    /// <summary>
    /// Отрисовка фигуры.
    /// </summary>
    public class Painter
    {
        private readonly Bitmap bitmap;
        private readonly Graphics graphics;
        private readonly double coefFigureSize = 0.8;
        private readonly int penWidth = 10;
        private int figureWidth;
        private int figureHeight;
        private int centerX;
        private int centerY;
        
        public Painter(int pictureBoxWidth, int pictureBoxHeight)
        {
            figureWidth = (int)(pictureBoxWidth * coefFigureSize);
            figureHeight = (int)(pictureBoxHeight * coefFigureSize);
            centerY = pictureBoxHeight / 2;
            centerX = pictureBoxWidth / 2;

            bitmap = new Bitmap( pictureBoxWidth,  pictureBoxHeight);
            graphics = Graphics.FromImage(bitmap);
        }
        /// <summary>
        /// Отрисовка фигуры. 
        /// Принимает фигуру и цвет как входные параметры.
        /// На типе фигура вызывает метод Draw().
        /// </summary>
        public Bitmap Draw(Figures.IFigure figure, Colors.IColor color)
        {  
            Pen pen = new Pen(color.Color, penWidth);
            figure.Draw(pen, graphics, centerX, centerY, figureWidth, figureHeight);
            return bitmap;       
        }
        /// <summary>
        /// Очистка холста.
        /// </summary>
        public void Clear(Color initColor)
        {
            graphics.Clear(initColor);
        }

    }
}
