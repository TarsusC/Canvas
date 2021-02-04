using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel.Colors
{
    /// <summary>
    /// Содержит список экземпляров
    /// типа IColor. Список доступных цветов фигуры.
    /// </summary>
    public class ColorsInstanceList
    {
        public  List<IColor> Instances { get; set; }
    }
}
