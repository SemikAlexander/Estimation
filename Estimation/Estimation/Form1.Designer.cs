namespace Estimation
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.началоДняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияОтчётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SumPrise = new System.Windows.Forms.TextBox();
            this.CoursePrise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBoughtCurrency = new System.Windows.Forms.Button();
            this.OperationDataGridView = new System.Windows.Forms.DataGridView();
            this.dollarBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euroBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euroSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hryvnaBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hryvnaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расходыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem,
            this.расходыToolStripMenuItem1,
            this.настройкаToolStripMenuItem,
            this.отчётToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупкаToolStripMenuItem,
            this.продажаToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // покупкаToolStripMenuItem
            // 
            this.покупкаToolStripMenuItem.CheckOnClick = true;
            this.покупкаToolStripMenuItem.Name = "покупкаToolStripMenuItem";
            this.покупкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупкаToolStripMenuItem.Text = "Покупка";
            this.покупкаToolStripMenuItem.Click += new System.EventHandler(this.покупкаToolStripMenuItem_Click);
            // 
            // продажаToolStripMenuItem
            // 
            this.продажаToolStripMenuItem.CheckOnClick = true;
            this.продажаToolStripMenuItem.Name = "продажаToolStripMenuItem";
            this.продажаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.продажаToolStripMenuItem.Text = "Продажа";
            this.продажаToolStripMenuItem.Click += new System.EventHandler(this.продажаToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыВалютToolStripMenuItem,
            this.началоДняToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // курсыВалютToolStripMenuItem
            // 
            this.курсыВалютToolStripMenuItem.Name = "курсыВалютToolStripMenuItem";
            this.курсыВалютToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.курсыВалютToolStripMenuItem.Text = "Курсы валют";
            this.курсыВалютToolStripMenuItem.Click += new System.EventHandler(this.курсыВалютToolStripMenuItem_Click);
            // 
            // началоДняToolStripMenuItem
            // 
            this.началоДняToolStripMenuItem.Name = "началоДняToolStripMenuItem";
            this.началоДняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.началоДняToolStripMenuItem.Text = "Начало дня";
            this.началоДняToolStripMenuItem.Click += new System.EventHandler(this.началоДняToolStripMenuItem_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расходыToolStripMenuItem,
            this.генерацияОтчётаToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // расходыToolStripMenuItem
            // 
            this.расходыToolStripMenuItem.Name = "расходыToolStripMenuItem";
            this.расходыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.расходыToolStripMenuItem.Text = "Расход/Приход";
            this.расходыToolStripMenuItem.Click += new System.EventHandler(this.расходыToolStripMenuItem_Click);
            // 
            // генерацияОтчётаToolStripMenuItem
            // 
            this.генерацияОтчётаToolStripMenuItem.Name = "генерацияОтчётаToolStripMenuItem";
            this.генерацияОтчётаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.генерацияОтчётаToolStripMenuItem.Text = "Генерация отчёта";
            this.генерацияОтчётаToolStripMenuItem.Click += new System.EventHandler(this.генерацияОтчётаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ChoiseCurrency
            // 
            this.ChoiseCurrency.FormattingEnabled = true;
            this.ChoiseCurrency.Items.AddRange(new object[] {
            "Доллар",
            "Евро",
            "Гривна"});
            this.ChoiseCurrency.Location = new System.Drawing.Point(14, 50);
            this.ChoiseCurrency.Name = "ChoiseCurrency";
            this.ChoiseCurrency.Size = new System.Drawing.Size(156, 25);
            this.ChoiseCurrency.TabIndex = 2;
            this.ChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.ChoiseCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Валюта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма";
            // 
            // SumPrise
            // 
            this.SumPrise.Location = new System.Drawing.Point(14, 99);
            this.SumPrise.Name = "SumPrise";
            this.SumPrise.Size = new System.Drawing.Size(153, 23);
            this.SumPrise.TabIndex = 5;
            this.SumPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CoursePrise
            // 
            this.CoursePrise.Location = new System.Drawing.Point(14, 144);
            this.CoursePrise.Name = "CoursePrise";
            this.CoursePrise.Size = new System.Drawing.Size(153, 23);
            this.CoursePrise.TabIndex = 7;
            this.CoursePrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Курс";
            // 
            // AddBoughtCurrency
            // 
            this.AddBoughtCurrency.Location = new System.Drawing.Point(40, 177);
            this.AddBoughtCurrency.Name = "AddBoughtCurrency";
            this.AddBoughtCurrency.Size = new System.Drawing.Size(101, 30);
            this.AddBoughtCurrency.TabIndex = 9;
            this.AddBoughtCurrency.Text = "Добавить";
            this.AddBoughtCurrency.UseVisualStyleBackColor = true;
            this.AddBoughtCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperationDataGridView
            // 
            this.OperationDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OperationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OperationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dollarBought,
            this.dollarSale,
            this.euroBought,
            this.euroSale,
            this.hryvnaBought,
            this.hryvnaSale});
            this.OperationDataGridView.Location = new System.Drawing.Point(176, 30);
            this.OperationDataGridView.Name = "OperationDataGridView";
            this.OperationDataGridView.ReadOnly = true;
            this.OperationDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.OperationDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.OperationDataGridView.Size = new System.Drawing.Size(772, 251);
            this.OperationDataGridView.TabIndex = 10;
            this.OperationDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OperationDataGridView_CellDoubleClick);
            // 
            // dollarBought
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarBought.DefaultCellStyle = dataGridViewCellStyle2;
            this.dollarBought.HeaderText = "Доллар (покупка)";
            this.dollarBought.Name = "dollarBought";
            this.dollarBought.ReadOnly = true;
            this.dollarBought.Width = 120;
            // 
            // dollarSale
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dollarSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dollarSale.HeaderText = "Доллар (продажа)";
            this.dollarSale.Name = "dollarSale";
            this.dollarSale.ReadOnly = true;
            this.dollarSale.Width = 120;
            // 
            // euroBought
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.euroBought.DefaultCellStyle = dataGridViewCellStyle4;
            this.euroBought.HeaderText = "Евро (покупка)";
            this.euroBought.Name = "euroBought";
            this.euroBought.ReadOnly = true;
            this.euroBought.Width = 120;
            // 
            // euroSale
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.euroSale.DefaultCellStyle = dataGridViewCellStyle5;
            this.euroSale.HeaderText = "Евро (продажа)";
            this.euroSale.Name = "euroSale";
            this.euroSale.ReadOnly = true;
            this.euroSale.Width = 120;
            // 
            // hryvnaBought
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.hryvnaBought.DefaultCellStyle = dataGridViewCellStyle6;
            this.hryvnaBought.HeaderText = "Гривна (покупка)";
            this.hryvnaBought.Name = "hryvnaBought";
            this.hryvnaBought.ReadOnly = true;
            this.hryvnaBought.Width = 120;
            // 
            // hryvnaSale
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.hryvnaSale.DefaultCellStyle = dataGridViewCellStyle7;
            this.hryvnaSale.HeaderText = "Гривна (продажа)";
            this.hryvnaSale.Name = "hryvnaSale";
            this.hryvnaSale.ReadOnly = true;
            this.hryvnaSale.Width = 120;
            // 
            // расходыToolStripMenuItem1
            // 
            this.расходыToolStripMenuItem1.Name = "расходыToolStripMenuItem1";
            this.расходыToolStripMenuItem1.Size = new System.Drawing.Size(77, 21);
            this.расходыToolStripMenuItem1.Text = "Расходы";
            this.расходыToolStripMenuItem1.Click += new System.EventHandler(this.расходыToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 293);
            this.Controls.Add(this.OperationDataGridView);
            this.Controls.Add(this.AddBoughtCurrency);
            this.Controls.Add(this.CoursePrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumPrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiseCurrency);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox ChoiseCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumPrise;
        private System.Windows.Forms.TextBox CoursePrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBoughtCurrency;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генерацияОтчётаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсыВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem началоДняToolStripMenuItem;
        public System.Windows.Forms.DataGridView OperationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn euroBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn euroSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn hryvnaBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn hryvnaSale;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem1;
    }
}

