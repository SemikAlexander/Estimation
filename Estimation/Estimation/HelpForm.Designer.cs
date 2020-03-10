namespace Estimation
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.OutputInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputInfoTextBox
            // 
            this.OutputInfoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.OutputInfoTextBox.Location = new System.Drawing.Point(12, 12);
            this.OutputInfoTextBox.Multiline = true;
            this.OutputInfoTextBox.Name = "OutputInfoTextBox";
            this.OutputInfoTextBox.ReadOnly = true;
            this.OutputInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputInfoTextBox.Size = new System.Drawing.Size(904, 489);
            this.OutputInfoTextBox.TabIndex = 1;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 513);
            this.Controls.Add(this.OutputInfoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(944, 552);
            this.MinimumSize = new System.Drawing.Size(944, 552);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputInfoTextBox;
    }
}