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
        string act = "";    /**/
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
                        source.AddData(CoursePrise.Text, SumPrise.Text, 0, act);
                        FillingTable();
                        break;
                    case 1:
                        source.AddData(CoursePrise.Text, SumPrise.Text, 1, act);
                        FillingTable();
                        break;
                    case 2:
                        source.AddData(CoursePrise.Text, SumPrise.Text, 2, act);
                        FillingTable();
                        break;
                }
                CoursePrise.Text = SumPrise.Text = "";
                SumPrise.Focus();
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
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 0, act);
                        FillingTable();
                        break;
                    case 1:
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 1, act);
                        FillingTable();
                        break;
                    case 2:
                        source.DeleteData(Convert.ToInt32(e.RowIndex.ToString()), 2, act);
                        FillingTable();
                        break;
                }
            }
        }

        private void ChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillingTable();
        }
        
        private void курсыВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyRates currencyRates = new CurrencyRates();
            currencyRates.ShowDialog();
        }

        public void FillingTable()
        {
            switch (act)
            {
                case "purchase":
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
                    break;
                case "sale":
                    switch (ChoiseCurrency.SelectedIndex)
                    {
                        case 0:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleDollar.Count; i++)
                                progressDataGridView.Rows.Add(source.saleDollar[i].Sum, source.dollar[i].Course);
                            break;
                        case 1:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleEuro.Count; i++)
                                progressDataGridView.Rows.Add(source.saleEuro[i].Sum, source.euro[i].Course);
                            break;
                        case 2:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleHryvnia.Count; i++)
                                progressDataGridView.Rows.Add(source.saleHryvnia[i].Sum, source.hryvnia[i].Course);
                            break;
                    }
                    break;
            }
        }

        private void покупкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            покупкаToolStripMenuItem.Checked = true;
            продажаToolStripMenuItem.Checked = false;
            progressDataGridView.Rows.Clear();
            act = "purchase";
            this.Text = "Главная (покупка)";
        }

        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            продажаToolStripMenuItem.Checked = true;
            покупкаToolStripMenuItem.Checked = false;
            progressDataGridView.Rows.Clear();
            act = "sale"; 
            this.Text = "Главная (продажа)";
        }
    }
}