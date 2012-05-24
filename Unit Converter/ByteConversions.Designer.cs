namespace Unit_Converter
{
    partial class Byte_Conversions
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
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.txtKB = new System.Windows.Forms.TextBox();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bytes";
            // 
            // txtBytes
            // 
            this.txtBytes.Location = new System.Drawing.Point(63, 13);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.Size = new System.Drawing.Size(100, 20);
            this.txtBytes.TabIndex = 1;
            this.txtBytes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKB
            // 
            this.txtKB.Location = new System.Drawing.Point(63, 39);
            this.txtKB.Name = "txtKB";
            this.txtKB.Size = new System.Drawing.Size(100, 20);
            this.txtKB.TabIndex = 2;
            this.txtKB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(63, 65);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(100, 20);
            this.txtMB.TabIndex = 3;
            this.txtMB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(63, 91);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(100, 20);
            this.txtGB.TabIndex = 4;
            this.txtGB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(63, 117);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(100, 20);
            this.txtTB.TabIndex = 5;
            this.txtTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "KB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "MB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "GB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "TB";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(187, 13);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(108, 23);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Byte_Conversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 154);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.txtKB);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Byte_Conversions";
            this.Text = "Convert Computer Storage Units";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.TextBox txtKB;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
    }
}