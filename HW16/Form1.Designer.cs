namespace HW16
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
            this.PathLabel = new System.Windows.Forms.Label();
            this.Pathbox = new System.Windows.Forms.TextBox();
            this.ExtensionLabel = new System.Windows.Forms.Label();
            this.ExtensionDropbox = new System.Windows.Forms.ComboBox();
            this.StringLabel = new System.Windows.Forms.Label();
            this.StringBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SearchBttn = new System.Windows.Forms.Button();
            this.Clearbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AccessibleName = "PathLabel";
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(42, 53);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(52, 25);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Path";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // Pathbox
            // 
            this.Pathbox.AccessibleName = "PathLabel";
            this.Pathbox.Location = new System.Drawing.Point(160, 57);
            this.Pathbox.Name = "Pathbox";
            this.Pathbox.Size = new System.Drawing.Size(358, 22);
            this.Pathbox.TabIndex = 1;
            this.Pathbox.Text = "C:\\Users\\ClevelandCodes\\source\\repos\\css";
            // 
            // ExtensionLabel
            // 
            this.ExtensionLabel.AccessibleName = "ExtensionLabel";
            this.ExtensionLabel.AutoSize = true;
            this.ExtensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionLabel.Location = new System.Drawing.Point(42, 132);
            this.ExtensionLabel.Name = "ExtensionLabel";
            this.ExtensionLabel.Size = new System.Drawing.Size(98, 25);
            this.ExtensionLabel.TabIndex = 2;
            this.ExtensionLabel.Text = "Extension";
            // 
            // ExtensionDropbox
            // 
            this.ExtensionDropbox.AccessibleName = "ExtensionDropbox";
            this.ExtensionDropbox.FormattingEnabled = true;
            this.ExtensionDropbox.Items.AddRange(new object[] {
            ".XML",
            ".TXT",
            ".JSON",
            ".CONFIG"});
            this.ExtensionDropbox.Location = new System.Drawing.Point(160, 132);
            this.ExtensionDropbox.Name = "ExtensionDropbox";
            this.ExtensionDropbox.Size = new System.Drawing.Size(358, 24);
            this.ExtensionDropbox.TabIndex = 3;
            // 
            // StringLabel
            // 
            this.StringLabel.AccessibleName = "StringLabel";
            this.StringLabel.AutoSize = true;
            this.StringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringLabel.Location = new System.Drawing.Point(47, 205);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(63, 25);
            this.StringLabel.TabIndex = 4;
            this.StringLabel.Text = "String";
            // 
            // StringBox
            // 
            this.StringBox.AccessibleName = "StringBox";
            this.StringBox.Location = new System.Drawing.Point(160, 208);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(358, 22);
            this.StringBox.TabIndex = 5;
            // 
            // ResultBox
            // 
            this.ResultBox.AccessibleName = "ResultBox";
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 16;
            this.ResultBox.Location = new System.Drawing.Point(160, 294);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(358, 132);
            this.ResultBox.TabIndex = 6;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AccessibleName = "ResultLabel";
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(47, 294);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(66, 25);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result";
            // 
            // SearchBttn
            // 
            this.SearchBttn.AccessibleName = "SearchBttn";
            this.SearchBttn.Location = new System.Drawing.Point(160, 461);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(97, 42);
            this.SearchBttn.TabIndex = 8;
            this.SearchBttn.Text = "Search";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // Clearbttn
            // 
            this.Clearbttn.AccessibleName = "Clearbttn";
            this.Clearbttn.Location = new System.Drawing.Point(421, 461);
            this.Clearbttn.Name = "Clearbttn";
            this.Clearbttn.Size = new System.Drawing.Size(97, 42);
            this.Clearbttn.TabIndex = 9;
            this.Clearbttn.Text = "Clear";
            this.Clearbttn.UseVisualStyleBackColor = true;
            this.Clearbttn.Click += new System.EventHandler(this.Clearbttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 541);
            this.Controls.Add(this.Clearbttn);
            this.Controls.Add(this.SearchBttn);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.ExtensionDropbox);
            this.Controls.Add(this.ExtensionLabel);
            this.Controls.Add(this.Pathbox);
            this.Controls.Add(this.PathLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnExit);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox Pathbox;
        private System.Windows.Forms.Label ExtensionLabel;
        private System.Windows.Forms.ComboBox ExtensionDropbox;
        private System.Windows.Forms.Label StringLabel;
        private System.Windows.Forms.TextBox StringBox;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Button Clearbttn;
    }
}

