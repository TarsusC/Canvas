using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public interface IViewMainForm
    {
        event EventHandler Draw;
        List<string> SetComboBoxFigureValue { set; }
        List<string> SetComboBoxColorValue {  set; }

        int SetComboBoxFigureSelectedIndex { set; }
        int SetComboBoxColorSelectedIndex { set; }
        PictureBox GetPictureBox { get; }
        string GetComboBoxFigureValue { get; }
        string GetComboBoxColorValue { get; }

        int GetPictureBoxWidth { get; }
        int GetPictureBoxHeight { get; }

    }
}
