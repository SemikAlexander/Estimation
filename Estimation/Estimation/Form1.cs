using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estimation.Properties;
using Microsoft.Office.Interop.Word;

namespace Estimation
{
    public partial class Form1 : Form
    {
        Source source = new Source();
        string act = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(SumPrise.Text))
                {
                    CoursePrise.Focus();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(CoursePrise.Text))
                {
                    AddBoughtCurrency.Focus();
                }
            }
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
            currencyRates.Show();
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
                            foreach (DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["DollarPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["DollarPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                            break;
                        case 1:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.euro.Count; i++)
                                progressDataGridView.Rows.Add(source.euro[i].Sum, source.euro[i].Course);
                            foreach(DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["EuroPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["EuroPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                            break;
                        case 2:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.hryvnia.Count; i++)
                                progressDataGridView.Rows.Add(source.hryvnia[i].Sum, source.hryvnia[i].Course);
                            foreach (DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["HryvnaPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["HryvnaPurchase"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                            break;
                    }
                    break;
                case "sale":
                    switch (ChoiseCurrency.SelectedIndex)
                    {
                        case 0:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleDollar.Count; i++)
                                progressDataGridView.Rows.Add(source.saleDollar[i].Sum, source.saleDollar[i].Course);
                            foreach (DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["DollarSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["DollarSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                            break;
                        case 1:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleEuro.Count; i++)
                                progressDataGridView.Rows.Add(source.saleEuro[i].Sum, source.saleEuro[i].Course);
                            foreach (DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["EuroSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["EuroSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                            break;
                        case 2:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleHryvnia.Count; i++)
                                progressDataGridView.Rows.Add(source.saleHryvnia[i].Sum, source.saleHryvnia[i].Course);
                            foreach (DataGridViewRow row in progressDataGridView.Rows)
                            {
                                if (Convert.ToDouble(row.Cells[1].Value) > Convert.ToDouble(Settings.Default["HryvnaSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Green;
                                if (Convert.ToDouble(row.Cells[1].Value) < Convert.ToDouble(Settings.Default["HryvnaSale"].ToString()))
                                    row.DefaultCellStyle.ForeColor = Color.Red;
                            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            покупкаToolStripMenuItem.Checked = true;
            продажаToolStripMenuItem.Checked = false;
            act = "purchase";
        }

        private void началоДняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartDay startDay = new StartDay(source);
            startDay.Show();
        }

        private void расходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Costs costs = new Costs(source);
            costs.Show();
        }

        private void генерацияОтчётаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (source.dollar.Count != 0 | source.euro.Count != 0 | source.hryvnia.Count != 0)
            {
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                Document document = application.Documents.Add(Visible: true);
                Range range = document.Range();
                string day = DateTime.Now.Date.Day.ToString();
                string month = DateTime.Now.Date.Month.ToString().Length == 2 ? DateTime.Now.Date.Month.ToString() : "0" + DateTime.Now.Date.Month.ToString();
                string year = DateTime.Now.Date.Year.ToString();
                range.Text = $"{day}.{month}.{year}";
                range.Font.Name = "Times New Roman";
                int size1 = source.dollar.Count;
                int size2 = source.euro.Count;
                int size3 = source.hryvnia.Count;
                int maxValue = Math.Max(source.dollar.Count, Math.Max(source.euro.Count, source.hryvnia.Count));
                Table table = document.Tables.Add(range, maxValue + 1, 6);
                table.Borders.Enable = 1;
                foreach (Row row in table.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        if(cell.RowIndex == 1)
                        {
                            table.Cell(1, 1).Range.Text = "ДОЛЛАР (покупка)";
                            table.Cell(1, 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Cell(1, 3).Range.Text = "ЕВРО (покупка)";
                            table.Cell(1, 3).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Cell(1, 5).Range.Text = "ГРИВНА (покупка)";
                            table.Cell(1, 5).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Cell(1, 2).Range.Text = "ДОЛЛАР (продажа)";
                            table.Cell(1, 2).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Cell(1, 4).Range.Text = "ЕВРО (продажа)";
                            table.Cell(1, 4).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Cell(1, 6).Range.Text = "ГРИВНА (продажа)";
                            table.Cell(1, 6).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        }
                        else
                        {
                            for (int i = 0; i < source.dollar.Count; i++)
                                table.Cell(2 + i, 1).Range.Text = $"{source.dollar[i].Sum.ToString()}*{source.dollar[i].Course.ToString()} =\n{Convert.ToInt32(source.dollar[i].Sum * source.dollar[i].Course)}";
                            for (int i = 0; i < source.euro.Count; i++)
                                table.Cell(2 + i, 3).Range.Text = $"{source.euro[i].Sum.ToString()}*{source.euro[i].Course.ToString()} =\n{Convert.ToInt32(source.euro[i].Sum * source.euro[i].Course)}";
                            for (int i = 0; i < source.hryvnia.Count; i++)
                                table.Cell(2 + i, 5).Range.Text = $"{source.hryvnia[i].Sum.ToString()}*{source.hryvnia[i].Course.ToString()} =\n{Convert.ToInt32(source.hryvnia[i].Sum * source.hryvnia[i].Course)}";
                            for (int i = 0; i < source.saleDollar.Count; i++)
                                table.Cell(2 + i, 2).Range.Text = $"{source.saleDollar[i].Sum.ToString()}*{source.saleDollar[i].Course.ToString()} =\n{Convert.ToInt32(source.saleDollar[i].Sum * source.saleDollar[i].Course)}";
                            for (int i = 0; i < source.saleEuro.Count; i++)
                                table.Cell(2 + i, 4).Range.Text = $"{source.saleEuro[i].Sum.ToString()}*{source.saleEuro[i].Course.ToString()} =\n{Convert.ToInt32(source.saleEuro[i].Sum * source.saleEuro[i].Course)}";
                            for (int i = 0; i < source.saleHryvnia.Count; i++)
                                table.Cell(2 + i, 6).Range.Text = $"{source.saleHryvnia[i].Sum.ToString()}*{source.saleHryvnia[i].Course.ToString()} =\n{Convert.ToInt32(source.saleHryvnia[i].Sum * source.saleHryvnia[i].Course)}";
                        }
                    }
                }
                document.Save();
                try
                {
                    document.Close();
                    application.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}