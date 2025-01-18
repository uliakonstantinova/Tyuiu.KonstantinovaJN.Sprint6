namespace Tyuiu.KonstantinovaJN.Sprint6.Task4.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            textBoxStopValue = new TextBox();
            groupBox3 = new GroupBox();
            textBoxStartValue = new TextBox();
            groupBox5 = new GroupBox();
            textBoxResult = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(26, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(525, 73);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Протабулировать функцию cos(x) на заданном диапазоне от -5 до 5. \r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажатию кнопки.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(605, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStopValue);
            groupBox4.Location = new Point(157, 39);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(118, 70);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Конец шага:";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.BackColor = Color.WhiteSmoke;
            textBoxStopValue.Location = new Point(29, 33);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(57, 27);
            textBoxStopValue.TabIndex = 0;
            textBoxStopValue.TabStop = false;
            textBoxStopValue.Text = "5";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStartValue);
            groupBox3.Location = new Point(16, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 70);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Старт шага:";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(31, 33);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(53, 27);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.TabStop = false;
            textBoxStartValue.Text = "-5";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxResult);
            groupBox5.Location = new Point(15, 149);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(293, 289);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод данных:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(34, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(226, 253);
            textBoxResult.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(341, 156);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(694, 272);
            chartFunction.TabIndex = 3;
            chartFunction.Text = "chart1";
            title1.ForeColor = Color.Red;
            title1.Name = "TitleCos";
            title1.Text = "График функции cos(x)";
            chartFunction.Titles.Add(title1);
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.CadetBlue;
            buttonDone.Location = new Point(922, 21);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(101, 37);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonShadow;
            buttonSave.Location = new Point(922, 64);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(101, 35);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.MarginChanged += buttonSave_Click;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ButtonFace;
            buttonHelp.Location = new Point(922, 105);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(101, 32);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 443);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(chartFunction);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 27 | Константинова Ю. Н.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private GroupBox groupBox5;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
    }
}
