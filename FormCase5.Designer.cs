namespace Forms1
{
    partial class FormCase5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase5));
            this.BoxWyswietlCzyCielna = new System.Windows.Forms.TextBox();
            this.BtnSprawdzCielnosc = new System.Windows.Forms.Button();
            this.BoxSprawdzCielnoscPoNazwie = new System.Windows.Forms.TextBox();
            this.labelWprowadzNrWyszukiwanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxWyswietlCzyCielna
            // 
            this.BoxWyswietlCzyCielna.Location = new System.Drawing.Point(86, 133);
            this.BoxWyswietlCzyCielna.Multiline = true;
            this.BoxWyswietlCzyCielna.Name = "BoxWyswietlCzyCielna";
            this.BoxWyswietlCzyCielna.Size = new System.Drawing.Size(666, 107);
            this.BoxWyswietlCzyCielna.TabIndex = 7;
            // 
            // BtnSprawdzCielnosc
            // 
            this.BtnSprawdzCielnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSprawdzCielnosc.Location = new System.Drawing.Point(268, 70);
            this.BtnSprawdzCielnosc.Name = "BtnSprawdzCielnosc";
            this.BtnSprawdzCielnosc.Size = new System.Drawing.Size(264, 37);
            this.BtnSprawdzCielnosc.TabIndex = 6;
            this.BtnSprawdzCielnosc.Text = "Sprawdź cielność";
            this.BtnSprawdzCielnosc.UseVisualStyleBackColor = true;
            // 
            // BoxSprawdzCielnoscPoNazwie
            // 
            this.BoxSprawdzCielnoscPoNazwie.Location = new System.Drawing.Point(421, 31);
            this.BoxSprawdzCielnoscPoNazwie.Name = "BoxSprawdzCielnoscPoNazwie";
            this.BoxSprawdzCielnoscPoNazwie.Size = new System.Drawing.Size(332, 20);
            this.BoxSprawdzCielnoscPoNazwie.TabIndex = 5;
            // 
            // labelWprowadzNrWyszukiwanie
            // 
            this.labelWprowadzNrWyszukiwanie.AutoSize = true;
            this.labelWprowadzNrWyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzNrWyszukiwanie.Location = new System.Drawing.Point(96, 27);
            this.labelWprowadzNrWyszukiwanie.Name = "labelWprowadzNrWyszukiwanie";
            this.labelWprowadzNrWyszukiwanie.Size = new System.Drawing.Size(253, 24);
            this.labelWprowadzNrWyszukiwanie.TabIndex = 4;
            this.labelWprowadzNrWyszukiwanie.Text = "Wprowadź nazwę zwierzęcia";
            // 
            // FormCase5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxWyswietlCzyCielna);
            this.Controls.Add(this.BtnSprawdzCielnosc);
            this.Controls.Add(this.BoxSprawdzCielnoscPoNazwie);
            this.Controls.Add(this.labelWprowadzNrWyszukiwanie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase5";
            this.Text = "Sprawdź cielność";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxWyswietlCzyCielna;
        private System.Windows.Forms.Button BtnSprawdzCielnosc;
        private System.Windows.Forms.TextBox BoxSprawdzCielnoscPoNazwie;
        private System.Windows.Forms.Label labelWprowadzNrWyszukiwanie;
    }
}