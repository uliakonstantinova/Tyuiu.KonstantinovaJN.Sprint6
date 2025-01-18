namespace Tyuiu.KonstantinovaJN.Sprint6.Task7.V11
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar = new PictureBox();
            labelInfo = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackgroundImage = (Image)resources.GetObject("pictureBoxAvatar.BackgroundImage");
            pictureBoxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar.Location = new Point(12, 12);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(162, 202);
            pictureBoxAvatar.TabIndex = 2;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(180, 12);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(395, 180);
            labelInfo.TabIndex = 4;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // buttonOk
            // 
            buttonOk.BackColor = SystemColors.Control;
            buttonOk.Location = new Point(481, 201);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ок";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            buttonOk.MouseClick += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 242);
            Controls.Add(buttonOk);
            Controls.Add(labelInfo);
            Controls.Add(pictureBoxAvatar);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private Label labelInfo;
        private Button buttonOk;
    }
}