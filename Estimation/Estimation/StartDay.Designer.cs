namespace Estimation
{
    partial class StartDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartDay));
            this.AddBoughtCurrency = new System.Windows.Forms.Button();
            this.CoursePrise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumPrise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.progressDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBoughtCurrency
            // 
            this.AddBoughtCurrency.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.AddBoughtCurrency.Location = new System.Drawing.Point(28, 147);
            this.AddBoughtCurrency.Name = "AddBoughtCurrency";
            this.AddBoughtCurrency.Size = new System.Drawing.Size(102, 28);
            this.AddBoughtCurrency.TabIndex = 17;
            this.AddBoughtCurrency.Text = "Добавить";
            this.AddBoughtCurrency.UseVisualStyleBackColor = true;
            this.AddBoughtCurrency.Click += new System.EventHandler(this.AddBoughtCurrency_Click);
            // 
            // CoursePrise
            // 
            this.CoursePrise.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.CoursePrise.Location = new System.Drawing.Point(15, 120);
            this.CoursePrise.Name = "CoursePrise";
            this.CoursePrise.Size = new System.Drawing.Size(134, 21);
            this.CoursePrise.TabIndex = 16;
            this.CoursePrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoursePrise_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Курс";
            // 
            // SumPrise
            // 
            this.SumPrise.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.SumPrise.Location = new System.Drawing.Point(15, 77);
            this.SumPrise.Name = "SumPrise";
            this.SumPrise.Size = new System.Drawing.Size(134, 21);
            this.SumPrise.TabIndex = 14;
            this.SumPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumPrise_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сумма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Валюта";
            // 
            // ChoiseCurrency
            // 
            this.ChoiseCurrency.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ChoiseCurrency.FormattingEnabled = true;
            this.ChoiseCurrency.Items.AddRange(new object[] {
            "Доллар",
            "Евро",
            "Гривна"});
            this.ChoiseCurrency.Location = new System.Drawing.Point(15, 31);
            this.ChoiseCurrency.Name = "ChoiseCurrency";
            this.ChoiseCurrency.Size = new System.Drawing.Size(137, 24);
            this.ChoiseCurrency.TabIndex = 11;
            this.ChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.ChoiseCurrency_SelectedIndexChanged);
            // 
            // progressDataGridView
            // 
            this.progressDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.progressDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.progressDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.progressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchasedSumDollar,
            this.CoursePurchasedSumDollar});
            this.progressDataGridView.Location = new System.Drawing.Point(158, 12);
            this.progressDataGridView.Name = "progressDataGridView";
            this.progressDataGridView.Size = new System.Drawing.Size(263, 163);
            this.progressDataGridView.TabIndex = 10;
            this.progressDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progressDataGridView_CellContentDoubleClick);
            this.progressDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progressDataGridView_CellDoubleClick);
            // 
            // PurchasedSumDollar
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.PurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchasedSumDollar.HeaderText = "Сумма";
            this.PurchasedSumDollar.Name = "PurchasedSumDollar";
            // 
            // CoursePurchasedSumDollar
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CoursePurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle4;
            this.CoursePurchasedSumDollar.HeaderText = "Курс";
            this.CoursePurchasedSumDollar.Name = "CoursePurchasedSumDollar";
            this.CoursePurchasedSumDollar.Width = 110;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 181);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(430, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // StartDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 206);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.AddBoughtCurrency);
            this.Controls.Add(this.CoursePrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumPrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiseCurrency);
            this.Controls.Add(this.progressDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало дня";
            this.Load += new System.EventHandler(this.StartDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBoughtCurrency;
        private System.Windows.Forms.TextBox CoursePrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumPrise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChoiseCurrency;
        private System.Windows.Forms.DataGridView progressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedSumDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePurchasedSumDollar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}