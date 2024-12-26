namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
{
    partial class FormAboutDeveloper
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
            textBoxAboutProgram = new TextBox();
            pictureBoxDeveloper = new PictureBox();
            buttonOK = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutProgram
            // 
            textBoxAboutProgram.BorderStyle = BorderStyle.None;
            textBoxAboutProgram.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAboutProgram.Location = new Point(198, 16);
            textBoxAboutProgram.Multiline = true;
            textBoxAboutProgram.Name = "textBoxAboutProgram";
            textBoxAboutProgram.ReadOnly = true;
            textBoxAboutProgram.Size = new Size(331, 199);
            textBoxAboutProgram.TabIndex = 3;
            textBoxAboutProgram.TabStop = false;
            // 
            // pictureBoxDeveloper
            // 
            pictureBoxDeveloper.BackColor = Color.Black;
            pictureBoxDeveloper.Image = Properties.Resources.photo_2024_12_26_01_07_03;
            pictureBoxDeveloper.Location = new Point(33, 16);
            pictureBoxDeveloper.Name = "pictureBoxDeveloper";
            pictureBoxDeveloper.Size = new Size(138, 182);
            pictureBoxDeveloper.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDeveloper.TabIndex = 4;
            pictureBoxDeveloper.TabStop = false;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(192, 255, 255);
            buttonOK.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(391, 188);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(87, 27);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_BAA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 50);
            label1.Name = "label1";
            label1.Size = new Size(303, 105);
            label1.TabIndex = 6;
            label1.Text = "Разработчик: Березкин А.А.\r\nГруппа ИСПб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024";
            // 
            // FormAboutDeveloper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(536, 223);
            Controls.Add(label1);
            Controls.Add(buttonOK);
            Controls.Add(pictureBoxDeveloper);
            Controls.Add(textBoxAboutProgram);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAboutDeveloper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAboutProgram;
        private System.Windows.Forms.PictureBox pictureBoxDeveloper;
        private System.Windows.Forms.Button buttonOK;
        private Label label1;

    }
}