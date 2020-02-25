namespace Estimation
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dollarBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euroBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euroSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hryvnaBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hryvnaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dollarBought,
            this.dollarSale,
            this.euroBought,
            this.euroSale,
            this.hryvnaBought,
            this.hryvnaSale});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dataGridView1.Size = new System.Drawing.Size(772, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // dollarBought
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarBought.DefaultCellStyle = dataGridViewCellStyle2;
            this.dollarBought.HeaderText = "Доллар (покупка)";
            this.dollarBought.Name = "dollarBought";
            this.dollarBought.Width = 120;
            // 
            // dollarSale
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dollarSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dollarSale.HeaderText = "Доллар (продажа)";
            this.dollarSale.Name = "dollarSale";
            this.dollarSale.Width = 120;
            // 
            // euroBought
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.euroBought.DefaultCellStyle = dataGridViewCellStyle4;
            this.euroBought.HeaderText = "Евро (покупка)";
            this.euroBought.Name = "euroBought";
            this.euroBought.Width = 120;
            // 
            // euroSale
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.euroSale.DefaultCellStyle = dataGridViewCellStyle5;
            this.euroSale.HeaderText = "Евро (продажа)";
            this.euroSale.Name = "euroSale";
            this.euroSale.Width = 120;
            // 
            // hryvnaBought
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.hryvnaBought.DefaultCellStyle = dataGridViewCellStyle6;
            this.hryvnaBought.HeaderText = "Гривна (покупка)";
            this.hryvnaBought.Name = "hryvnaBought";
            this.hryvnaBought.Width = 120;
            // 
            // hryvnaSale
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.hryvnaSale.DefaultCellStyle = dataGridViewCellStyle7;
            this.hryvnaSale.HeaderText = "Гривна (продажа)";
            this.hryvnaSale.Name = "hryvnaSale";
            this.hryvnaSale.Width = 120;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 561);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn euroBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn euroSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn hryvnaBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn hryvnaSale;
    }
}