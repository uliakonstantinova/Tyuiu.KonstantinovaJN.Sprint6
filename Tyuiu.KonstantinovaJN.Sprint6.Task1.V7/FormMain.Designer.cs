namespace Tyuiu.KonstantinovaJN.Sprint6.Task1.V7
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
            groupBox1 = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVD = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxStopValue = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStartValue = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            textBoxResult = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox1.SuspendLayout();
            groupBoxVD.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTask);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = Color.WhiteSmoke;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(424, 50);
            textBoxTask.TabIndex = 0;
            textBoxTask.TabStop = false;
            textBoxTask.Text = "Протабулировать функцию cos(x) на заданном диапазоне. \r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxVD
            // 
            groupBoxVD.Controls.Add(groupBox3);
            groupBoxVD.Controls.Add(groupBox2);
            groupBoxVD.Location = new Point(12, 265);
            groupBoxVD.Name = "groupBoxVD";
            groupBoxVD.Size = new Size(292, 104);
            groupBoxVD.TabIndex = 1;
            groupBoxVD.TabStop = false;
            groupBoxVD.Text = "Ввод данных:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStopValue);
            groupBox3.Location = new Point(157, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(129, 65);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Конец шага:";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(26, 29);
            textBoxStopValue.Multiline = true;
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.ReadOnly = true;
            textBoxStopValue.Size = new Size(78, 27);
            textBoxStopValue.TabIndex = 0;
            textBoxStopValue.TabStop = false;
            textBoxStopValue.Text = "5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStartValue);
            groupBox2.Location = new Point(6, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(132, 66);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Старт шага:";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(23, 29);
            textBoxStartValue.Multiline = true;
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.ReadOnly = true;
            textBoxStartValue.Size = new Size(81, 27);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.TabStop = false;
            textBoxStartValue.Text = "-5";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(541, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 353);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Вывод данных:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxResult);
            groupBox5.Location = new Point(6, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(238, 314);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 31);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(226, 268);
            textBoxResult.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Tan;
            buttonHelp.Location = new Point(310, 295);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(87, 56);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.CadetBlue;
            buttonDone.Location = new Point(403, 295);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(132, 56);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox4);
            Controls.Add(groupBoxVD);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Константинова Ю. Н.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxVD.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxTask;
        private GroupBox groupBoxVD;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBoxResult;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
    }
}
