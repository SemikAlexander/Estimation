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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            MainForm main = new MainForm();
            StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(Location))
                {
                    Location = new Point(main.Size.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
