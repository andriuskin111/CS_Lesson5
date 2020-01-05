namespace KD_WindowsForms_1
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
            this.lblVardas = new System.Windows.Forms.Label();
            this.tbVardas = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnVardas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVardas
            // 
            this.lblVardas.AutoSize = true;
            this.lblVardas.Location = new System.Drawing.Point(38, 29);
            this.lblVardas.Name = "lblVardas";
            this.lblVardas.Size = new System.Drawing.Size(60, 20);
            this.lblVardas.TabIndex = 0;
            this.lblVardas.Text = "Vardas";
            // 
            // tbVardas
            // 
            this.tbVardas.Location = new System.Drawing.Point(104, 23);
            this.tbVardas.Name = "tbVardas";
            this.tbVardas.Size = new System.Drawing.Size(131, 26);
            this.tbVardas.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(42, 138);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(193, 254);
            this.tbOutput.TabIndex = 2;
            // 
            // btnVardas
            // 
            this.btnVardas.Location = new System.Drawing.Point(42, 71);
            this.btnVardas.Name = "btnVardas";
            this.btnVardas.Size = new System.Drawing.Size(193, 46);
            this.btnVardas.TabIndex = 3;
            this.btnVardas.Text = "Vardas";
            this.btnVardas.UseVisualStyleBackColor = true;
            this.btnVardas.Click += new System.EventHandler(this.btnVardas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.btnVardas);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbVardas);
            this.Controls.Add(this.lblVardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVardas;
        private System.Windows.Forms.TextBox tbVardas;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnVardas;
    }
}

