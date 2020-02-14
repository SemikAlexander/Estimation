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
        struct Currency
        {
            public int Sum;
            public double Course;
        }
        Currency currency;
        List<Currency> dollar = new List<Currency>();
        List<Currency> euro = new List<Currency>();
        List<Currency> hryvnia = new List<Currency>();

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
            switch (ChoiseCurrency.SelectedIndex)
            {
                case 0:
                    currency.Course = Convert.ToDouble(CoursePrise.Text);
                    currency.Sum = Convert.ToInt32(SumPrise.Text);
                    dollar.Add(currency);
                    progressDataGridView.Rows.Add(currency.Sum, currency.Course);
                    progressChart.Series[0].Points.Clear();
                    foreach (var currentCurrency in dollar)
                    {
                        int id = progressChart.Series[0].Points.AddXY(currentCurrency.Sum, currentCurrency.Course);
                        progressChart.Series[0].Points[id].Label = currentCurrency.Course.ToString();
                    }
                    break;
                case 1:
                    currency.Course = Convert.ToDouble(CoursePrise.Text);
                    currency.Sum = Convert.ToInt32(SumPrise.Text);
                    euro.Add(currency);
                    progressDataGridView.Rows.Add(currency.Sum, currency.Course);
                    progressChart.Series[0].Points.Clear();
                    foreach (var currentCurrency in euro)
                    {
                        int id = progressChart.Series[0].Points.AddXY(currentCurrency.Sum, currentCurrency.Course);
                        progressChart.Series[0].Points[id].Label = currentCurrency.Course.ToString();
                    }
                    break;
                case 2:
                    currency.Course = Convert.ToDouble(CoursePrise.Text);
                    currency.Sum = Convert.ToInt32(SumPrise.Text);
                    hryvnia.Add(currency);
                    progressDataGridView.Rows.Add(currency.Sum, currency.Course);
                    progressChart.Series[0].Points.Clear();
                    foreach (var currentCurrency in hryvnia)
                    {
                        int id = progressChart.Series[0].Points.AddXY(currentCurrency.Sum, currentCurrency.Course);
                        progressChart.Series[0].Points[id].Label = currentCurrency.Course.ToString();
                    }
                    break;
            }
        }
    }
}
