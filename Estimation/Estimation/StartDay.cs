using System;
using System.Windows.Forms;

namespace Estimation
{
    public partial class StartDay : Form
    {
        Source source;
        public StartDay(Source sourceForOutput)
        {
            InitializeComponent();
            source = sourceForOutput;
        }

        private void StartDay_Load(object sender, EventArgs e)
        {

        }

        private void SumPrise_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CoursePrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(CoursePrise.Text))
                {
                    AddBoughtCurrency.Focus();
                }
            }
        }

        private void ChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChoiseCurrency.SelectedIndex != 3)
            {
                toolStripLabel1.Text = $"Начало дня ({ChoiseCurrency.SelectedItem.ToString()} = {source.GetStartSumInCurrency(ChoiseCurrency.SelectedIndex)})";
                CoursePrise.Enabled = true;
            }
            else
                CoursePrise.Enabled = false;
        }

        private void AddBoughtCurrency_Click(object sender, EventArgs e)
        {
            if (ChoiseCurrency.SelectedIndex != 3)
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
                    CoursePrise.Text = SumPrise.Text = "";
                    SumPrise.Focus();
                    toolStripLabel1.Text = $"Начало дня ({ChoiseCurrency.SelectedItem.ToString()} = {source.GetStartSumInCurrency(ChoiseCurrency.SelectedIndex)})";/* ({source.GetStartSum(ChoiseCurrency.SelectedIndex)}руб)*/
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                source.startRub = Convert.ToInt32(SumPrise.Text);
                CoursePrise.Text = SumPrise.Text = "";
                SumPrise.Focus();
                toolStripLabel1.Text = $"Начало дня ({ChoiseCurrency.SelectedItem.ToString()} = {source.startRub})";
            }
        }

        private void progressDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        public void FillingTable()
        {
            switch (ChoiseCurrency.SelectedIndex)
            {
                case 0:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.startDollar.Count; i++)
                        progressDataGridView.Rows.Add(source.startDollar[i].Sum, source.startDollar[i].Course);
                    break;
                case 1:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.startEuro.Count; i++)
                        progressDataGridView.Rows.Add(source.startEuro[i].Sum, source.startEuro[i].Course);
                    break;
                case 2:
                    progressDataGridView.Rows.Clear();
                    for (int i = 0; i < source.startHryvnia.Count; i++)
                        progressDataGridView.Rows.Add(source.startHryvnia[i].Sum, source.startHryvnia[i].Course);
                    break;
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
    }
}
