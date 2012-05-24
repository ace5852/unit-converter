namespace Unit_Converter
{
    partial class TempatureConversions
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtdegC = new System.Windows.Forms.TextBox();
            this.txtdegF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(187, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(108, 23);
            this.btnConvert.TabIndex = 28;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kelvin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Celsius ";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(72, 58);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 21;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // txtdegC
            // 
            this.txtdegC.Location = new System.Drawing.Point(72, 32);
            this.txtdegC.Name = "txtdegC";
            this.txtdegC.Size = new System.Drawing.Size(100, 20);
            this.txtdegC.TabIndex = 20;
            this.txtdegC.TextChanged += new System.EventHandler(this.txtdegC_TextChanged);
            // 
            // txtdegF
            // 
            this.txtdegF.Location = new System.Drawing.Point(72, 6);
            this.txtdegF.Name = "txtdegF";
            this.txtdegF.Size = new System.Drawing.Size(100, 20);
            this.txtdegF.TabIndex = 19;
            this.txtdegF.TextChanged += new System.EventHandler(this.txtdegF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fahrenheit";
            // 
            // TempatureConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 97);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtdegC);
            this.Controls.Add(this.txtdegF);
            this.Controls.Add(this.label1);
            this.Name = "TempatureConversions";
            this.Text = "TempatureConversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtdegC;
        private System.Windows.Forms.TextBox txtdegF;
        private System.Windows.Forms.Label label1;
    }
}