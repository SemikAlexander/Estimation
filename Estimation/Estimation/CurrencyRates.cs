using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                            if (CheckIsDublicate(textbox.Text) == true)
                            {
                                textbox.Text = "";
                                return;
                            }
                        }
                    }
                }
            }
            Settings.Default["DollarPurchase"] = double.Parse(ReplaceOnPoint(DollarPurchase.Text), CultureInfo.InvariantCulture);
            Settings.Default["DollarSale"] = double.Parse(ReplaceOnPoint(DollarSale.Text), CultureInfo.InvariantCulture);
            Settings.Default["EuroPurchase"] = double.Parse(ReplaceOnPoint(EuroPurchase.Text), CultureInfo.InvariantCulture);
            Settings.Default["EuroSale"] = double.Parse(ReplaceOnPoint(EuroSale.Text), CultureInfo.InvariantCulture);
            Settings.Default["HryvnaPurchase"] = double.Parse(ReplaceOnPoint(HryvnaPurchase.Text), CultureInfo.InvariantCulture);
            Settings.Default["HryvnaSale"] = double.Parse(ReplaceOnPoint(HryvnaSale.Text), CultureInfo.InvariantCulture);
            MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        string ReplaceOnPoint(string currency)
        {
            currency = currency.Replace(",", ".");
            return currency;
        }

        public bool CheckIsDublicate(string inputString)
        {
            int points = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (points > 1)
                {
                    MessageBox.Show("Ошибка ввода. Много запятых!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                if (inputString[i] == '.' | inputString[i] == ',')
                    points++;
            }
            if (inputString[0] == '.' | inputString[0] == ',')
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (inputString[inputString.Length - 1] == '.' | inputString[inputString.Length - 1] == ',')
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
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