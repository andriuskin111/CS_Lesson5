namespace KD_WindowsForms_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUgis = new System.Windows.Forms.TextBox();
            this.tbSvoris = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnAddToArray = new System.Windows.Forms.Button();
            this.btnShowArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ugis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Svoris";
            // 
            // tbUgis
            // 
            this.tbUgis.Location = new System.Drawing.Point(178, 108);
            this.tbUgis.Name = "tbUgis";
            this.tbUgis.Size = new System.Drawing.Size(120, 26);
            this.tbUgis.TabIndex = 2;
            // 
            // tbSvoris
            // 
            this.tbSvoris.Location = new System.Drawing.Point(178, 183);
            this.tbSvoris.Name = "tbSvoris";
            this.tbSvoris.Size = new System.Drawing.Size(120, 26);
            this.tbSvoris.TabIndex = 3;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(355, 108);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(325, 101);
            this.tbOutput.TabIndex = 4;
            // 
            // btnAddToArray
            // 
            this.btnAddToArray.Location = new System.Drawing.Point(100, 276);
            this.btnAddToArray.Name = "btnAddToArray";
            this.btnAddToArray.Size = new System.Drawing.Size(198, 43);
            this.btnAddToArray.TabIndex = 5;
            this.btnAddToArray.Text = "Padeti i masyva";
            this.btnAddToArray.UseVisualStyleBackColor = true;
            this.btnAddToArray.Click += new System.EventHandler(this.btnAddToArray_Click);
            // 
            // btnShowArray
            // 
            this.btnShowArray.Location = new System.Drawing.Point(355, 276);
            this.btnShowArray.Name = "btnShowArray";
            this.btnShowArray.Size = new System.Drawing.Size(325, 43);
            this.btnShowArray.TabIndex = 6;
            this.btnShowArray.Text = "Parodyti masyva";
            this.btnShowArray.UseVisualStyleBackColor = true;
            this.btnShowArray.Click += new System.EventHandler(this.btnShowArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowArray);
            this.Controls.Add(this.btnAddToArray);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbSvoris);
            this.Controls.Add(this.tbUgis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kuno duomenys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUgis;
        private System.Windows.Forms.TextBox tbSvoris;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnAddToArray;
        private System.Windows.Forms.Button btnShowArray;
    }
}

