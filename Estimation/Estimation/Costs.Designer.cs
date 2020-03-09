namespace Estimation
{
    partial class Costs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costs));
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.progressDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.typeOfOperations = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Валюта";
            // 
            // ChoiseCurrency
            // 
            this.ChoiseCurrency.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ChoiseCurrency.FormattingEnabled = true;
            this.ChoiseCurrency.Items.AddRange(new object[] {
            "Доллар",
            "Евро",
            "Гривна"});
            this.ChoiseCurrency.Location = new System.Drawing.Point(13, 88);
            this.ChoiseCurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoiseCurrency.Name = "ChoiseCurrency";
            this.ChoiseCurrency.Size = new System.Drawing.Size(181, 25);
            this.ChoiseCurrency.TabIndex = 14;
            this.ChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.ChoiseCurrency_SelectedIndexChanged);
            // 
            // progressDataGridView
            // 
            this.progressDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.progressDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.progressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchasedSumDollar,
            this.CoursePurchasedSumDollar});
            this.progressDataGridView.Location = new System.Drawing.Point(209, 13);
            this.progressDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressDataGridView.Name = "progressDataGridView";
            this.progressDataGridView.Size = new System.Drawing.Size(351, 226);
            this.progressDataGridView.TabIndex = 13;
            // 
            // PurchasedSumDollar
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.PurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasedSumDollar.HeaderText = "Сумма";
            this.PurchasedSumDollar.Name = "PurchasedSumDollar";
            // 
            // CoursePurchasedSumDollar
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CoursePurchasedSumDollar.DefaultCellStyle = dataGridViewCellStyle3;
            this.CoursePurchasedSumDollar.HeaderText = "Курс";
            this.CoursePurchasedSumDollar.Name = "CoursePurchasedSumDollar";
            this.CoursePurchasedSumDollar.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тип";
            // 
            // typeOfOperations
            // 
            this.typeOfOperations.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.typeOfOperations.FormattingEnabled = true;
            this.typeOfOperations.Items.AddRange(new object[] {
            "Приход",
            "Расход"});
            this.typeOfOperations.Location = new System.Drawing.Point(13, 36);
            this.typeOfOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeOfOperations.Name = "typeOfOperations";
            this.typeOfOperations.Size = new System.Drawing.Size(181, 25);
            this.typeOfOperations.TabIndex = 16;
            this.typeOfOperations.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 253);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // Costs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 278);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeOfOperations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiseCurrency);
            this.Controls.Add(this.progressDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Costs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходы";
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChoiseCurrency;
        private System.Windows.Forms.DataGridView progressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedSumDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePurchasedSumDollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeOfOperations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}