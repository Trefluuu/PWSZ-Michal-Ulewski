namespace BMR
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
            this.waga = new System.Windows.Forms.TextBox();
            this.waga1 = new System.Windows.Forms.Label();
            this.wzrost = new System.Windows.Forms.TextBox();
            this.wiek = new System.Windows.Forms.TextBox();
            this.wzrost1 = new System.Windows.Forms.Label();
            this.wiek1 = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.RadioButton();
            this.kobieta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.wyczysc = new System.Windows.Forms.Button();
            this.oblicz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(81, 123);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(100, 20);
            this.waga.TabIndex = 0;
            // 
            // waga1
            // 
            this.waga1.AutoSize = true;
            this.waga1.Location = new System.Drawing.Point(100, 107);
            this.waga1.Name = "waga1";
            this.waga1.Size = new System.Drawing.Size(57, 13);
            this.waga1.TabIndex = 1;
            this.waga1.Text = "Waga [kg]";
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(81, 201);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(100, 20);
            this.wzrost.TabIndex = 2;
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(81, 284);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(100, 20);
            this.wiek.TabIndex = 3;
            // 
            // wzrost1
            // 
            this.wzrost1.AutoSize = true;
            this.wzrost1.Location = new System.Drawing.Point(100, 185);
            this.wzrost1.Name = "wzrost1";
            this.wzrost1.Size = new System.Drawing.Size(63, 13);
            this.wzrost1.TabIndex = 4;
            this.wzrost1.Text = "Wzrost [cm]";
            // 
            // wiek1
            // 
            this.wiek1.AutoSize = true;
            this.wiek1.Location = new System.Drawing.Point(103, 268);
            this.wiek1.Name = "wiek1";
            this.wiek1.Size = new System.Drawing.Size(32, 13);
            this.wiek1.TabIndex = 5;
            this.wiek1.Text = "Wiek";
            // 
            // tytul
            // 
            this.tytul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tytul.AutoSize = true;
            this.tytul.BackColor = System.Drawing.SystemColors.Control;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tytul.Location = new System.Drawing.Point(116, 42);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(609, 37);
            this.tytul.TabIndex = 6;
            this.tytul.Text = "OBLICZ SWÓJ WSPÓŁCZYNNIK BMR";
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(268, 210);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(78, 17);
            this.men.TabIndex = 7;
            this.men.TabStop = true;
            this.men.Text = "Mężczyzna";
            this.men.UseVisualStyleBackColor = true;
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(268, 233);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(61, 17);
            this.kobieta.TabIndex = 8;
            this.kobieta.TabStop = true;
            this.kobieta.Text = "Kobieta";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Płeć";
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(462, 357);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(108, 53);
            this.wyczysc.TabIndex = 10;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // oblicz
            // 
            this.oblicz.Location = new System.Drawing.Point(617, 357);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(108, 53);
            this.oblicz.TabIndex = 10;
            this.oblicz.Text = "Oblicz";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(550, 242);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 39);
            this.wynik.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(618, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "BMR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.men);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.wiek1);
            this.Controls.Add(this.wzrost1);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga1);
            this.Controls.Add(this.waga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waga;
        private System.Windows.Forms.Label waga1;
        private System.Windows.Forms.TextBox wzrost;
        private System.Windows.Forms.TextBox wiek;
        private System.Windows.Forms.Label wzrost1;
        private System.Windows.Forms.Label wiek1;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.RadioButton kobieta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wyczysc;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label label2;
    }
}

