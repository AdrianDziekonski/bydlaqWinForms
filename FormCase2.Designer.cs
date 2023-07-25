namespace Forms1
{
    partial class FormCase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase2));
            this.labelWprowadzNrWyszukiwanie = new System.Windows.Forms.Label();
            this.BoxWyszukajPoNr = new System.Windows.Forms.TextBox();
            this.BtnSzukajPoNr = new System.Windows.Forms.Button();
            this.BoxWyswietlPoNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWprowadzNrWyszukiwanie
            // 
            this.labelWprowadzNrWyszukiwanie.AutoSize = true;
            this.labelWprowadzNrWyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzNrWyszukiwanie.Location = new System.Drawing.Point(26, 62);
            this.labelWprowadzNrWyszukiwanie.Name = "labelWprowadzNrWyszukiwanie";
            this.labelWprowadzNrWyszukiwanie.Size = new System.Drawing.Size(378, 24);
            this.labelWprowadzNrWyszukiwanie.TabIndex = 0;
            this.labelWprowadzNrWyszukiwanie.Text = "Wprowadź numer identyfikacyjny zwierzęcia";
            // 
            // BoxWyszukajPoNr
            // 
            this.BoxWyszukajPoNr.Location = new System.Drawing.Point(410, 66);
            this.BoxWyszukajPoNr.Name = "BoxWyszukajPoNr";
            this.BoxWyszukajPoNr.Size = new System.Drawing.Size(332, 20);
            this.BoxWyszukajPoNr.TabIndex = 1;
            this.BoxWyszukajPoNr.TextChanged += new System.EventHandler(this.BoxWyszukajPoNr_TextChanged);
            // 
            // BtnSzukajPoNr
            // 
            this.BtnSzukajPoNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSzukajPoNr.Location = new System.Drawing.Point(257, 105);
            this.BtnSzukajPoNr.Name = "BtnSzukajPoNr";
            this.BtnSzukajPoNr.Size = new System.Drawing.Size(264, 37);
            this.BtnSzukajPoNr.TabIndex = 2;
            this.BtnSzukajPoNr.Text = "Szukaj zwierzęcia";
            this.BtnSzukajPoNr.UseVisualStyleBackColor = true;
            this.BtnSzukajPoNr.Click += new System.EventHandler(this.BtnSzukajPoNr_Click);
            // 
            // BoxWyswietlPoNr
            // 
            this.BoxWyswietlPoNr.Location = new System.Drawing.Point(75, 168);
            this.BoxWyswietlPoNr.Multiline = true;
            this.BoxWyswietlPoNr.Name = "BoxWyswietlPoNr";
            this.BoxWyswietlPoNr.Size = new System.Drawing.Size(666, 107);
            this.BoxWyswietlPoNr.TabIndex = 3;
            this.BoxWyswietlPoNr.TextChanged += new System.EventHandler(this.BoxWyswietlPoNr_TextChanged);
            // 
            // FormCase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxWyswietlPoNr);
            this.Controls.Add(this.BtnSzukajPoNr);
            this.Controls.Add(this.BoxWyszukajPoNr);
            this.Controls.Add(this.labelWprowadzNrWyszukiwanie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase2";
            this.Text = "Wyszukaj po numerze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWprowadzNrWyszukiwanie;
        private System.Windows.Forms.TextBox BoxWyszukajPoNr;
        private System.Windows.Forms.Button BtnSzukajPoNr;
        private System.Windows.Forms.TextBox BoxWyswietlPoNr;
    }
}