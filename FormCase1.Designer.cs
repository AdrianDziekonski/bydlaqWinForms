namespace Forms1
{
    partial class FormCase1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase1));
            this.bydlaqForm2 = new System.Windows.Forms.Label();
            this.BoxRasa = new System.Windows.Forms.TextBox();
            this.labelWprowadzRase = new System.Windows.Forms.Label();
            this.labelWprowadzNrIdent = new System.Windows.Forms.Label();
            this.labelWprowadznazwe = new System.Windows.Forms.Label();
            this.labelWprowadzDateUr = new System.Windows.Forms.Label();
            this.labelWprowadzTypUzytkowy = new System.Windows.Forms.Label();
            this.BoxNrIdent = new System.Windows.Forms.TextBox();
            this.BoxNazwa = new System.Windows.Forms.TextBox();
            this.BoxDataUr = new System.Windows.Forms.TextBox();
            this.BoxTypUzytkowy = new System.Windows.Forms.TextBox();
            this.labelWprowadzDateKrycia = new System.Windows.Forms.Label();
            this.labelWprowadzDateWycielenia = new System.Windows.Forms.Label();
            this.labelWprowadzCielnosc = new System.Windows.Forms.Label();
            this.labelPlanowaneWycielenie = new System.Windows.Forms.Label();
            this.BoxDataKrycia = new System.Windows.Forms.TextBox();
            this.BoxDataWycielenia = new System.Windows.Forms.TextBox();
            this.BoxCielnosc = new System.Windows.Forms.TextBox();
            this.BoxPlanowaneWycielenie = new System.Windows.Forms.TextBox();
            this.btnDodajZwierze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bydlaqForm2
            // 
            this.bydlaqForm2.BackColor = System.Drawing.Color.Transparent;
            this.bydlaqForm2.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bydlaqForm2.ForeColor = System.Drawing.Color.Crimson;
            this.bydlaqForm2.Location = new System.Drawing.Point(2, 9);
            this.bydlaqForm2.Name = "bydlaqForm2";
            this.bydlaqForm2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bydlaqForm2.Size = new System.Drawing.Size(255, 78);
            this.bydlaqForm2.TabIndex = 2;
            this.bydlaqForm2.Text = "BydlaQ";
            this.bydlaqForm2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoxRasa
            // 
            this.BoxRasa.Location = new System.Drawing.Point(517, 94);
            this.BoxRasa.Name = "BoxRasa";
            this.BoxRasa.Size = new System.Drawing.Size(227, 20);
            this.BoxRasa.TabIndex = 3;
            this.BoxRasa.TextChanged += new System.EventHandler(this.BoxRasa_TextChanged);
            // 
            // labelWprowadzRase
            // 
            this.labelWprowadzRase.AutoSize = true;
            this.labelWprowadzRase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzRase.Location = new System.Drawing.Point(77, 92);
            this.labelWprowadzRase.Name = "labelWprowadzRase";
            this.labelWprowadzRase.Size = new System.Drawing.Size(119, 20);
            this.labelWprowadzRase.TabIndex = 5;
            this.labelWprowadzRase.Text = "Wprowadź rasę";
            // 
            // labelWprowadzNrIdent
            // 
            this.labelWprowadzNrIdent.AutoSize = true;
            this.labelWprowadzNrIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzNrIdent.Location = new System.Drawing.Point(77, 131);
            this.labelWprowadzNrIdent.Name = "labelWprowadzNrIdent";
            this.labelWprowadzNrIdent.Size = new System.Drawing.Size(238, 20);
            this.labelWprowadzNrIdent.TabIndex = 6;
            this.labelWprowadzNrIdent.Text = "Wprowadź numer identyfikacyjny";
            // 
            // labelWprowadznazwe
            // 
            this.labelWprowadznazwe.AutoSize = true;
            this.labelWprowadznazwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadznazwe.Location = new System.Drawing.Point(77, 175);
            this.labelWprowadznazwe.Name = "labelWprowadznazwe";
            this.labelWprowadznazwe.Size = new System.Drawing.Size(134, 20);
            this.labelWprowadznazwe.TabIndex = 7;
            this.labelWprowadznazwe.Text = "Wprowadź nazwę";
            this.labelWprowadznazwe.Click += new System.EventHandler(this.labelWprowadznazwe_Click);
            // 
            // labelWprowadzDateUr
            // 
            this.labelWprowadzDateUr.AutoSize = true;
            this.labelWprowadzDateUr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzDateUr.Location = new System.Drawing.Point(77, 225);
            this.labelWprowadzDateUr.Name = "labelWprowadzDateUr";
            this.labelWprowadzDateUr.Size = new System.Drawing.Size(280, 20);
            this.labelWprowadzDateUr.TabIndex = 8;
            this.labelWprowadzDateUr.Text = "Wprowadź datę urodzenia dd-MM-yyyy";
            this.labelWprowadzDateUr.Click += new System.EventHandler(this.labelWprowadzDateUr_Click);
            // 
            // labelWprowadzTypUzytkowy
            // 
            this.labelWprowadzTypUzytkowy.AutoSize = true;
            this.labelWprowadzTypUzytkowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzTypUzytkowy.Location = new System.Drawing.Point(77, 266);
            this.labelWprowadzTypUzytkowy.Name = "labelWprowadzTypUzytkowy";
            this.labelWprowadzTypUzytkowy.Size = new System.Drawing.Size(322, 20);
            this.labelWprowadzTypUzytkowy.TabIndex = 9;
            this.labelWprowadzTypUzytkowy.Text = "Wprowadź typ użytkowy(krowa, byk, jałówka)";
            // 
            // BoxNrIdent
            // 
            this.BoxNrIdent.Location = new System.Drawing.Point(517, 135);
            this.BoxNrIdent.Name = "BoxNrIdent";
            this.BoxNrIdent.Size = new System.Drawing.Size(227, 20);
            this.BoxNrIdent.TabIndex = 10;
            this.BoxNrIdent.TextChanged += new System.EventHandler(this.BoxNrIdent_TextChanged);
            // 
            // BoxNazwa
            // 
            this.BoxNazwa.Location = new System.Drawing.Point(517, 179);
            this.BoxNazwa.Name = "BoxNazwa";
            this.BoxNazwa.Size = new System.Drawing.Size(227, 20);
            this.BoxNazwa.TabIndex = 11;
            this.BoxNazwa.TextChanged += new System.EventHandler(this.BoxNazwa_TextChanged);
            // 
            // BoxDataUr
            // 
            this.BoxDataUr.Location = new System.Drawing.Point(517, 227);
            this.BoxDataUr.Name = "BoxDataUr";
            this.BoxDataUr.Size = new System.Drawing.Size(227, 20);
            this.BoxDataUr.TabIndex = 12;
            this.BoxDataUr.TextChanged += new System.EventHandler(this.BoxDataUr_TextChanged);
            // 
            // BoxTypUzytkowy
            // 
            this.BoxTypUzytkowy.Location = new System.Drawing.Point(517, 270);
            this.BoxTypUzytkowy.Name = "BoxTypUzytkowy";
            this.BoxTypUzytkowy.Size = new System.Drawing.Size(227, 20);
            this.BoxTypUzytkowy.TabIndex = 13;
            this.BoxTypUzytkowy.TextChanged += new System.EventHandler(this.BoxTypUzytkowy_TextChanged);
            // 
            // labelWprowadzDateKrycia
            // 
            this.labelWprowadzDateKrycia.AutoSize = true;
            this.labelWprowadzDateKrycia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzDateKrycia.Location = new System.Drawing.Point(77, 311);
            this.labelWprowadzDateKrycia.Name = "labelWprowadzDateKrycia";
            this.labelWprowadzDateKrycia.Size = new System.Drawing.Size(250, 20);
            this.labelWprowadzDateKrycia.TabIndex = 14;
            this.labelWprowadzDateKrycia.Text = "Wprowadź datę krycia dd-MM-yyyy";
            this.labelWprowadzDateKrycia.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWprowadzDateWycielenia
            // 
            this.labelWprowadzDateWycielenia.AutoSize = true;
            this.labelWprowadzDateWycielenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzDateWycielenia.Location = new System.Drawing.Point(77, 353);
            this.labelWprowadzDateWycielenia.Name = "labelWprowadzDateWycielenia";
            this.labelWprowadzDateWycielenia.Size = new System.Drawing.Size(281, 20);
            this.labelWprowadzDateWycielenia.TabIndex = 15;
            this.labelWprowadzDateWycielenia.Text = "Wprowadź datę wycielenia dd-MM-yyyy";
            // 
            // labelWprowadzCielnosc
            // 
            this.labelWprowadzCielnosc.AutoSize = true;
            this.labelWprowadzCielnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzCielnosc.Location = new System.Drawing.Point(77, 395);
            this.labelWprowadzCielnosc.Name = "labelWprowadzCielnosc";
            this.labelWprowadzCielnosc.Size = new System.Drawing.Size(392, 20);
            this.labelWprowadzCielnosc.TabIndex = 16;
            this.labelWprowadzCielnosc.Text = "Wpisz \"tak\" lub \"nie\" w zależności czy krowa jest cielna";
            // 
            // labelPlanowaneWycielenie
            // 
            this.labelPlanowaneWycielenie.AutoSize = true;
            this.labelPlanowaneWycielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlanowaneWycielenie.Location = new System.Drawing.Point(77, 435);
            this.labelPlanowaneWycielenie.Name = "labelPlanowaneWycielenie";
            this.labelPlanowaneWycielenie.Size = new System.Drawing.Size(380, 20);
            this.labelPlanowaneWycielenie.TabIndex = 17;
            this.labelPlanowaneWycielenie.Text = "Wprowadź datę planowanego wycielenia dd-MM-yyyy";
            // 
            // BoxDataKrycia
            // 
            this.BoxDataKrycia.Location = new System.Drawing.Point(517, 313);
            this.BoxDataKrycia.Name = "BoxDataKrycia";
            this.BoxDataKrycia.Size = new System.Drawing.Size(227, 20);
            this.BoxDataKrycia.TabIndex = 18;
            this.BoxDataKrycia.TextChanged += new System.EventHandler(this.BoxDataKrycia_TextChanged);
            // 
            // BoxDataWycielenia
            // 
            this.BoxDataWycielenia.Location = new System.Drawing.Point(517, 357);
            this.BoxDataWycielenia.Name = "BoxDataWycielenia";
            this.BoxDataWycielenia.Size = new System.Drawing.Size(227, 20);
            this.BoxDataWycielenia.TabIndex = 19;
            this.BoxDataWycielenia.TextChanged += new System.EventHandler(this.BoxDataWycielenia_TextChanged);
            // 
            // BoxCielnosc
            // 
            this.BoxCielnosc.Location = new System.Drawing.Point(517, 397);
            this.BoxCielnosc.Name = "BoxCielnosc";
            this.BoxCielnosc.Size = new System.Drawing.Size(227, 20);
            this.BoxCielnosc.TabIndex = 20;
            this.BoxCielnosc.TextChanged += new System.EventHandler(this.BoxCielnosc_TextChanged);
            // 
            // BoxPlanowaneWycielenie
            // 
            this.BoxPlanowaneWycielenie.Location = new System.Drawing.Point(517, 437);
            this.BoxPlanowaneWycielenie.Name = "BoxPlanowaneWycielenie";
            this.BoxPlanowaneWycielenie.Size = new System.Drawing.Size(227, 20);
            this.BoxPlanowaneWycielenie.TabIndex = 21;
            this.BoxPlanowaneWycielenie.TextChanged += new System.EventHandler(this.BoxPlanowaneWycielenie_TextChanged);
            // 
            // btnDodajZwierze
            // 
            this.btnDodajZwierze.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajZwierze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZwierze.Location = new System.Drawing.Point(604, 474);
            this.btnDodajZwierze.Name = "btnDodajZwierze";
            this.btnDodajZwierze.Size = new System.Drawing.Size(139, 33);
            this.btnDodajZwierze.TabIndex = 22;
            this.btnDodajZwierze.Text = "Dodaj zwierzę";
            this.btnDodajZwierze.UseVisualStyleBackColor = false;
            this.btnDodajZwierze.Click += new System.EventHandler(this.btnDodajZwierze_Click);
            // 
            // FormCase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnDodajZwierze);
            this.Controls.Add(this.BoxPlanowaneWycielenie);
            this.Controls.Add(this.BoxCielnosc);
            this.Controls.Add(this.BoxDataWycielenia);
            this.Controls.Add(this.BoxDataKrycia);
            this.Controls.Add(this.labelPlanowaneWycielenie);
            this.Controls.Add(this.labelWprowadzCielnosc);
            this.Controls.Add(this.labelWprowadzDateWycielenia);
            this.Controls.Add(this.labelWprowadzDateKrycia);
            this.Controls.Add(this.BoxTypUzytkowy);
            this.Controls.Add(this.BoxDataUr);
            this.Controls.Add(this.BoxNazwa);
            this.Controls.Add(this.BoxNrIdent);
            this.Controls.Add(this.labelWprowadzTypUzytkowy);
            this.Controls.Add(this.labelWprowadzDateUr);
            this.Controls.Add(this.labelWprowadznazwe);
            this.Controls.Add(this.labelWprowadzNrIdent);
            this.Controls.Add(this.labelWprowadzRase);
            this.Controls.Add(this.BoxRasa);
            this.Controls.Add(this.bydlaqForm2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase1";
            this.Text = "Dodaj zwierzę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bydlaqForm2;
        private System.Windows.Forms.TextBox BoxRasa;
        private System.Windows.Forms.Label labelWprowadzRase;
        private System.Windows.Forms.Label labelWprowadzNrIdent;
        private System.Windows.Forms.Label labelWprowadznazwe;
        private System.Windows.Forms.Label labelWprowadzDateUr;
        private System.Windows.Forms.Label labelWprowadzTypUzytkowy;
        private System.Windows.Forms.TextBox BoxNrIdent;
        private System.Windows.Forms.TextBox BoxNazwa;
        private System.Windows.Forms.TextBox BoxDataUr;
        private System.Windows.Forms.TextBox BoxTypUzytkowy;
        private System.Windows.Forms.Label labelWprowadzDateKrycia;
        private System.Windows.Forms.Label labelWprowadzDateWycielenia;
        private System.Windows.Forms.Label labelWprowadzCielnosc;
        private System.Windows.Forms.Label labelPlanowaneWycielenie;
        private System.Windows.Forms.TextBox BoxDataKrycia;
        private System.Windows.Forms.TextBox BoxDataWycielenia;
        private System.Windows.Forms.TextBox BoxCielnosc;
        private System.Windows.Forms.TextBox BoxPlanowaneWycielenie;
        private System.Windows.Forms.Button btnDodajZwierze;
    }
}