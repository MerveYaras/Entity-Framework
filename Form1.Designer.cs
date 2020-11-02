namespace NorthwindTablolarınıÇekme
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
            this.btnBilgiGetir = new System.Windows.Forms.Button();
            this.cmbTablolar = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBilgiGetir
            // 
            this.btnBilgiGetir.Location = new System.Drawing.Point(190, 118);
            this.btnBilgiGetir.Name = "btnBilgiGetir";
            this.btnBilgiGetir.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiGetir.TabIndex = 0;
            this.btnBilgiGetir.Text = "Getir";
            this.btnBilgiGetir.UseVisualStyleBackColor = true;
            this.btnBilgiGetir.Click += new System.EventHandler(this.btnBilgiGetir_Click);
            // 
            // cmbTablolar
            // 
            this.cmbTablolar.FormattingEnabled = true;
            this.cmbTablolar.Location = new System.Drawing.Point(164, 91);
            this.cmbTablolar.Name = "cmbTablolar";
            this.cmbTablolar.Size = new System.Drawing.Size(121, 21);
            this.cmbTablolar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 173);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbTablolar);
            this.Controls.Add(this.btnBilgiGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGetir;
        private System.Windows.Forms.ComboBox cmbTablolar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

