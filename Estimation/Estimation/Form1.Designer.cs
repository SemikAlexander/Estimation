﻿namespace Estimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.началоДняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долларToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.гривнаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.всёToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долларToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гривнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.долларToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.евроToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.гривнаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.всёToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияОтчётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressDataGridView = new System.Windows.Forms.DataGridView();
            this.ChoiseCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SumPrise = new System.Windows.Forms.TextBox();
            this.CoursePrise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBoughtCurrency = new System.Windows.Forms.Button();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePurchasedSumDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.отчётToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(430, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыВалютToolStripMenuItem,
            this.началоДняToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
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
            this.началоДняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.долларToolStripMenuItem2,
            this.евроToolStripMenuItem2,
            this.гривнаToolStripMenuItem2,
            this.всёToolStripMenuItem2});
            this.началоДняToolStripMenuItem.Name = "началоДняToolStripMenuItem";
            this.началоДняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.началоДняToolStripMenuItem.Text = "Начало дня";
            // 
            // долларToolStripMenuItem2
            // 
            this.долларToolStripMenuItem2.Name = "долларToolStripMenuItem2";
            this.долларToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.долларToolStripMenuItem2.Text = "Доллар";
            // 
            // евроToolStripMenuItem2
            // 
            this.евроToolStripMenuItem2.Name = "евроToolStripMenuItem2";
            this.евроToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.евроToolStripMenuItem2.Text = "Евро";
            // 
            // гривнаToolStripMenuItem2
            // 
            this.гривнаToolStripMenuItem2.Name = "гривнаToolStripMenuItem2";
            this.гривнаToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.гривнаToolStripMenuItem2.Text = "Гривна";
            // 
            // всёToolStripMenuItem2
            // 
            this.всёToolStripMenuItem2.Name = "всёToolStripMenuItem2";
            this.всёToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.всёToolStripMenuItem2.Text = "Всё";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расходыToolStripMenuItem,
            this.приходToolStripMenuItem,
            this.генерацияОтчётаToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // расходыToolStripMenuItem
            // 
            this.расходыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.долларToolStripMenuItem,
            this.евроToolStripMenuItem,
            this.гривнаToolStripMenuItem,
            this.всёToolStripMenuItem});
            this.расходыToolStripMenuItem.Name = "расходыToolStripMenuItem";
            this.расходыToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.расходыToolStripMenuItem.Text = "Расход";
            // 
            // долларToolStripMenuItem
            // 
            this.долларToolStripMenuItem.Name = "долларToolStripMenuItem";
            this.долларToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.долларToolStripMenuItem.Text = "Доллар";
            // 
            // евроToolStripMenuItem
            // 
            this.евроToolStripMenuItem.Name = "евроToolStripMenuItem";
            this.евроToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.евроToolStripMenuItem.Text = "Евро";
            // 
            // гривнаToolStripMenuItem
            // 
            this.гривнаToolStripMenuItem.Name = "гривнаToolStripMenuItem";
            this.гривнаToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.гривнаToolStripMenuItem.Text = "Гривна";
            // 
            // всёToolStripMenuItem
            // 
            this.всёToolStripMenuItem.Name = "всёToolStripMenuItem";
            this.всёToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.всёToolStripMenuItem.Text = "Всё";
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.долларToolStripMenuItem1,
            this.евроToolStripMenuItem1,
            this.гривнаToolStripMenuItem1,
            this.всёToolStripMenuItem1});
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.приходToolStripMenuItem.Text = "Приход";
            // 
            // долларToolStripMenuItem1
            // 
            this.долларToolStripMenuItem1.Name = "долларToolStripMenuItem1";
            this.долларToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.долларToolStripMenuItem1.Text = "Доллар";
            // 
            // евроToolStripMenuItem1
            // 
            this.евроToolStripMenuItem1.Name = "евроToolStripMenuItem1";
            this.евроToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.евроToolStripMenuItem1.Text = "Евро";
            // 
            // гривнаToolStripMenuItem1
            // 
            this.гривнаToolStripMenuItem1.Name = "гривнаToolStripMenuItem1";
            this.гривнаToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.гривнаToolStripMenuItem1.Text = "Гривна";
            // 
            // всёToolStripMenuItem1
            // 
            this.всёToolStripMenuItem1.Name = "всёToolStripMenuItem1";
            this.всёToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.всёToolStripMenuItem1.Text = "Всё";
            // 
            // генерацияОтчётаToolStripMenuItem
            // 
            this.генерацияОтчётаToolStripMenuItem.Name = "генерацияОтчётаToolStripMenuItem";
            this.генерацияОтчётаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.генерацияОтчётаToolStripMenuItem.Text = "Генерация отчёта";
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
            this.progressDataGridView.Location = new System.Drawing.Point(155, 28);
            this.progressDataGridView.Name = "progressDataGridView";
            this.progressDataGridView.Size = new System.Drawing.Size(263, 167);
            this.progressDataGridView.TabIndex = 1;
            this.progressDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progressDataGridView_CellDoubleClick);
            // 
            // ChoiseCurrency
            // 
            this.ChoiseCurrency.FormattingEnabled = true;
            this.ChoiseCurrency.Items.AddRange(new object[] {
            "Доллар",
            "Эвро",
            "Гривна"});
            this.ChoiseCurrency.Location = new System.Drawing.Point(12, 47);
            this.ChoiseCurrency.Name = "ChoiseCurrency";
            this.ChoiseCurrency.Size = new System.Drawing.Size(137, 24);
            this.ChoiseCurrency.TabIndex = 2;
            this.ChoiseCurrency.SelectedIndexChanged += new System.EventHandler(this.ChoiseCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Валюта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма";
            // 
            // SumPrise
            // 
            this.SumPrise.Location = new System.Drawing.Point(12, 93);
            this.SumPrise.Name = "SumPrise";
            this.SumPrise.Size = new System.Drawing.Size(134, 21);
            this.SumPrise.TabIndex = 5;
            this.SumPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CoursePrise
            // 
            this.CoursePrise.Location = new System.Drawing.Point(12, 136);
            this.CoursePrise.Name = "CoursePrise";
            this.CoursePrise.Size = new System.Drawing.Size(134, 21);
            this.CoursePrise.TabIndex = 7;
            this.CoursePrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Курс";
            // 
            // AddBoughtCurrency
            // 
            this.AddBoughtCurrency.Location = new System.Drawing.Point(35, 167);
            this.AddBoughtCurrency.Name = "AddBoughtCurrency";
            this.AddBoughtCurrency.Size = new System.Drawing.Size(88, 28);
            this.AddBoughtCurrency.TabIndex = 9;
            this.AddBoughtCurrency.Text = "Добавить";
            this.AddBoughtCurrency.UseVisualStyleBackColor = true;
            this.AddBoughtCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупкаToolStripMenuItem,
            this.продажаToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
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
            // PurchasedSumDollar
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 207);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView progressDataGridView;
        private System.Windows.Forms.ComboBox ChoiseCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumPrise;
        private System.Windows.Forms.TextBox CoursePrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBoughtCurrency;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долларToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гривнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долларToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem гривнаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem всёToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem генерацияОтчётаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem началоДняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem долларToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem евроToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem гривнаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem всёToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedSumDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePurchasedSumDollar;
    }
}

