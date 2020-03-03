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
    public partial class ExpensesForm : Form
    {
        Source source;
        public ExpensesForm(Source sourceForOutput)
        {
            InitializeComponent();
            source = sourceForOutput;
        }

        private void SumPrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddBoughtCurrency_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(expensesDescription.Text) & !string.IsNullOrWhiteSpace(SumPrise.Text)) {
                source.expenses.Sum = Convert.ToInt32(SumPrise.Text);
                source.expenses.Description = expensesDescription.Text;
                source.expense.Add(source.expenses);

                expensesDataGridView.Rows.Add(SumPrise.Text, expensesDescription.Text);
                source.allExpenses += Convert.ToInt32(SumPrise.Text);
            }
        }

        private void expensesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите удалить текущую строку?", "Действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                source.allExpenses -= source.expense[e.RowIndex].Sum;
                source.expense.RemoveAt(e.RowIndex);
                FillingTable();
            }
        }

        public void FillingTable()
        {
            expensesDataGridView.Rows.Clear();
            for (int i = 0; i < source.expense.Count; i++)
                expensesDataGridView.Rows.Add(source.expense[i].Sum, source.expense[i].Description);
        }
    }
}
