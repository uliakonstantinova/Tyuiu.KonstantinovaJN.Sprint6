namespace Tyuiu.KonstantinovaJN.Sprint6.Task7.V11
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonSaveFile = new Button();
            buttonHelp = new Button();
            panelTop = new Panel();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            panelLeft = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewInPut = new DataGridView();
            panelRight = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewOutPut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelTop.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).BeginInit();
            panelRight.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(102, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(84, 61);
            buttonDone.TabIndex = 0;
            toolTipButton.SetToolTip(buttonDone, "Выполнить\r\nВыполнить обработку данных");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(84, 61);
            buttonOpenFile.TabIndex = 1;
            toolTipButton.SetToolTip(buttonOpenFile, "Открыть файл  \r\nОткрыть файл для обработки данных в формате CSV");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(192, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(84, 61);
            buttonSaveFile.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSaveFile, "Сохранить в файл  \r\nСохранить обработанные данные в файл в формате CSV");
            buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(704, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(84, 61);
            buttonHelp.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp, "Сведение \r\nСведение о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonSaveFile);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 85);
            panelTop.TabIndex = 4;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Location = new Point(0, 79);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(800, 137);
            panelTask.TabIndex = 5;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(12, 5);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 125);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(764, 93);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBox2);
            panelLeft.Location = new Point(0, 215);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(475, 289);
            panelLeft.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewInPut);
            groupBox2.Location = new Point(12, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 270);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // dataGridViewInPut
            // 
            dataGridViewInPut.BackgroundColor = SystemColors.Control;
            dataGridViewInPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut.Location = new Point(6, 22);
            dataGridViewInPut.Name = "dataGridViewInPut";
            dataGridViewInPut.RowHeadersWidth = 51;
            dataGridViewInPut.Size = new Size(454, 242);
            dataGridViewInPut.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBox3);
            panelRight.Location = new Point(474, 215);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(326, 289);
            panelRight.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOutPut);
            groupBox3.Location = new Point(0, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 270);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.BackgroundColor = SystemColors.Control;
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Location = new Point(6, 22);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.RowHeadersWidth = 51;
            dataGridViewOutPut.Size = new Size(295, 242);
            dataGridViewOutPut.TabIndex = 0;
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTask);
            Controls.Add(panelTop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 11 | Константинова Ю. Н.";
            panelTop.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).EndInit();
            panelRight.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonSaveFile;
        private Button buttonHelp;
        private Panel panelTop;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private Panel panelLeft;
        private GroupBox groupBox2;
        private Panel panelRight;
        private GroupBox groupBox3;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private DataGridView dataGridViewInPut;
        private DataGridView dataGridViewOutPut;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
