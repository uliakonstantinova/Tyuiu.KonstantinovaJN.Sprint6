namespace Tyuiu.KonstantinovaJN.Sprint6.Task6.V13
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 109);
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
            textBox1.Size = new Size(698, 68);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Location = new Point(12, 208);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(354, 277);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(6, 26);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(334, 236);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(372, 208);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(354, 277);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(334, 236);
            textBoxResult.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.Control;
            buttonOpenFile.BackgroundImage = (Image)resources.GetObject("buttonOpenFile.BackgroundImage");
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(93, 73);
            buttonOpenFile.TabIndex = 3;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Control;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(111, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 73);
            buttonDone.TabIndex = 4;
            toolTip.SetToolTip(buttonDone, "Производит поиск в файле входящих символов и конкатенирует строки, в которых находятся эти символы.");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Control;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(627, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 73);
            buttonHelp.TabIndex = 5;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // toolTip
            // 
            toolTip.BackColor = Color.IndianRed;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 497);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Константинова Ю. Н.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBoxOutPutData;
        private GroupBox groupBoxResult;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonHelp;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
    }
}
