namespace ParameterizedSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.Customeridtextbox = new System.Windows.Forms.TextBox();
            this.GetTotalSell = new System.Windows.Forms.Button();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id";
            // 
            // Customeridtextbox
            // 
            this.Customeridtextbox.Location = new System.Drawing.Point(410, 138);
            this.Customeridtextbox.Name = "Customeridtextbox";
            this.Customeridtextbox.Size = new System.Drawing.Size(100, 22);
            this.Customeridtextbox.TabIndex = 1;
            // 
            // GetTotalSell
            // 
            this.GetTotalSell.Location = new System.Drawing.Point(304, 179);
            this.GetTotalSell.Name = "GetTotalSell";
            this.GetTotalSell.Size = new System.Drawing.Size(160, 23);
            this.GetTotalSell.TabIndex = 2;
            this.GetTotalSell.Text = "Get Total sell";
            this.GetTotalSell.UseVisualStyleBackColor = true;
            this.GetTotalSell.Click += new System.EventHandler(this.GetTotalSell_Click);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(349, 233);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(46, 17);
            this.TotalSalesLabel.TabIndex = 3;
            this.TotalSalesLabel.Text = "label2";
            this.TotalSalesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 567);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.GetTotalSell);
            this.Controls.Add(this.Customeridtextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Customeridtextbox;
        private System.Windows.Forms.Button GetTotalSell;
        private System.Windows.Forms.Label TotalSalesLabel;
    }
}

