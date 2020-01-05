namespace ND_WindowsForms_1
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
            this.tbOtput = new System.Windows.Forms.TextBox();
            this.btnParodytiDuomenis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOtput
            // 
            this.tbOtput.Location = new System.Drawing.Point(30, 35);
            this.tbOtput.Name = "tbOtput";
            this.tbOtput.Size = new System.Drawing.Size(373, 26);
            this.tbOtput.TabIndex = 0;
            // 
            // btnParodytiDuomenis
            // 
            this.btnParodytiDuomenis.Location = new System.Drawing.Point(30, 101);
            this.btnParodytiDuomenis.Name = "btnParodytiDuomenis";
            this.btnParodytiDuomenis.Size = new System.Drawing.Size(373, 86);
            this.btnParodytiDuomenis.TabIndex = 1;
            this.btnParodytiDuomenis.Text = "Parodyti duomenis";
            this.btnParodytiDuomenis.UseVisualStyleBackColor = true;
            this.btnParodytiDuomenis.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 234);
            this.Controls.Add(this.btnParodytiDuomenis);
            this.Controls.Add(this.tbOtput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOtput;
        private System.Windows.Forms.Button btnParodytiDuomenis;
    }
}

