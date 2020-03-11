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

namespace Estimation
{
    public partial class CurrencyRates : Form
    {
        public CurrencyRates()
        {
            InitializeComponent();
        }

        private void CurrencyRates_Load(object sender, EventArgs e)
        {
            DollarPurchase.Text = Settings.Default["DollarPurchase"].ToString();
            DollarSale.Text = Settings.Default["DollarSale"].ToString();
            EuroPurchase.Text = Settings.Default["EuroPurchase"].ToString();
            EuroSale.Text = Settings.Default["EuroSale"].ToString();
            HryvnaPurchase.Text = Settings.Default["HryvnaPurchase"].ToString();
            HryvnaSale.Text = Settings.Default["HryvnaSale"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            TextBox textbox = control1 as TextBox;
                            if (string.IsNullOrWhiteSpace(textbox.Text))
                            {
                                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            Settings.Default["DollarPurchase"] = Convert.ToDouble(ReplaceOnPoint(DollarPurchase.Text));
            Settings.Default["DollarSale"] = Convert.ToDouble(ReplaceOnPoint(DollarSale.Text));
            Settings.Default["EuroPurchase"] = Convert.ToDouble(ReplaceOnPoint(EuroPurchase.Text));
            Settings.Default["EuroSale"] = Convert.ToDouble(ReplaceOnPoint(EuroSale.Text));
            Settings.Default["HryvnaPurchase"] = Convert.ToDouble(ReplaceOnPoint(HryvnaPurchase.Text));
            Settings.Default["HryvnaSale"] = Convert.ToDouble(ReplaceOnPoint(HryvnaSale.Text));
            MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        string ReplaceOnPoint(string currency)
        {
            currency = currency.Replace(",", ".");
            return currency;
        }

        #region Logic for textbox
        private void DollarPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void DollarSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void EuroPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void EuroSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HryvnaPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HryvnaSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 46 && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }
        #endregion
    }
}