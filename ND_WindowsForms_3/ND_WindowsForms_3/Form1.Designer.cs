namespace ND_WindowsForms_3
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnTikrinti = new System.Windows.Forms.Button();
            this.lblSkaicius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(182, 26);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 26);
            this.tbInput.TabIndex = 0;
            // 
            // btnTikrinti
            // 
            this.btnTikrinti.Location = new System.Drawing.Point(30, 110);
            this.btnTikrinti.Name = "btnTikrinti";
            this.btnTikrinti.Size = new System.Drawing.Size(252, 70);
            this.btnTikrinti.TabIndex = 1;
            this.btnTikrinti.Text = "Tikrinti";
            this.btnTikrinti.UseVisualStyleBackColor = true;
            this.btnTikrinti.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSkaicius
            // 
            this.lblSkaicius.AutoSize = true;
            this.lblSkaicius.Location = new System.Drawing.Point(26, 29);
            this.lblSkaicius.Name = "lblSkaicius";
            this.lblSkaicius.Size = new System.Drawing.Size(115, 20);
            this.lblSkaicius.TabIndex = 2;
            this.lblSkaicius.Text = "Iveskite skaiciu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 225);
            this.Controls.Add(this.lblSkaicius);
            this.Controls.Add(this.btnTikrinti);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnTikrinti;
        private System.Windows.Forms.Label lblSkaicius;
    }
}

