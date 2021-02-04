using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class ViewMainForm : Form, IViewMainForm
    {
        public ViewMainForm()
        {
            InitializeComponent();
            buttonDraw.Click += ButtonDraw_Click;
        }
        #region Реализация IViewMainForm
        public List<string> SetComboBoxFigureValue {  set => comboBoxFigure.Items.AddRange(value.ToArray()); }
        public List<string> SetComboBoxColorValue {  set => comboBoxColor.Items.AddRange(value.ToArray()); }

        public string GetComboBoxFigureValue  {  get => comboBoxFigure.Text ; }
        public string GetComboBoxColorValue { get => comboBoxColor.Text ; }
        public int GetPictureBoxWidth { get => pictureBoxCanvas.Width; }
        public int GetPictureBoxHeight { get => pictureBoxCanvas.Height; }
        public PictureBox GetPictureBox { get => pictureBoxCanvas; }
        public int SetComboBoxFigureSelectedIndex { set => comboBoxFigure.SelectedIndex = value; }
        public int SetComboBoxColorSelectedIndex { set => comboBoxColor.SelectedIndex = value; }

        public event EventHandler Draw;
        #endregion
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            Draw?.Invoke(this, e);
        }

    }
}
