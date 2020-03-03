namespace Estimation
{
    partial class ExpensesForm
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
            this.expensesDataGridView = new System.Windows.Forms.DataGridView();
            this.SumOfExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionOfExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBoughtCurrency = new System.Windows.Forms.Button();
            this.expensesDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumPrise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // expensesDataGridView
            // 
            this.expensesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.expensesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expensesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SumOfExpense,
            this.DescriptionOfExpense});
            this.expensesDataGridView.Location = new System.Drawing.Point(152, 12);
            this.expensesDataGridView.Name = "expensesDataGridView";
            this.expensesDataGridView.Size = new System.Drawing.Size(358, 166);
            this.expensesDataGridView.TabIndex = 11;
            this.expensesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expensesDataGridView_CellContentDoubleClick);
            // 
            // SumOfExpense
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.SumOfExpense.DefaultCellStyle = dataGridViewCellStyle3;
            this.SumOfExpense.HeaderText = "Сумма";
            this.SumOfExpense.Name = "SumOfExpense";
            // 
            // DescriptionOfExpense
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DescriptionOfExpense.DefaultCellStyle = dataGridViewCellStyle4;
            this.DescriptionOfExpense.HeaderText = "Описание";
            this.DescriptionOfExpense.Name = "DescriptionOfExpense";
            this.DescriptionOfExpense.Width = 200;
            // 
            // AddBoughtCurrency
            // 
            this.AddBoughtCurrency.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.AddBoughtCurrency.Location = new System.Drawing.Point(25, 147);
            this.AddBoughtCurrency.Name = "AddBoughtCurrency";
            this.AddBoughtCurrency.Size = new System.Drawing.Size(108, 31);
            this.AddBoughtCurrency.TabIndex = 22;
            this.AddBoughtCurrency.Text = "Добавить";
            this.AddBoughtCurrency.UseVisualStyleBackColor = true;
            this.AddBoughtCurrency.Click += new System.EventHandler(this.AddBoughtCurrency_Click);
            // 
            // expensesDescription
            // 
            this.expensesDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.expensesDescription.Location = new System.Drawing.Point(12, 71);
            this.expensesDescription.Multiline = true;
            this.expensesDescription.Name = "expensesDescription";
            this.expensesDescription.Size = new System.Drawing.Size(134, 70);
            this.expensesDescription.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Курс";
            // 
            // SumPrise
            // 
            this.SumPrise.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.SumPrise.Location = new System.Drawing.Point(12, 28);
            this.SumPrise.Name = "SumPrise";
            this.SumPrise.Size = new System.Drawing.Size(134, 21);
            this.SumPrise.TabIndex = 19;
            this.SumPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumPrise_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сумма";
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 190);
            this.Controls.Add(this.AddBoughtCurrency);
            this.Controls.Add(this.expensesDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumPrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expensesDataGridView);
            this.Name = "ExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходы";
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumOfExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionOfExpense;
        private System.Windows.Forms.Button AddBoughtCurrency;
        private System.Windows.Forms.TextBox expensesDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumPrise;
        private System.Windows.Forms.Label label2;
    }
}