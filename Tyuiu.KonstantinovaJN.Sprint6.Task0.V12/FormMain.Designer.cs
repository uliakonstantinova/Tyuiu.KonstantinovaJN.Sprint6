namespace Tyuiu.KonstantinovaJN.Sprint6.Task0.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTasks = new TextBox();
            groupBoxVD = new GroupBox();
            groupBoxVarX = new GroupBox();
            textBoxX = new TextBox();
            groupBoxVVD = new GroupBox();
            groupBoxRes = new GroupBox();
            textBoxResult = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxVD.SuspendLayout();
            groupBoxVarX.SuspendLayout();
            groupBoxVVD.SuspendLayout();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxTasks);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 184);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.Снимок_экрана_2024_12_25_234331;
            pictureBoxFormula.InitialImage = (Image)resources.GetObject("pictureBoxFormula.InitialImage");
            pictureBoxFormula.Location = new Point(476, 52);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(238, 89);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxTasks
            // 
            textBoxTasks.Location = new Point(33, 80);
            textBoxTasks.Multiline = true;
            textBoxTasks.Name = "textBoxTasks";
            textBoxTasks.ReadOnly = true;
            textBoxTasks.Size = new Size(263, 27);
            textBoxTasks.TabIndex = 0;
            textBoxTasks.TabStop = false;
            textBoxTasks.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVD
            // 
            groupBoxVD.Controls.Add(groupBoxVarX);
            groupBoxVD.Location = new Point(12, 222);
            groupBoxVD.Name = "groupBoxVD";
            groupBoxVD.Size = new Size(352, 162);
            groupBoxVD.TabIndex = 1;
            groupBoxVD.TabStop = false;
            groupBoxVD.Text = "Ввод данных:";
            // 
            // groupBoxVarX
            // 
            groupBoxVarX.Controls.Add(textBoxX);
            groupBoxVarX.Location = new Point(86, 41);
            groupBoxVarX.Name = "groupBoxVarX";
            groupBoxVarX.Size = new Size(166, 91);
            groupBoxVarX.TabIndex = 3;
            groupBoxVarX.TabStop = false;
            groupBoxVarX.Text = "Переменная Х:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(36, 47);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(87, 27);
            textBoxX.TabIndex = 4;
            textBoxX.KeyPress += textBoxX_KeyPress;
            // 
            // groupBoxVVD
            // 
            groupBoxVVD.Controls.Add(groupBoxRes);
            groupBoxVVD.Location = new Point(398, 222);
            groupBoxVVD.Name = "groupBoxVVD";
            groupBoxVVD.Size = new Size(390, 162);
            groupBoxVVD.TabIndex = 2;
            groupBoxVVD.TabStop = false;
            groupBoxVVD.Text = "Вывод данных:";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(120, 46);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(163, 86);
            groupBoxRes.TabIndex = 5;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(35, 42);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(90, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(608, 396);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(56, 42);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.KeyPress += textBoxX_KeyPress;
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Location = new Point(670, 396);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(118, 42);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxVVD);
            Controls.Add(groupBoxVD);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Константинова Ю. Н.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxVD.ResumeLayout(false);
            groupBoxVarX.ResumeLayout(false);
            groupBoxVarX.PerformLayout();
            groupBoxVVD.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTasks;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxVD;
        private GroupBox groupBoxVarX;
        private TextBox textBoxX;
        private GroupBox groupBoxVVD;
        private GroupBox groupBoxRes;
        private TextBox textBoxResult;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
