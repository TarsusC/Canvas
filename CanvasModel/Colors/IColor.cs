using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasModel.Colors
{
    public interface IColor : ICast
    {
        //string Name { get; }
        Color Color { get; }
    }
}
