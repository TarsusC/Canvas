namespace Canvas
{
    partial class ViewMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFigure = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.groupBoxCanvas = new System.Windows.Forms.GroupBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.groupBoxCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(13, 13);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(36, 13);
            this.labelFigure.TabIndex = 1;
            this.labelFigure.Text = "Figure";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(14, 44);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Color";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(157, 84);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "DRAW";
            this.buttonDraw.UseVisualStyleBackColor = true;
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Location = new System.Drawing.Point(111, 10);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigure.TabIndex = 4;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(111, 41);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 5;
            // 
            // groupBoxCanvas
            // 
            this.groupBoxCanvas.Controls.Add(this.pictureBoxCanvas);
            this.groupBoxCanvas.Location = new System.Drawing.Point(260, 4);
            this.groupBoxCanvas.Name = "groupBoxCanvas";
            this.groupBoxCanvas.Size = new System.Drawing.Size(536, 439);
            this.groupBoxCanvas.TabIndex = 6;
            this.groupBoxCanvas.TabStop = false;
            this.groupBoxCanvas.Text = "Picture";
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(530, 420);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // ViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCanvas);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelFigure);
            this.Name = "ViewMainForm";
            this.Text = "Canvas Rembrandt";
            this.groupBoxCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.GroupBox groupBoxCanvas;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
    }
}

