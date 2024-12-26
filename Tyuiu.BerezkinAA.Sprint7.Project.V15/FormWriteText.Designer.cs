namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
{
    partial class FormWriteText
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
            textBoxLabelColumn_BAA = new TextBox();
            textBoxInputLabelColumn_BAA = new TextBox();
            buttonOK_BAA = new Button();
            SuspendLayout();
            // 
            // textBoxLabelColumn_BAA
            // 
            textBoxLabelColumn_BAA.BorderStyle = BorderStyle.None;
            textBoxLabelColumn_BAA.Dock = DockStyle.Fill;
            textBoxLabelColumn_BAA.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxLabelColumn_BAA.Location = new Point(0, 0);
            textBoxLabelColumn_BAA.Name = "textBoxLabelColumn_BAA";
            textBoxLabelColumn_BAA.ReadOnly = true;
            textBoxLabelColumn_BAA.Size = new Size(273, 24);
            textBoxLabelColumn_BAA.TabIndex = 0;
            textBoxLabelColumn_BAA.TabStop = false;
            textBoxLabelColumn_BAA.Text = "Введите название столбца";
            textBoxLabelColumn_BAA.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxInputLabelColumn_BAA
            // 
            textBoxInputLabelColumn_BAA.BackColor = Color.Silver;
            textBoxInputLabelColumn_BAA.BorderStyle = BorderStyle.None;
            textBoxInputLabelColumn_BAA.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInputLabelColumn_BAA.Location = new Point(16, 38);
            textBoxInputLabelColumn_BAA.Name = "textBoxInputLabelColumn_BAA";
            textBoxInputLabelColumn_BAA.Size = new Size(245, 18);
            textBoxInputLabelColumn_BAA.TabIndex = 1;
            textBoxInputLabelColumn_BAA.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonOK_BAA
            // 
            buttonOK_BAA.BackColor = Color.Silver;
            buttonOK_BAA.Location = new Point(174, 71);
            buttonOK_BAA.Name = "buttonOK_BAA";
            buttonOK_BAA.Size = new Size(87, 27);
            buttonOK_BAA.TabIndex = 2;
            buttonOK_BAA.Text = "OK";
            buttonOK_BAA.UseVisualStyleBackColor = false;
            buttonOK_BAA.Click += buttonOK_BAA_Click;
            // 
            // FormWriteText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 104);
            Controls.Add(buttonOK_BAA);
            Controls.Add(textBoxInputLabelColumn_BAA);
            Controls.Add(textBoxLabelColumn_BAA);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormWriteText";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Уведомление!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLabelColumn_BAA;
        private System.Windows.Forms.TextBox textBoxInputLabelColumn_BAA;
        private System.Windows.Forms.Button buttonOK_BAA;

    }
}