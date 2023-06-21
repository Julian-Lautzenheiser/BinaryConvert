
namespace Binary
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
            this.cboxMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.buttTrans = new System.Windows.Forms.Button();
            this.tboxOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxMode
            // 
            this.cboxMode.FormattingEnabled = true;
            this.cboxMode.Items.AddRange(new object[] {
            "Binary to Decimal",
            "Binary to Octal",
            "Binary to Hexadecimal",
            "Decimal to Binary",
            "Decimal to Octal",
            "Decimal to Hexadecimal",
            "Octal to Binary",
            "Octal to Decimal",
            "Octal to Hexadecimal",
            "Hexadecimal to Binary",
            "Hexadecimal to Octal",
            "Hexadecimal to Decimal",
            "Binary to Alphanumerical",
            "Octal to Alphanumerical",
            "Hexadecimal to Alphanumerical",
            "Alphanumerical to Binary",
            "Alphanumerical to Octal",
            "Alphanumerical to Hexadecimal"});
            this.cboxMode.Location = new System.Drawing.Point(214, 69);
            this.cboxMode.Name = "cboxMode";
            this.cboxMode.Size = new System.Drawing.Size(184, 21);
            this.cboxMode.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(171, 72);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode:";
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(214, 97);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(184, 20);
            this.tboxInput.TabIndex = 2;
            this.tboxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxInput_KeyPress);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(173, 103);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(34, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input:";
            // 
            // buttTrans
            // 
            this.buttTrans.Location = new System.Drawing.Point(269, 141);
            this.buttTrans.Name = "buttTrans";
            this.buttTrans.Size = new System.Drawing.Size(75, 23);
            this.buttTrans.TabIndex = 4;
            this.buttTrans.Text = "Translate";
            this.buttTrans.UseVisualStyleBackColor = true;
            this.buttTrans.Click += new System.EventHandler(this.buttTrans_Click);
            // 
            // tboxOutput
            // 
            this.tboxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.tboxOutput.Location = new System.Drawing.Point(214, 196);
            this.tboxOutput.Name = "tboxOutput";
            this.tboxOutput.ReadOnly = true;
            this.tboxOutput.Size = new System.Drawing.Size(184, 20);
            this.tboxOutput.TabIndex = 5;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(166, 203);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 312);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tboxOutput);
            this.Controls.Add(this.buttTrans);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.tboxInput);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.cboxMode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button buttTrans;
        private System.Windows.Forms.TextBox tboxOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

