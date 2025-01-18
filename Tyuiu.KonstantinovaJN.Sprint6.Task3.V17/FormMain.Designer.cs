
namespace Tyuiu.KonstantinovaJN.Sprint6.Task3.V17
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
            dataGridViewStart = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewResult = new DataGridView();
            groupBoxRes = new GroupBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewStart
            // 
            dataGridViewStart.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewStart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStart.Location = new Point(222, 36);
            dataGridViewStart.Name = "dataGridViewStart";
            dataGridViewStart.RowHeadersVisible = false;
            dataGridViewStart.RowHeadersWidth = 51;
            dataGridViewStart.Size = new Size(251, 246);
            dataGridViewStart.TabIndex = 0;
            dataGridViewStart.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridViewStart);
            groupBox1.Location = new Point(4, -5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 317);
            groupBox1.TabIndex = 1;
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
            textBox1.Size = new Size(210, 185);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "Дана матрица 5 на 5:\r\n22, 32, -16, 24, 27 \r\n3, -20, 24, -20, 25 \r\n21, 17, -8, -19, 17\r\n8, 22, 28, 27, 19\r\n11, 20, 12, 27, 29\r\nВыполнить сортировку по возрастанию в четвертом столбце.\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBoxRes);
            groupBox2.Location = new Point(495, -5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 317);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(9, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(251, 246);
            dataGridViewResult.TabIndex = 1;
            dataGridViewResult.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewResult);
            groupBoxRes.Location = new Point(19, 26);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(266, 282);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат:";
            groupBoxRes.Enter += groupBox3_Enter;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Control;
            buttonDone.Location = new Point(676, 318);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(110, 38);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Control;
            buttonHelp.Location = new Point(617, 320);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(53, 35);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 365);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Константинова Ю. Н.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            groupBoxRes.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridViewRes;
        private DataGridView dataGridViewStart;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBoxRes;
        private DataGridView dataGridViewResult;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
