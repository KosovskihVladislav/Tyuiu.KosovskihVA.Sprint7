using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KosovskihVA.Sprint7.Project.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        private int compMode = 0;

        public FormMain()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        private void открытьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = openFileDialog.FileName;
                var rows = dataGridViewTable.Rows;
                string[] content = File.ReadAllLines(filepath, Encoding.Default);
                dataGridViewTable.RowCount = content.Length;
                for (int i = 0; i < content.Length; i++)
                {
                    for (int j = 0; j < content[0].Split(';').Length; j++)
                    {
                        rows[i].Cells[j].Value = content[i]?.Split(';')[j];
                    }
                }
            }
        }
        private void сохранитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Домоуправление";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = saveFileDialog.FileName;
                var rows = dataGridViewTable.Rows;
                string[] content = new string[rows.Count];
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < rows[i].Cells.Count; j++)
                    {
                        if (j != rows[i].Cells.Count - 1)
                        {
                            content[i] += rows[i].Cells[j].Value?.ToString() + ';';
                        }
                        else
                        {
                            content[i] += rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }
                File.WriteAllLines(filepath, content, Encoding.UTF8);
            }
        }
        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void dataGridViewTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                chartSquare.Series[0].Points.Clear();
                foreach (DataGridViewRow row in dataGridViewTable.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        chartSquare.Series[0].Points.AddXY(Convert.ToDouble(row.Cells[1].Value), Convert.ToDouble(row.Cells[2].Value));
                    }
                }
            }
        }
        private void dataGridViewTable_SelectionChanged(object sender, EventArgs e)
        {
            textBoxSelectedCount.Text = dataGridViewTable.SelectedCells.Count.ToString();
            List<double> cellsValues = new List<double>();
            foreach (DataGridViewCell cell in dataGridViewTable.SelectedCells)
            {
                if (cell.Value != null && double.TryParse(cell.Value.ToString().Replace('.',','), out double cellValue))
                {
                    cellsValues.Add(cellValue);
                }
            }
            if (cellsValues.Count > 0)
            {
                textBoxSum.Text = service.Calculation(cellsValues, "Sum").ToString();
                textBoxMid.Text = service.Calculation(cellsValues, "Mid").ToString();
                textBoxMin.Text = service.Calculation(cellsValues, "Min").ToString();
                textBoxMax.Text = service.Calculation(cellsValues, "Max").ToString();
                cellsValues.Clear();
            }
            else
            {
                textBoxSum.Clear();
                textBoxMid.Clear();
                textBoxMin.Clear();
                textBoxMax.Clear();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text?.ToLower().Trim();
            var rows = dataGridViewTable.Rows;
            if (!string.IsNullOrEmpty(search))
            {
                foreach (DataGridViewRow row in rows)
                {
                    List<string> cellsValues = new List<string>();
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString().ToLower();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            cellsValues.Add(cellValue);
                        }
                    }
                    bool isVisible = cellsValues.Any(x => x.Contains(search));
                    row.Visible = isVisible;
                }
            }
            else
            {
                foreach (DataGridViewRow row in rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void buttonFilterCompareMode_Click(object sender, EventArgs e)
        {
            if (compMode == 0)
            {
                compMode = 1;
                buttonFilterCompareMode.Text = "<";
            }
            else
            {
                compMode = 0;
                buttonFilterCompareMode.Text = ">";
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilter.Enabled = true;
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length > 1)
            {
                int filter = Convert.ToInt32(textBoxFilter.Text);
                int columnIndex = 0;
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0: { columnIndex = 2; } break;
                    case 1: { columnIndex = 3; } break;
                    case 2: { columnIndex = 4; } break;
                    case 3: { columnIndex = 6; } break;
                    case 4: { columnIndex = 7; } break;
                    case 5: { columnIndex = 8; } break;
                }
                foreach(DataGridViewRow row in dataGridViewTable.Rows)
                {
                    string cellValue = row.Cells[columnIndex].Value?.ToString().Replace('.',',');
                    if(!string.IsNullOrEmpty(cellValue))
                    {
                        bool isVisible = service.Comparison(Convert.ToDouble(cellValue), filter, compMode);
                        row.Visible = isVisible;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewTable.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewTable.Rows.Add();
        }

        private void удалитьВыделеннуюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridViewTable.SelectedCells[0].RowIndex;
            dataGridViewTable.Rows.RemoveAt(selectedRowIndex);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
