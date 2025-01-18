
namespace Tyuiu.KonstantinovaJN.Sprint6.Task5.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(6, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(619, 53);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V7.txt. Вывести в dataGridView. Дан список из 20 чисел. Вывести все числа, больше 5. Построить диаграмму по этим значениям.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewResult);
            groupBox2.Location = new Point(12, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 320);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(17, 33);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(156, 274);
            dataGridViewResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(666, 22);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 29);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(666, 57);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 50);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Открыть файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(666, 113);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(112, 29);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(225, 158);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(554, 307);
            chartFunction.TabIndex = 5;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(chartFunction);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 7 | Константинова Ю. Н.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewResult;
    }
}
