using Tyuiu.BerezkinAA.Sprint7.Project.V15.Lib;
using System.Text;


namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void exitToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialogTable_BAA.ShowDialog();
                openFilePath = openFileDialogTable_BAA.FileName;

                string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewTable_BAA.ColumnCount = cols = arrayValues.GetLength(1);
                dataGridViewTable_BAA.RowCount = rows = arrayValues.GetLength(0);

                for (int i = 0; i < cols; i++)
                {
                    dataGridViewTable_BAA.Columns[i].Name = arrayValues[0, i];
                }

                for (int i = 1; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewTable_BAA[j, i - 1].Value = arrayValues[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTable_BAA.FileName = "DataBase.csv";
                saveFileDialogTable_BAA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogTable_BAA.ShowDialog();

                string path = saveFileDialogTable_BAA.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewTable_BAA.RowCount;
                int columns = dataGridViewTable_BAA.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewTable_BAA.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewTable_BAA.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);

                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str += dataGridViewTable_BAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewTable_BAA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRowsToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_BAA.Columns.Count == 0)
            {
                MessageBox.Show("Сначала добавьте столбцы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewTable_BAA.Rows.Add();
            }
        }
        private void AddColumnsToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            FormWriteText formWriteText = new FormWriteText();
            formWriteText.ShowDialog();

            DataGridViewColumn column = new DataGridViewTextBoxColumn(); // инициализируем колонку
            column.DataPropertyName = "Name"; // имя
            column.Name = DataService.Text; // заголовок колонки
            dataGridViewTable_BAA.Columns.Add(column);
        }

        private void CloseTableToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            this.dataGridViewTable_BAA.Rows.Clear();
            this.dataGridViewTable_BAA.Columns.Clear();
        }

        private void developerToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            FormAboutDeveloper formAboutDeveloper = new FormAboutDeveloper();
            formAboutDeveloper.ShowDialog();
        }

        private void RemoveRowToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_BAA.CurrentRow != null)
            {
                dataGridViewTable_BAA.Rows.Remove(dataGridViewTable_BAA.CurrentRow);
            }
        }

        private void RemoveColumnToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            int CellCount = dataGridViewTable_BAA.Columns.Count - 1;
            dataGridViewTable_BAA.Columns.Remove(dataGridViewTable_BAA.Columns[CellCount]);
        }

        private void DohodToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnDohod_BAA.Text);

                toolStripTextBoxInputColumnDohod_BAA.Clear();

                // Создаем массив для хранения данных из столбца
                double[] columnData = new double[dataGridViewTable_BAA.Rows.Count];

                // Используем цикл для записи данных из столбца в массив
                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_BAA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.SummDohod(columnData);
                textBoxOutPutData_BAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MINSumToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMIN_BAA.Text);

                toolStripTextBoxInputColumnMIN_BAA.Clear();

                double[] columnData = new double[dataGridViewTable_BAA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_BAA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.MinDohod(columnData);
                textBoxOutPutData_BAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MAXSumToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMAX_BAA.Text);

                toolStripTextBoxInputColumnMAX_BAA.Clear();

                double[] columnData = new double[dataGridViewTable_BAA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_BAA.Rows[i].Cells[columnIndex].Value);
                }
                double res = ds.MaxDohod(columnData);
                textBoxOutPutData_BAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AverageValueToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnAverageValue_BAA.Text);

                toolStripTextBoxInputColumnAverageValue_BAA.Clear();

                double[] columnData = new double[dataGridViewTable_BAA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_BAA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.AverageValue(columnData);
                textBoxOutPutData_BAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountDocumentToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int[] columnData = new int[dataGridViewTable_BAA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_BAA.Rows[i].Cells[0].Value);
                }

                int res = ds.CountDocument(columnData);
                textBoxOutPutData_BAA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildChartToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndexName = Convert.ToInt32(toolStripTextBoxInputColumnForChartName_BAA.Text);
                toolStripTextBoxInputColumnForChartName_BAA.Clear();

                string[] columnDataName = new string[dataGridViewTable_BAA.Rows.Count];
                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnDataName[i] = Convert.ToString(dataGridViewTable_BAA.Rows[i].Cells[columnIndexName].Value);
                }

                int columnIndexData = Convert.ToInt32(toolStripTextBoxInputColumnForChartData_BAA.Text);
                toolStripTextBoxInputColumnForChartData_BAA.Clear();

                double[] columnData = new double[dataGridViewTable_BAA.Rows.Count];
                for (int i = 0; i < dataGridViewTable_BAA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_BAA.Rows[i].Cells[columnIndexData].Value);
                }

                DataService.ArrayData = columnData;
                DataService.ArrayName = columnDataName;

                FormChart formChart = new FormChart();
                formChart.Show();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchToolStripMenuItem_BAA_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_BAA != null)
            {
                string currentText = toolStripTextBoxSearch_BAA.Text;
                foreach (DataGridViewRow row in dataGridViewTable_BAA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_BAA.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_BAA.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void buttonUseFilter_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dataGridViewTable_BAA.Rows)
                {
                    NewMethod(r);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewMethod(DataGridViewRow r)
        {
            if ((r.Cells[comboBoxColumnForFilter_BAA.SelectedIndex].Value).ToString().ToUpper().Contains(textBoxInputFilter_BAA.Text.ToUpper()))
            {
                dataGridViewTable_BAA.Rows[r.Index].Visible = true;
                dataGridViewTable_BAA.Rows[r.Index].Selected = true;
            }
            else
            {
                dataGridViewTable_BAA.CurrentCell = null;
                dataGridViewTable_BAA.Rows[r.Index].Visible = false;
            }
        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.Show();
        }
    }
}