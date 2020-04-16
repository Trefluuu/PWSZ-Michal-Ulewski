namespace biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sort = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.RadioButton();
            this.autor = new System.Windows.Forms.RadioButton();
            this.tytul = new System.Windows.Forms.RadioButton();
            this.wydawnictwo = new System.Windows.Forms.RadioButton();
            this.data_wydania_stara = new System.Windows.Forms.RadioButton();
            this.dostepnosc = new System.Windows.Forms.RadioButton();
            this.data_wydania_mloda = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 381);
            this.listBox1.TabIndex = 0;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(656, 382);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(119, 41);
            this.sort.TabIndex = 1;
            this.sort.Text = "Uruchom/ Sortuj";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(531, 382);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(119, 41);
            this.dodaj.TabIndex = 2;
            this.dodaj.Text = "Dodaj ksiazke";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(406, 382);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(119, 41);
            this.usun.TabIndex = 3;
            this.usun.Text = "Usun ksiazke";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(418, 71);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(36, 17);
            this.id.TabIndex = 4;
            this.id.TabStop = true;
            this.id.Text = "ID";
            this.id.UseVisualStyleBackColor = true;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(418, 114);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(50, 17);
            this.autor.TabIndex = 5;
            this.autor.TabStop = true;
            this.autor.Text = "Autor";
            this.autor.UseVisualStyleBackColor = true;
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(418, 149);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(48, 17);
            this.tytul.TabIndex = 6;
            this.tytul.TabStop = true;
            this.tytul.Text = "Tytul";
            this.tytul.UseVisualStyleBackColor = true;
            // 
            // wydawnictwo
            // 
            this.wydawnictwo.AutoSize = true;
            this.wydawnictwo.Location = new System.Drawing.Point(418, 187);
            this.wydawnictwo.Name = "wydawnictwo";
            this.wydawnictwo.Size = new System.Drawing.Size(92, 17);
            this.wydawnictwo.TabIndex = 7;
            this.wydawnictwo.TabStop = true;
            this.wydawnictwo.Text = "Wydawnictwo";
            this.wydawnictwo.UseVisualStyleBackColor = true;
            // 
            // data_wydania_stara
            // 
            this.data_wydania_stara.AutoSize = true;
            this.data_wydania_stara.Location = new System.Drawing.Point(418, 227);
            this.data_wydania_stara.Name = "data_wydania_stara";
            this.data_wydania_stara.Size = new System.Drawing.Size(163, 17);
            this.data_wydania_stara.TabIndex = 8;
            this.data_wydania_stara.TabStop = true;
            this.data_wydania_stara.Text = "Data wydania (od najstarszej)";
            this.data_wydania_stara.UseVisualStyleBackColor = true;
            // 
            // dostepnosc
            // 
            this.dostepnosc.AutoSize = true;
            this.dostepnosc.Location = new System.Drawing.Point(418, 296);
            this.dostepnosc.Name = "dostepnosc";
            this.dostepnosc.Size = new System.Drawing.Size(82, 17);
            this.dostepnosc.TabIndex = 9;
            this.dostepnosc.TabStop = true;
            this.dostepnosc.Text = "Dostepnosc";
            this.dostepnosc.UseVisualStyleBackColor = true;
            // 
            // data_wydania_mloda
            // 
            this.data_wydania_mloda.AutoSize = true;
            this.data_wydania_mloda.Location = new System.Drawing.Point(418, 263);
            this.data_wydania_mloda.Name = "data_wydania_mloda";
            this.data_wydania_mloda.Size = new System.Drawing.Size(168, 17);
            this.data_wydania_mloda.TabIndex = 10;
            this.data_wydania_mloda.TabStop = true;
            this.data_wydania_mloda.Text = "Data wydania (od najnowszejj)";
            this.data_wydania_mloda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_wydania_mloda);
            this.Controls.Add(this.dostepnosc);
            this.Controls.Add(this.data_wydania_stara);
            this.Controls.Add(this.wydawnictwo);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.id);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.RadioButton id;
        private System.Windows.Forms.RadioButton autor;
        private System.Windows.Forms.RadioButton tytul;
        private System.Windows.Forms.RadioButton wydawnictwo;
        private System.Windows.Forms.RadioButton data_wydania_stara;
        private System.Windows.Forms.RadioButton dostepnosc;
        private System.Windows.Forms.RadioButton data_wydania_mloda;
    }
}

