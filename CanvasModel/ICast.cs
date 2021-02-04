using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel
{
    /// <summary>
    /// Является общим типом для
    /// типов IColor, IFigure.
    /// Возможно использовать как ограничение в типе Finder.
    /// </summary>
    public interface ICast
    {
        string Name { get; }
    }
}
