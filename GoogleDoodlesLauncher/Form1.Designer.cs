namespace RestartBrowser
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
            this.SelectBrowserComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectGameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectBrowserComboBox
            // 
            this.SelectBrowserComboBox.FormattingEnabled = true;
            this.SelectBrowserComboBox.Location = new System.Drawing.Point(172, 12);
            this.SelectBrowserComboBox.Name = "SelectBrowserComboBox";
            this.SelectBrowserComboBox.Size = new System.Drawing.Size(155, 25);
            this.SelectBrowserComboBox.TabIndex = 0;
            this.SelectBrowserComboBox.Text = "Chrome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your browser:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(206, 84);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 36);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Exit";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 84);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(122, 36);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select game:";
            // 
            // SelectGameComboBox
            // 
            this.SelectGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectGameComboBox.DropDownWidth = 300;
            this.SelectGameComboBox.FormattingEnabled = true;
            this.SelectGameComboBox.Items.AddRange(new object[] {
            "Champion Island 2021",
            "Halloween 2020",
            "Valentine\'s Day 2017",
            "Halloween 2016",
            "Celebrating 50 years of Kids Coding 2017",
            "PAC-MAN 30th Anniversary"});
            this.SelectGameComboBox.Location = new System.Drawing.Point(172, 48);
            this.SelectGameComboBox.Name = "SelectGameComboBox";
            this.SelectGameComboBox.Size = new System.Drawing.Size(155, 25);
            this.SelectGameComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 129);
            this.Controls.Add(this.SelectGameComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectBrowserComboBox);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Google Doodle Game Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectBrowserComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectGameComboBox;
    }
}

