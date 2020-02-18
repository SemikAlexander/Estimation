namespace Estimation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внешнийВидToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SumPrise = new System.Windows.Forms.TextBox();
            this.CoursePrise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBoughtCurrency = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem,
            this.отчётToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыВалютToolStripMenuItem,
            this.внешнийВидToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // курсыВалютToolStripMenuItem
            // 
            this.курсыВалютToolStripMenuItem.Name = "курсыВалютToolStripMenuItem";
            this.курсыВалютToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.курсыВалютToolStripMenuItem.Text = "Курсы валют";
            // 
            // внешнийВидToolStripMenuItem
            // 
            this.внешнийВидToolStripMenuItem.Name = "внешнийВидToolStripMenuItem";
            this.внешнийВидToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.внешнийВидToolStripMenuItem.Text = "Внешний вид";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // progressDataGridView
            // 
            this.progressDataGridView.AllowUserToAddRows = false;
            this.progressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchasedSumDollar,
            this.CoursePurchasedSumDollar});
            this.progressDataGridView.Location = new System.Drawing.Point(155, 31);
            this.progressDataGridView.Name = "progressDataGridView";
            this.progressDataGridView.Size = new System.Drawing.Size(247, 420);
            this.progressDataGridView.TabIndex = 1;
            this.progressDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progressDataGridView_CellDoubleClick);
            // 
            // PurchasedSumDollar
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.PurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchasedSumDollar.HeaderText = "Сумма";
            this.PurchasedSumDollar.Name = "PurchasedSumDollar";
            // 
            // CoursePurchasedSumDollar
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CoursePurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle4;
            this.CoursePurchasedSumDollar.HeaderText = "Курс";
            this.CoursePurchasedSumDollar.Name = "CoursePurchasedSumDollar";
            // 
            // ChoiseCurrency
            // 
            this.ChoiseCurrency.FormattingEnabled = true;
            this.ChoiseCurrency.Items.AddRange(new object[] {
            "Доллар",
            "Эвро",
            "Гривна"});
            this.ChoiseCurrency.Location = new System.Drawing.Point(12, 50);
            this.ChoiseCurrency.Name = "ChoiseCurrency";
            this.ChoiseCurrency.Size = new System.Drawing.Size(137, 24);
            this.ChoiseCurrency.TabIndex = 2;
            this.ChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.ChoiseCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Валюта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма";
            // 
            // SumPrise
            // 
            this.SumPrise.Location = new System.Drawing.Point(12, 96);
            this.SumPrise.Name = "SumPrise";
            this.SumPrise.Size = new System.Drawing.Size(134, 21);
            this.SumPrise.TabIndex = 5;
            this.SumPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CoursePrise
            // 
            this.CoursePrise.Location = new System.Drawing.Point(12, 139);
            this.CoursePrise.Name = "CoursePrise";
            this.CoursePrise.Size = new System.Drawing.Size(134, 21);
            this.CoursePrise.TabIndex = 7;
            this.CoursePrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Курс";
            // 
            // AddBoughtCurrency
            // 
            this.AddBoughtCurrency.Location = new System.Drawing.Point(34, 166);
            this.AddBoughtCurrency.Name = "AddBoughtCurrency";
            this.AddBoughtCurrency.Size = new System.Drawing.Size(88, 28);
            this.AddBoughtCurrency.TabIndex = 9;
            this.AddBoughtCurrency.Text = "Добавить";
            this.AddBoughtCurrency.UseVisualStyleBackColor = true;
            this.AddBoughtCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 463);
            this.Controls.Add(this.AddBoughtCurrency);
            this.Controls.Add(this.CoursePrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumPrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiseCurrency);
            this.Controls.Add(this.progressDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсыВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внешнийВидToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView progressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedSumDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePurchasedSumDollar;
        private System.Windows.Forms.ComboBox ChoiseCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumPrise;
        private System.Windows.Forms.TextBox CoursePrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBoughtCurrency;
    }
}

