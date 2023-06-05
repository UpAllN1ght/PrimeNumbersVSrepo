namespace NumerePrime
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
            this.ButonNprime = new System.Windows.Forms.Button();
            this.Numarul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButonNprime
            // 
            this.ButonNprime.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonNprime.Location = new System.Drawing.Point(321, 211);
            this.ButonNprime.Name = "ButonNprime";
            this.ButonNprime.Size = new System.Drawing.Size(148, 50);
            this.ButonNprime.TabIndex = 0;
            this.ButonNprime.Text = "verifica";
            this.ButonNprime.UseVisualStyleBackColor = true;
            this.ButonNprime.Click += new System.EventHandler(this.ButonNprime_Click);
            // 
            // Numarul
            // 
            this.Numarul.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Numarul.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numarul.Location = new System.Drawing.Point(365, 136);
            this.Numarul.Name = "Numarul";
            this.Numarul.Size = new System.Drawing.Size(61, 43);
            this.Numarul.TabIndex = 1;
            this.Numarul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numarul);
            this.Controls.Add(this.ButonNprime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonNprime;
        private System.Windows.Forms.TextBox Numarul;
    }
}

