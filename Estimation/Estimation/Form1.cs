using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimation
{
    public partial class Form1 : Form
    {
        Source source = new Source();      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CoursePrise.Text) == false & string.IsNullOrWhiteSpace(SumPrise.Text) == false)
            {
                switch (ChoiseCurrency.SelectedIndex)
                {
                    case 0:
                        source.AddData(CoursePrise.Text, SumPrise.Text, 0);
                        FillingTable();
                        break;
                    case 1:
                        source.AddData(CoursePrise.Text, SumPrise.Text, 1);
                        FillingTable();
                        break;
                    case 2:
                        source.AddData(CoursePrise.Text, SumPrise.Text, 2);
                        FillingTable();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void progressDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите удалить текущую строку?", "Действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                switch (ChoiseCurrency.SelectedIndex)
                {
                    case 0:
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 0);
                        FillingTable();
                        break;
                    case 1:
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 1);
                        FillingTable();
                        break;
                    case 2:
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 2);
                        FillingTable();
                        break;
                }
            }
        }

        private void ChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillingTable();
        }
        
        public void FillingTable()
        {
            switch (ChoiseCurrency.SelectedIndex)
            {
                case 0:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.dollar.Count; i++)
                        progressDataGridView.Rows.Add(source.dollar[i].Sum, source.dollar[i].Course);
                    break;
                case 1:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.euro.Count; i++)
                        progressDataGridView.Rows.Add(source.euro[i].Sum, source.euro[i].Course);
                    break;
                case 2:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.hryvnia.Count; i++)
                        progressDataGridView.Rows.Add(source.hryvnia[i].Sum, source.hryvnia[i].Course);
                    break;
            }
        }
    }
}
