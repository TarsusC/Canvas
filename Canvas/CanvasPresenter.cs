using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanvasModel;
using CanvasModel.Colors;
using CanvasModel.Figures ;


namespace Canvas
{
    /// <summary>
    /// Экземпляр класса - представляет слой Presenter 
    /// шаблона MVP.
    /// Назначение - связываение View и Model.
    /// </summary>
    public class CanvasPresenter
    {
        private  IViewMainForm viewMainForm;
        private  Painter painter;
        private  ColorsInstanceList colorsInstanceList;
        private  FigureInstanceList figureInstanceList;

        public CanvasPresenter(IViewMainForm viewMainForm)
        {
            this.viewMainForm = viewMainForm;
            viewMainForm.Draw += ViewMainForm_Draw;

            InitCanvasModelLayer();
            InitViewMainForm();
        }
        /// <summary>
        /// Создание экземпляров классов
        /// слоя Model шаблона MVP.
        /// </summary>
        void InitCanvasModelLayer()
        {
            painter = new Painter(viewMainForm.GetPictureBoxWidth, viewMainForm.GetPictureBoxHeight);
            colorsInstanceList = new ColorsInstanceList();
            figureInstanceList = new FigureInstanceList();
            figureInstanceList.Instances = TypeFinder.CreateInstances<IFigure>();
            colorsInstanceList.Instances = TypeFinder.CreateInstances<IColor>();
        }
        /// <summary>
        /// Инициализация элементов формы.
        /// Заполняются списки доступных фигур
        /// и досупные цвета элементов ComboBox 
        /// для отрисовки
        /// </summary>
        void InitViewMainForm()
        {
            viewMainForm.SetComboBoxFigureValue = TypeFinder.GetNames<IFigure>(figureInstanceList.Instances);
            viewMainForm.SetComboBoxFigureSelectedIndex = 0;
            viewMainForm.SetComboBoxColorValue = TypeFinder.GetNames<IColor>(colorsInstanceList.Instances);
            viewMainForm.SetComboBoxColorSelectedIndex = 0;
        }

        /// <summary>
        /// Получение типа фигуры и цвета.
        /// Очистка хлста. Отрисовка.
        /// </summary>
        private void ViewMainForm_Draw(object sender, EventArgs e)
        {
            var figure = from fig in figureInstanceList.Instances
                         where fig.Name == viewMainForm.GetComboBoxFigureValue
                         select fig;
            var color = from col in colorsInstanceList.Instances
                        where col.Name == viewMainForm.GetComboBoxColorValue
                        select col;
            painter.Clear(viewMainForm.GetPictureBox.BackColor);
            viewMainForm.GetPictureBox.Image = painter.Draw(figure.First(), color.First());
        }
    }
}
