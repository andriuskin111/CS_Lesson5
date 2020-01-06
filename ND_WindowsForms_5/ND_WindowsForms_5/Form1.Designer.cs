namespace ND_WindowsForms_5
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
            this.btnKonvertuoti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(148, 62);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 26);
            this.tbInput.TabIndex = 0;
            // 
            // btnKonvertuoti
            // 
            this.btnKonvertuoti.Location = new System.Drawing.Point(42, 141);
            this.btnKonvertuoti.Name = "btnKonvertuoti";
            this.btnKonvertuoti.Size = new System.Drawing.Size(308, 64);
            this.btnKonvertuoti.TabIndex = 1;
            this.btnKonvertuoti.Text = "Konvertuoti";
            this.btnKonvertuoti.UseVisualStyleBackColor = true;
            this.btnKonvertuoti.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iveskite temperatura laipsniais pagal celsiju";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(42, 212);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(308, 226);
            this.tbOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonvertuoti);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Temperaturos konverteris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnKonvertuoti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

