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
    public partial class Costs : Form
    {
        Source source;
        public Costs(Source sourceForOutput)
        {
            InitializeComponent();
            source = sourceForOutput;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeOfOperations.SelectedIndex)
            {
                case 0: /*Приход*/
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
                case 1: /*Расход*/
                    switch (ChoiseCurrency.SelectedIndex)
                    {
                        case 0:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleDollar.Count; i++)
                                progressDataGridView.Rows.Add(source.saleDollar[i].Sum, source.saleDollar[i].Course);
                            break;
                        case 1:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleEuro.Count; i++)
                                progressDataGridView.Rows.Add(source.saleEuro[i].Sum, source.saleEuro[i].Course);
                            break;
                        case 2:
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleHryvnia.Count; i++)
                                progressDataGridView.Rows.Add(source.saleHryvnia[i].Sum, source.saleHryvnia[i].Course);
                            break;
                    }
                    break;
            }
        }

        private void ChoiseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            switch (typeOfOperations.SelectedIndex)
            {
                case 0: /*Приход*/
                    switch (ChoiseCurrency.SelectedIndex)
                    {
                        case 0:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.dollar.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.dollar[i].Sum, source.dollar[i].Course);
                                res += Convert.ToInt32(source.dollar[i].Sum * source.dollar[i].Course);
                            }
                            this.Text = $"Приход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                        case 1:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.euro.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.euro[i].Sum, source.euro[i].Course);
                                res += Convert.ToInt32(source.euro[i].Sum * source.euro[i].Course);
                            }
                            this.Text = $"Приход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                        case 2:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.hryvnia.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.hryvnia[i].Sum, source.hryvnia[i].Course);
                                res += Convert.ToInt32(source.hryvnia[i].Sum * source.hryvnia[i].Course);
                            }
                            this.Text = $"Приход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                    }
                    break;
                case 1: /*Расход*/
                    switch (ChoiseCurrency.SelectedIndex)
                    {
                        case 0:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleDollar.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.saleDollar[i].Sum, source.saleDollar[i].Course);
                                res += Convert.ToInt32(source.saleDollar[i].Sum * source.saleDollar[i].Course);
                            }
                            this.Text = $"Расход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                        case 1:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleEuro.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.saleEuro[i].Sum, source.saleEuro[i].Course);
                                res += Convert.ToInt32(source.saleEuro[i].Sum * source.saleEuro[i].Course);
                            }
                            this.Text = $"Расход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                        case 2:
                            res = 0;
                            progressDataGridView.Rows.Clear();
                            for (int i = 0; i < source.saleHryvnia.Count; i++)
                            {
                                progressDataGridView.Rows.Add(source.saleHryvnia[i].Sum, source.saleHryvnia[i].Course);
                                res += Convert.ToInt32(source.saleHryvnia[i].Sum * source.saleHryvnia[i].Course);
                            }
                            this.Text = $"Расход ({ChoiseCurrency.SelectedItem.ToString()} = {res}руб)";
                            break;
                    }
                    break;
            }
        }
    }
}
