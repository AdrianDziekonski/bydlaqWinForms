namespace Forms1
{
    partial class FormCase3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase3));
            this.BtnSzukajPoNazwie = new System.Windows.Forms.Button();
            this.BoxWyszukajPoNazwie = new System.Windows.Forms.TextBox();
            this.labelWprowadzNrWyszukiwanie = new System.Windows.Forms.Label();
            this.BoxWyswietlPoNazwie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSzukajPoNazwie
            // 
            this.BtnSzukajPoNazwie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSzukajPoNazwie.Location = new System.Drawing.Point(273, 123);
            this.BtnSzukajPoNazwie.Name = "BtnSzukajPoNazwie";
            this.BtnSzukajPoNazwie.Size = new System.Drawing.Size(264, 37);
            this.BtnSzukajPoNazwie.TabIndex = 6;
            this.BtnSzukajPoNazwie.Text = "Szukaj zwierzęcia";
            this.BtnSzukajPoNazwie.UseVisualStyleBackColor = true;
            this.BtnSzukajPoNazwie.Click += new System.EventHandler(this.BtnSzukajPoNazwie_Click);
            // 
            // BoxWyszukajPoNazwie
            // 
            this.BoxWyszukajPoNazwie.Location = new System.Drawing.Point(426, 84);
            this.BoxWyszukajPoNazwie.Name = "BoxWyszukajPoNazwie";
            this.BoxWyszukajPoNazwie.Size = new System.Drawing.Size(332, 20);
            this.BoxWyszukajPoNazwie.TabIndex = 5;
            this.BoxWyszukajPoNazwie.TextChanged += new System.EventHandler(this.BoxWyszukajPoNazwie_TextChanged);
            // 
            // labelWprowadzNrWyszukiwanie
            // 
            this.labelWprowadzNrWyszukiwanie.AutoSize = true;
            this.labelWprowadzNrWyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzNrWyszukiwanie.Location = new System.Drawing.Point(107, 80);
            this.labelWprowadzNrWyszukiwanie.Name = "labelWprowadzNrWyszukiwanie";
            this.labelWprowadzNrWyszukiwanie.Size = new System.Drawing.Size(253, 24);
            this.labelWprowadzNrWyszukiwanie.TabIndex = 4;
            this.labelWprowadzNrWyszukiwanie.Text = "Wprowadź nazwę zwierzęcia";
            // 
            // BoxWyswietlPoNazwie
            // 
            this.BoxWyswietlPoNazwie.Location = new System.Drawing.Point(79, 179);
            this.BoxWyswietlPoNazwie.Multiline = true;
            this.BoxWyswietlPoNazwie.Name = "BoxWyswietlPoNazwie";
            this.BoxWyswietlPoNazwie.Size = new System.Drawing.Size(666, 60);
            this.BoxWyswietlPoNazwie.TabIndex = 7;
            this.BoxWyswietlPoNazwie.Click += new System.EventHandler(this.BtnSzukajPoNazwie_Click);
            this.BoxWyswietlPoNazwie.TextChanged += new System.EventHandler(this.BoxWyswietlPoNazwie_TextChanged);
            // 
            // FormCase3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxWyswietlPoNazwie);
            this.Controls.Add(this.BtnSzukajPoNazwie);
            this.Controls.Add(this.BoxWyszukajPoNazwie);
            this.Controls.Add(this.labelWprowadzNrWyszukiwanie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase3";
            this.Text = "Wyszukaj po nazwie";
            this.Load += new System.EventHandler(this.FormCase3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSzukajPoNazwie;
        private System.Windows.Forms.TextBox BoxWyszukajPoNazwie;
        private System.Windows.Forms.Label labelWprowadzNrWyszukiwanie;
        private System.Windows.Forms.TextBox BoxWyswietlPoNazwie;
    }
}