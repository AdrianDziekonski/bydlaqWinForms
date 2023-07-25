namespace Forms1
{
    partial class FormCase6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase6));
            this.BtnUsunZwierze = new System.Windows.Forms.Button();
            this.BoxUsunZwierzePoNazwie = new System.Windows.Forms.TextBox();
            this.labelWprowadzNrWyszukiwanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUsunZwierze
            // 
            this.BtnUsunZwierze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUsunZwierze.Location = new System.Drawing.Point(244, 79);
            this.BtnUsunZwierze.Name = "BtnUsunZwierze";
            this.BtnUsunZwierze.Size = new System.Drawing.Size(264, 37);
            this.BtnUsunZwierze.TabIndex = 9;
            this.BtnUsunZwierze.Text = "Usuń zwierzę";
            this.BtnUsunZwierze.UseVisualStyleBackColor = true;
            this.BtnUsunZwierze.Click += new System.EventHandler(this.BtnUsunZwierze_Click);
            // 
            // BoxUsunZwierzePoNazwie
            // 
            this.BoxUsunZwierzePoNazwie.Location = new System.Drawing.Point(397, 40);
            this.BoxUsunZwierzePoNazwie.Name = "BoxUsunZwierzePoNazwie";
            this.BoxUsunZwierzePoNazwie.Size = new System.Drawing.Size(332, 20);
            this.BoxUsunZwierzePoNazwie.TabIndex = 8;
            this.BoxUsunZwierzePoNazwie.TextChanged += new System.EventHandler(this.BoxUsunZwierzePoNazwie_TextChanged);
            // 
            // labelWprowadzNrWyszukiwanie
            // 
            this.labelWprowadzNrWyszukiwanie.AutoSize = true;
            this.labelWprowadzNrWyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWprowadzNrWyszukiwanie.Location = new System.Drawing.Point(72, 36);
            this.labelWprowadzNrWyszukiwanie.Name = "labelWprowadzNrWyszukiwanie";
            this.labelWprowadzNrWyszukiwanie.Size = new System.Drawing.Size(253, 24);
            this.labelWprowadzNrWyszukiwanie.TabIndex = 7;
            this.labelWprowadzNrWyszukiwanie.Text = "Wprowadź nazwę zwierzęcia";
            // 
            // FormCase6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUsunZwierze);
            this.Controls.Add(this.BoxUsunZwierzePoNazwie);
            this.Controls.Add(this.labelWprowadzNrWyszukiwanie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase6";
            this.Text = "Usuń zwierzę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUsunZwierze;
        private System.Windows.Forms.TextBox BoxUsunZwierzePoNazwie;
        private System.Windows.Forms.Label labelWprowadzNrWyszukiwanie;
    }
}