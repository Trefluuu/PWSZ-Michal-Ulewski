namespace Pesel
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
            this.Pesel = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.Spr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(334, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESEL";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(284, 166);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(232, 20);
            this.Pesel.TabIndex = 1;
            this.Pesel.Text = "Wprowadź PESEL";
            this.Pesel.TextChanged += new System.EventHandler(this.Pesel_TextChanged);
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Location = new System.Drawing.Point(335, 259);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(0, 13);
            this.Wynik.TabIndex = 2;
            // 
            // Spr
            // 
            this.Spr.Location = new System.Drawing.Point(321, 207);
            this.Spr.Name = "Spr";
            this.Spr.Size = new System.Drawing.Size(152, 35);
            this.Spr.TabIndex = 3;
            this.Spr.Text = "Sprawdź poprawność";
            this.Spr.UseVisualStyleBackColor = true;
            this.Spr.Click += new System.EventHandler(this.Spr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Spr);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Button Spr;
    }
}

