namespace Roman_numerals
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
            this.tbxNumbers = new System.Windows.Forms.TextBox();
            this.tbxRoman = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRoman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNumbers
            // 
            this.tbxNumbers.Location = new System.Drawing.Point(12, 88);
            this.tbxNumbers.Name = "tbxNumbers";
            this.tbxNumbers.Size = new System.Drawing.Size(236, 26);
            this.tbxNumbers.TabIndex = 0;
            // 
            // tbxRoman
            // 
            this.tbxRoman.Location = new System.Drawing.Point(277, 88);
            this.tbxRoman.Name = "tbxRoman";
            this.tbxRoman.ReadOnly = true;
            this.tbxRoman.Size = new System.Drawing.Size(240, 26);
            this.tbxRoman.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(213, 155);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(102, 41);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(236, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Write a number between 1-3999";
            // 
            // lblRoman
            // 
            this.lblRoman.AutoSize = true;
            this.lblRoman.Location = new System.Drawing.Point(245, 62);
            this.lblRoman.Name = "lblRoman";
            this.lblRoman.Size = new System.Drawing.Size(272, 20);
            this.lblRoman.TabIndex = 4;
            this.lblRoman.Text = "and see what it is in Roman numerals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 224);
            this.Controls.Add(this.lblRoman);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbxRoman);
            this.Controls.Add(this.tbxNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumbers;
        private System.Windows.Forms.TextBox tbxRoman;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblRoman;
    }
}

