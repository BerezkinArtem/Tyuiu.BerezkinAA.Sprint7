using System.Windows.Forms;

namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            textBoxManual_BAA = new TextBox();
            buttonOK_BAA = new Button();
            groupBoxManual = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBoxChart_BAA = new PictureBox();
            pictureBoxSearch_BAA = new PictureBox();
            label1 = new Label();
            groupBoxManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_BAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BAA).BeginInit();
            SuspendLayout();
            // 
            // textBoxManual_BAA
            // 
            textBoxManual_BAA.BorderStyle = BorderStyle.None;
            textBoxManual_BAA.Location = new Point(9, 22);
            textBoxManual_BAA.Multiline = true;
            textBoxManual_BAA.Name = "textBoxManual_BAA";
            textBoxManual_BAA.ReadOnly = true;
            textBoxManual_BAA.Size = new Size(757, 521);
            textBoxManual_BAA.TabIndex = 0;
            textBoxManual_BAA.TabStop = false;
            // 
            // buttonOK_BAA
            // 
            buttonOK_BAA.Location = new Point(662, 949);
            buttonOK_BAA.Name = "buttonOK_BAA";
            buttonOK_BAA.Size = new Size(87, 27);
            buttonOK_BAA.TabIndex = 3;
            buttonOK_BAA.Text = "OK";
            buttonOK_BAA.UseVisualStyleBackColor = true;
            buttonOK_BAA.Click += buttonOK_BAA_Click;
            // 
            // groupBoxManual
            // 
            groupBoxManual.Controls.Add(label1);
            groupBoxManual.Controls.Add(pictureBox1);
            groupBoxManual.Controls.Add(pictureBoxChart_BAA);
            groupBoxManual.Controls.Add(buttonOK_BAA);
            groupBoxManual.Controls.Add(pictureBoxSearch_BAA);
            groupBoxManual.Controls.Add(textBoxManual_BAA);
            groupBoxManual.Location = new Point(3, 2);
            groupBoxManual.Name = "groupBoxManual";
            groupBoxManual.Size = new Size(752, 982);
            groupBoxManual.TabIndex = 4;
            groupBoxManual.TabStop = false;
            groupBoxManual.Text = "Инструкция";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 811);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 161);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxChart_BAA
            // 
            pictureBoxChart_BAA.Location = new Point(12, 634);
            pictureBoxChart_BAA.Name = "pictureBoxChart_BAA";
            pictureBoxChart_BAA.Size = new Size(411, 60);
            pictureBoxChart_BAA.TabIndex = 2;
            pictureBoxChart_BAA.TabStop = false;
            // 
            // pictureBoxSearch_BAA
            // 
            pictureBoxSearch_BAA.Location = new Point(12, 751);
            pictureBoxSearch_BAA.Name = "pictureBoxSearch_BAA";
            pictureBoxSearch_BAA.Size = new Size(159, 29);
            pictureBoxSearch_BAA.TabIndex = 2;
            pictureBoxSearch_BAA.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(736, 420);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBoxManual);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FormManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство Пользователя";
            groupBoxManual.ResumeLayout(false);
            groupBoxManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_BAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_BAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxManual_BAA;
        private System.Windows.Forms.Button buttonOK_BAA;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.PictureBox pictureBoxChart_BAA;
        private System.Windows.Forms.PictureBox pictureBoxSearch_BAA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
    }
}