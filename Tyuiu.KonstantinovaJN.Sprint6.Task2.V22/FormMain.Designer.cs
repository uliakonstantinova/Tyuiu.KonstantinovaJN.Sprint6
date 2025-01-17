
namespace Tyuiu.KonstantinovaJN.Sprint6.Task2.V22
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            textBoxStopValue = new TextBox();
            groupBox3 = new GroupBox();
            textBoxStartValue = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(474, 50);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Протабулировать функцию cos(x) на заданном диапазоне. \r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(12, 264);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStopValue);
            groupBox4.Location = new Point(141, 37);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 59);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Конец шага:";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(28, 26);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.ReadOnly = true;
            textBoxStopValue.Size = new Size(68, 27);
            textBoxStopValue.TabIndex = 0;
            textBoxStopValue.TabStop = false;
            textBoxStopValue.Text = "5";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStartValue);
            groupBox3.Location = new Point(6, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(120, 59);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Старт шага:";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(27, 26);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.ReadOnly = true;
            textBoxStartValue.Size = new Size(61, 27);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.TabStop = false;
            textBoxStartValue.Text = "-5";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ButtonShadow;
            buttonHelp.Location = new Point(289, 299);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(91, 55);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.CadetBlue;
            buttonDone.Location = new Point(386, 299);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(123, 55);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Location = new Point(526, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(602, 363);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод данных:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(chartFunction);
            groupBox6.Controls.Add(dataGridViewFunction);
            groupBox6.Location = new Point(26, 46);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(551, 302);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Результат:";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(142, 26);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(403, 270);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chartFuction";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction.Location = new Point(6, 26);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(130, 270);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "x";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 385);
            Controls.Add(groupBox5);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Константинова Ю. Н.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStopValue;
        private GroupBox groupBox3;
        private TextBox textBoxStartValue;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
