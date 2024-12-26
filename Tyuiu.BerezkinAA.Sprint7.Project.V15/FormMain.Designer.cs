using System.Reflection.Emit;
using System.Windows.Forms;

namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
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
            dataGridViewTable_BAA = new DataGridView();
            saveFileDialogTable_BAA = new SaveFileDialog();
            openFileDialogTable_BAA = new OpenFileDialog();
            textBoxOutPutData_BAA = new TextBox();
            действияToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem_BAA = new ToolStripMenuItem();
            saveToolStripMenuItem_BAA = new ToolStripMenuItem();
            addToolStripMenuItem_BAA = new ToolStripMenuItem();
            AddRowsToolStripMenuItem_BAA = new ToolStripMenuItem();
            AddColumnsToolStripMenuItem_BAA = new ToolStripMenuItem();
            RemoveToolStripMenuItem_BAA = new ToolStripMenuItem();
            RemoveRowToolStripMenuItem_BAA = new ToolStripMenuItem();
            RemoveColumnToolStripMenuItem_BAA = new ToolStripMenuItem();
            CloseTableToolStripMenuItem_BAA = new ToolStripMenuItem();
            aboutProgramToolStripMenuItem_BAA = new ToolStripMenuItem();
            developerToolStripMenuItem_BAA = new ToolStripMenuItem();
            ManualToolStripMenuItem_BAA = new ToolStripMenuItem();
            exitToolStripMenuItem_BAA = new ToolStripMenuItem();
            CalculationToolStripMenuItem_BAA = new ToolStripMenuItem();
            MAXSumToolStripMenuItem_BAA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnMAX_BAA = new ToolStripTextBox();
            MINSumToolStripMenuItem_BAA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnMIN_BAA = new ToolStripTextBox();
            DohodToolStripMenuItem_BAA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnDohod_BAA = new ToolStripTextBox();
            AverageValueToolStripMenuItem_BAA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnAverageValue_BAA = new ToolStripTextBox();
            CountDocumentToolStripMenuItem_BAA = new ToolStripMenuItem();
            BuildChartToolStripMenuItem_BAA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnForChartName_BAA = new ToolStripTextBox();
            toolStripTextBoxInputColumnForChartData_BAA = new ToolStripTextBox();
            toolStripTextBoxSearch_BAA = new ToolStripTextBox();
            SearchToolStripMenuItem_BAA = new ToolStripMenuItem();
            menuStrip_BAA = new MenuStrip();
            comboBoxColumnForFilter_BAA = new ComboBox();
            textBoxInputFilter_BAA = new TextBox();
            buttonUseFilter_BAA = new Button();
            toolTip_BAA = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_BAA).BeginInit();
            menuStrip_BAA.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTable_BAA
            // 
            dataGridViewTable_BAA.AllowUserToAddRows = false;
            dataGridViewTable_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTable_BAA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTable_BAA.BackgroundColor = SystemColors.HighlightText;
            dataGridViewTable_BAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_BAA.GridColor = SystemColors.Window;
            dataGridViewTable_BAA.Location = new Point(160, 61);
            dataGridViewTable_BAA.Margin = new Padding(2);
            dataGridViewTable_BAA.Name = "dataGridViewTable_BAA";
            dataGridViewTable_BAA.RowHeadersVisible = false;
            dataGridViewTable_BAA.RowHeadersWidth = 51;
            dataGridViewTable_BAA.RowTemplate.Height = 24;
            dataGridViewTable_BAA.Size = new Size(1268, 398);
            dataGridViewTable_BAA.TabIndex = 1;
            // 
            // openFileDialogTable_BAA
            // 
            openFileDialogTable_BAA.FileName = "openFileDialog1";
            // 
            // textBoxOutPutData_BAA
            // 
            textBoxOutPutData_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOutPutData_BAA.BackColor = Color.White;
            textBoxOutPutData_BAA.BorderStyle = BorderStyle.None;
            textBoxOutPutData_BAA.Location = new Point(1040, 525);
            textBoxOutPutData_BAA.Name = "textBoxOutPutData_BAA";
            textBoxOutPutData_BAA.ReadOnly = true;
            textBoxOutPutData_BAA.Size = new Size(129, 16);
            textBoxOutPutData_BAA.TabIndex = 2;
            textBoxOutPutData_BAA.TabStop = false;
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.BackColor = Color.Silver;
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem_BAA, saveToolStripMenuItem_BAA, addToolStripMenuItem_BAA, RemoveToolStripMenuItem_BAA, CloseTableToolStripMenuItem_BAA });
            действияToolStripMenuItem.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            действияToolStripMenuItem.Image = Properties.Resources.free_icon_file_explorer_8721638;
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(104, 24);
            действияToolStripMenuItem.Text = "Действия";
            действияToolStripMenuItem.ToolTipText = "Меню базы данных";
            // 
            // openToolStripMenuItem_BAA
            // 
            openToolStripMenuItem_BAA.Name = "openToolStripMenuItem_BAA";
            openToolStripMenuItem_BAA.Size = new Size(189, 22);
            openToolStripMenuItem_BAA.Text = "Открыть";
            openToolStripMenuItem_BAA.ToolTipText = "Нажмите и выберите базу данных";
            openToolStripMenuItem_BAA.Click += openToolStripMenuItem_BAA_Click;
            // 
            // saveToolStripMenuItem_BAA
            // 
            saveToolStripMenuItem_BAA.Name = "saveToolStripMenuItem_BAA";
            saveToolStripMenuItem_BAA.Size = new Size(189, 22);
            saveToolStripMenuItem_BAA.Text = "Сохранить";
            saveToolStripMenuItem_BAA.ToolTipText = "Нажмите и сохраните базу данных";
            saveToolStripMenuItem_BAA.Click += saveToolStripMenuItem_BAA_Click;
            // 
            // addToolStripMenuItem_BAA
            // 
            addToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { AddRowsToolStripMenuItem_BAA, AddColumnsToolStripMenuItem_BAA });
            addToolStripMenuItem_BAA.Name = "addToolStripMenuItem_BAA";
            addToolStripMenuItem_BAA.Size = new Size(189, 22);
            addToolStripMenuItem_BAA.Text = "Добавить";
            addToolStripMenuItem_BAA.ToolTipText = "Добавление строки или столбца";
            // 
            // AddRowsToolStripMenuItem_BAA
            // 
            AddRowsToolStripMenuItem_BAA.Name = "AddRowsToolStripMenuItem_BAA";
            AddRowsToolStripMenuItem_BAA.Size = new Size(131, 22);
            AddRowsToolStripMenuItem_BAA.Text = "Строку";
            AddRowsToolStripMenuItem_BAA.ToolTipText = "Добавится строка";
            AddRowsToolStripMenuItem_BAA.Click += AddRowsToolStripMenuItem_BAA_Click;
            // 
            // AddColumnsToolStripMenuItem_BAA
            // 
            AddColumnsToolStripMenuItem_BAA.Name = "AddColumnsToolStripMenuItem_BAA";
            AddColumnsToolStripMenuItem_BAA.Size = new Size(131, 22);
            AddColumnsToolStripMenuItem_BAA.Text = "Столбец";
            AddColumnsToolStripMenuItem_BAA.ToolTipText = "Добавится столбец";
            AddColumnsToolStripMenuItem_BAA.Click += AddColumnsToolStripMenuItem_BAA_Click;
            // 
            // RemoveToolStripMenuItem_BAA
            // 
            RemoveToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { RemoveRowToolStripMenuItem_BAA, RemoveColumnToolStripMenuItem_BAA });
            RemoveToolStripMenuItem_BAA.Name = "RemoveToolStripMenuItem_BAA";
            RemoveToolStripMenuItem_BAA.Size = new Size(189, 22);
            RemoveToolStripMenuItem_BAA.Text = "Удалить";
            RemoveToolStripMenuItem_BAA.ToolTipText = "Удалить строку или столбец";
            // 
            // RemoveRowToolStripMenuItem_BAA
            // 
            RemoveRowToolStripMenuItem_BAA.Name = "RemoveRowToolStripMenuItem_BAA";
            RemoveRowToolStripMenuItem_BAA.Size = new Size(131, 22);
            RemoveRowToolStripMenuItem_BAA.Text = "Строку";
            RemoveRowToolStripMenuItem_BAA.ToolTipText = "Удалиться выделенная строка";
            RemoveRowToolStripMenuItem_BAA.Click += RemoveRowToolStripMenuItem_BAA_Click;
            // 
            // RemoveColumnToolStripMenuItem_BAA
            // 
            RemoveColumnToolStripMenuItem_BAA.Name = "RemoveColumnToolStripMenuItem_BAA";
            RemoveColumnToolStripMenuItem_BAA.Size = new Size(131, 22);
            RemoveColumnToolStripMenuItem_BAA.Text = "Столбец";
            RemoveColumnToolStripMenuItem_BAA.ToolTipText = "удалиться последний столбец";
            RemoveColumnToolStripMenuItem_BAA.Click += RemoveColumnToolStripMenuItem_BAA_Click;
            // 
            // CloseTableToolStripMenuItem_BAA
            // 
            CloseTableToolStripMenuItem_BAA.Name = "CloseTableToolStripMenuItem_BAA";
            CloseTableToolStripMenuItem_BAA.Size = new Size(189, 22);
            CloseTableToolStripMenuItem_BAA.Text = "Закрыть таблицу";
            CloseTableToolStripMenuItem_BAA.ToolTipText = "Закрыть таблицу без сохранения";
            CloseTableToolStripMenuItem_BAA.Click += CloseTableToolStripMenuItem_BAA_Click;
            // 
            // aboutProgramToolStripMenuItem_BAA
            // 
            aboutProgramToolStripMenuItem_BAA.BackColor = Color.Silver;
            aboutProgramToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { developerToolStripMenuItem_BAA, ManualToolStripMenuItem_BAA });
            aboutProgramToolStripMenuItem_BAA.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aboutProgramToolStripMenuItem_BAA.Image = Properties.Resources.free_icon_information_2088076;
            aboutProgramToolStripMenuItem_BAA.Name = "aboutProgramToolStripMenuItem_BAA";
            aboutProgramToolStripMenuItem_BAA.Size = new Size(96, 24);
            aboutProgramToolStripMenuItem_BAA.Text = "Справка";
            // 
            // developerToolStripMenuItem_BAA
            // 
            developerToolStripMenuItem_BAA.Name = "developerToolStripMenuItem_BAA";
            developerToolStripMenuItem_BAA.Size = new Size(261, 22);
            developerToolStripMenuItem_BAA.Text = "Разработчик";
            developerToolStripMenuItem_BAA.ToolTipText = "Информация о разработчике";
            developerToolStripMenuItem_BAA.Click += developerToolStripMenuItem_BAA_Click;
            // 
            // ManualToolStripMenuItem_BAA
            // 
            ManualToolStripMenuItem_BAA.Name = "ManualToolStripMenuItem_BAA";
            ManualToolStripMenuItem_BAA.Size = new Size(261, 22);
            ManualToolStripMenuItem_BAA.Text = "Руководство пользователя";
            ManualToolStripMenuItem_BAA.ToolTipText = "Откроется краткое руководство пользователя";
            ManualToolStripMenuItem_BAA.Click += ManualToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem_BAA
            // 
            exitToolStripMenuItem_BAA.BackColor = Color.FromArgb(255, 128, 128);
            exitToolStripMenuItem_BAA.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem_BAA.Image = Properties.Resources.free_icon_log_out_3596149;
            exitToolStripMenuItem_BAA.Name = "exitToolStripMenuItem_BAA";
            exitToolStripMenuItem_BAA.Size = new Size(81, 24);
            exitToolStripMenuItem_BAA.Text = "Выход";
            exitToolStripMenuItem_BAA.ToolTipText = "Выход из приложения";
            exitToolStripMenuItem_BAA.Click += exitToolStripMenuItem_BAA_Click;
            // 
            // CalculationToolStripMenuItem_BAA
            // 
            CalculationToolStripMenuItem_BAA.BackColor = Color.Silver;
            CalculationToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { MAXSumToolStripMenuItem_BAA, MINSumToolStripMenuItem_BAA, DohodToolStripMenuItem_BAA, AverageValueToolStripMenuItem_BAA, CountDocumentToolStripMenuItem_BAA, BuildChartToolStripMenuItem_BAA });
            CalculationToolStripMenuItem_BAA.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalculationToolStripMenuItem_BAA.Image = Properties.Resources.free_icon_calculator_3486118;
            CalculationToolStripMenuItem_BAA.Name = "CalculationToolStripMenuItem_BAA";
            CalculationToolStripMenuItem_BAA.Size = new Size(124, 24);
            CalculationToolStripMenuItem_BAA.Text = "Вычисления";
            // 
            // MAXSumToolStripMenuItem_BAA
            // 
            MAXSumToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnMAX_BAA });
            MAXSumToolStripMenuItem_BAA.Name = "MAXSumToolStripMenuItem_BAA";
            MAXSumToolStripMenuItem_BAA.Size = new Size(288, 22);
            MAXSumToolStripMenuItem_BAA.Text = "Максимальная сумма договора";
            MAXSumToolStripMenuItem_BAA.ToolTipText = "В контекстном меню введите номер столбца с данными(счет начинается с нуля)";
            MAXSumToolStripMenuItem_BAA.Click += MAXSumToolStripMenuItem_BAA_Click;
            // 
            // toolStripTextBoxInputColumnMAX_BAA
            // 
            toolStripTextBoxInputColumnMAX_BAA.Name = "toolStripTextBoxInputColumnMAX_BAA";
            toolStripTextBoxInputColumnMAX_BAA.Size = new Size(100, 23);
            // 
            // MINSumToolStripMenuItem_BAA
            // 
            MINSumToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnMIN_BAA });
            MINSumToolStripMenuItem_BAA.Name = "MINSumToolStripMenuItem_BAA";
            MINSumToolStripMenuItem_BAA.Size = new Size(288, 22);
            MINSumToolStripMenuItem_BAA.Text = "Минимальная сумма договора";
            MINSumToolStripMenuItem_BAA.ToolTipText = "В контекстном меню введите номер столбца с данными(счет начинается с нуля)";
            MINSumToolStripMenuItem_BAA.Click += MINSumToolStripMenuItem_BAA_Click;
            // 
            // toolStripTextBoxInputColumnMIN_BAA
            // 
            toolStripTextBoxInputColumnMIN_BAA.Name = "toolStripTextBoxInputColumnMIN_BAA";
            toolStripTextBoxInputColumnMIN_BAA.Size = new Size(100, 23);
            // 
            // DohodToolStripMenuItem_BAA
            // 
            DohodToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnDohod_BAA });
            DohodToolStripMenuItem_BAA.Name = "DohodToolStripMenuItem_BAA";
            DohodToolStripMenuItem_BAA.Size = new Size(288, 22);
            DohodToolStripMenuItem_BAA.Text = "Доход";
            DohodToolStripMenuItem_BAA.ToolTipText = "В контекстном меню введите номер столбца с данными(счет начинается с нуля)";
            DohodToolStripMenuItem_BAA.Click += DohodToolStripMenuItem_BAA_Click;
            // 
            // toolStripTextBoxInputColumnDohod_BAA
            // 
            toolStripTextBoxInputColumnDohod_BAA.Name = "toolStripTextBoxInputColumnDohod_BAA";
            toolStripTextBoxInputColumnDohod_BAA.Size = new Size(100, 23);
            // 
            // AverageValueToolStripMenuItem_BAA
            // 
            AverageValueToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnAverageValue_BAA });
            AverageValueToolStripMenuItem_BAA.Name = "AverageValueToolStripMenuItem_BAA";
            AverageValueToolStripMenuItem_BAA.Size = new Size(288, 22);
            AverageValueToolStripMenuItem_BAA.Text = "Среднее значение ";
            AverageValueToolStripMenuItem_BAA.ToolTipText = "В контекстном меню введите номер столбца с данными(счет начинается с нуля)";
            AverageValueToolStripMenuItem_BAA.Click += AverageValueToolStripMenuItem_BAA_Click;
            // 
            // toolStripTextBoxInputColumnAverageValue_BAA
            // 
            toolStripTextBoxInputColumnAverageValue_BAA.Name = "toolStripTextBoxInputColumnAverageValue_BAA";
            toolStripTextBoxInputColumnAverageValue_BAA.Size = new Size(100, 23);
            // 
            // CountDocumentToolStripMenuItem_BAA
            // 
            CountDocumentToolStripMenuItem_BAA.Name = "CountDocumentToolStripMenuItem_BAA";
            CountDocumentToolStripMenuItem_BAA.Size = new Size(288, 22);
            CountDocumentToolStripMenuItem_BAA.Text = "Счётчик договоров";
            CountDocumentToolStripMenuItem_BAA.ToolTipText = "Будет подсчитано количесво договоров";
            CountDocumentToolStripMenuItem_BAA.Click += CountDocumentToolStripMenuItem_BAA_Click;
            // 
            // BuildChartToolStripMenuItem_BAA
            // 
            BuildChartToolStripMenuItem_BAA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnForChartName_BAA, toolStripTextBoxInputColumnForChartData_BAA });
            BuildChartToolStripMenuItem_BAA.Name = "BuildChartToolStripMenuItem_BAA";
            BuildChartToolStripMenuItem_BAA.Size = new Size(288, 22);
            BuildChartToolStripMenuItem_BAA.Text = "Построить диаграмму доходов";
            BuildChartToolStripMenuItem_BAA.ToolTipText = "В контекстном меню введите номер столбца с данными(счет начинается с нуля)";
            BuildChartToolStripMenuItem_BAA.Click += BuildChartToolStripMenuItem_BAA_Click;
            // 
            // toolStripTextBoxInputColumnForChartName_BAA
            // 
            toolStripTextBoxInputColumnForChartName_BAA.Name = "toolStripTextBoxInputColumnForChartName_BAA";
            toolStripTextBoxInputColumnForChartName_BAA.Size = new Size(100, 23);
            toolStripTextBoxInputColumnForChartName_BAA.ToolTipText = "Введите номер столбца(счёт начинается с нуля) , в котором указаны названия";
            // 
            // toolStripTextBoxInputColumnForChartData_BAA
            // 
            toolStripTextBoxInputColumnForChartData_BAA.Name = "toolStripTextBoxInputColumnForChartData_BAA";
            toolStripTextBoxInputColumnForChartData_BAA.Size = new Size(100, 23);
            toolStripTextBoxInputColumnForChartData_BAA.ToolTipText = "Введите номер столбца(счёт начинается с нуля) , в котором указаны значения";
            // 
            // toolStripTextBoxSearch_BAA
            // 
            toolStripTextBoxSearch_BAA.BorderStyle = BorderStyle.None;
            toolStripTextBoxSearch_BAA.Name = "toolStripTextBoxSearch_BAA";
            toolStripTextBoxSearch_BAA.Size = new Size(116, 24);
            // 
            // SearchToolStripMenuItem_BAA
            // 
            SearchToolStripMenuItem_BAA.BackColor = Color.MediumSpringGreen;
            SearchToolStripMenuItem_BAA.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchToolStripMenuItem_BAA.ForeColor = SystemColors.InfoText;
            SearchToolStripMenuItem_BAA.Image = Properties.Resources.free_icon_magnifying_glass_search_16492;
            SearchToolStripMenuItem_BAA.Name = "SearchToolStripMenuItem_BAA";
            SearchToolStripMenuItem_BAA.Size = new Size(32, 24);
            SearchToolStripMenuItem_BAA.ToolTipText = "Будет выполнен поиск";
            SearchToolStripMenuItem_BAA.Click += SearchToolStripMenuItem_BAA_Click;
            // 
            // menuStrip_BAA
            // 
            menuStrip_BAA.Dock = DockStyle.Left;
            menuStrip_BAA.ImageScalingSize = new Size(20, 20);
            menuStrip_BAA.Items.AddRange(new ToolStripItem[] { действияToolStripMenuItem, aboutProgramToolStripMenuItem_BAA, CalculationToolStripMenuItem_BAA, SearchToolStripMenuItem_BAA, toolStripTextBoxSearch_BAA, exitToolStripMenuItem_BAA });
            menuStrip_BAA.Location = new Point(0, 0);
            menuStrip_BAA.Name = "menuStrip_BAA";
            menuStrip_BAA.Padding = new Padding(5, 2, 0, 2);
            menuStrip_BAA.Size = new Size(129, 681);
            menuStrip_BAA.TabIndex = 0;
            menuStrip_BAA.Text = "menuStrip1";
            // 
            // comboBoxColumnForFilter_BAA
            // 
            comboBoxColumnForFilter_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxColumnForFilter_BAA.FormattingEnabled = true;
            comboBoxColumnForFilter_BAA.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxColumnForFilter_BAA.Location = new Point(680, 525);
            comboBoxColumnForFilter_BAA.Name = "comboBoxColumnForFilter_BAA";
            comboBoxColumnForFilter_BAA.Size = new Size(121, 23);
            comboBoxColumnForFilter_BAA.TabIndex = 11;
            toolTip_BAA.SetToolTip(comboBoxColumnForFilter_BAA, "Выберите столбец, счёт начинается от нуля");
            // 
            // textBoxInputFilter_BAA
            // 
            textBoxInputFilter_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxInputFilter_BAA.Location = new Point(371, 525);
            textBoxInputFilter_BAA.Name = "textBoxInputFilter_BAA";
            textBoxInputFilter_BAA.Size = new Size(121, 23);
            textBoxInputFilter_BAA.TabIndex = 7;
            toolTip_BAA.SetToolTip(textBoxInputFilter_BAA, "Введите ключевое слово");
            // 
            // buttonUseFilter_BAA
            // 
            buttonUseFilter_BAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUseFilter_BAA.BackColor = SystemColors.ActiveCaption;
            buttonUseFilter_BAA.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUseFilter_BAA.Location = new Point(1307, 551);
            buttonUseFilter_BAA.Name = "buttonUseFilter_BAA";
            buttonUseFilter_BAA.Size = new Size(121, 37);
            buttonUseFilter_BAA.TabIndex = 8;
            buttonUseFilter_BAA.Text = "Выполнить";
            toolTip_BAA.SetToolTip(buttonUseFilter_BAA, "Будет применён фильтр");
            buttonUseFilter_BAA.UseVisualStyleBackColor = false;
            buttonUseFilter_BAA.Click += buttonUseFilter_BAA_Click;
            // 
            // toolTip_BAA
            // 
            toolTip_BAA.Tag = "";
            toolTip_BAA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_BAA.ToolTipTitle = "Подсказка";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ActiveBorder;
            toolStrip1.Location = new Point(129, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1355, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1484, 681);
            Controls.Add(toolStrip1);
            Controls.Add(buttonUseFilter_BAA);
            Controls.Add(textBoxInputFilter_BAA);
            Controls.Add(comboBoxColumnForFilter_BAA);
            Controls.Add(textBoxOutPutData_BAA);
            Controls.Add(dataGridViewTable_BAA);
            Controls.Add(menuStrip_BAA);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip_BAA;
            Margin = new Padding(2);
            MinimumSize = new Size(1280, 720);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Договорная деятельность организации";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_BAA).EndInit();
            menuStrip_BAA.ResumeLayout(false);
            menuStrip_BAA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTable_BAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_BAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_BAA;
        private System.Windows.Forms.TextBox textBoxOutPutData_BAA;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem AddRowsToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem AddColumnsToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem RemoveRowToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem RemoveColumnToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem CloseTableToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem ManualToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem CalculationToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem MAXSumToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnMAX_BAA;
        private System.Windows.Forms.ToolStripMenuItem MINSumToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnMIN_BAA;
        private System.Windows.Forms.ToolStripMenuItem DohodToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnDohod_BAA;
        private System.Windows.Forms.ToolStripMenuItem AverageValueToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnAverageValue_BAA;
        private System.Windows.Forms.ToolStripMenuItem CountDocumentToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripMenuItem BuildChartToolStripMenuItem_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnForChartName_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputColumnForChartData_BAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_BAA;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_BAA;
        private System.Windows.Forms.MenuStrip menuStrip_BAA;
        private System.Windows.Forms.ComboBox comboBoxColumnForFilter_BAA;
        private System.Windows.Forms.Label labelInputS_BAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputFilter_BAA;
        private System.Windows.Forms.Button buttonUseFilter_BAA;
        private System.Windows.Forms.ToolTip toolTip_BAA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;


    }
}