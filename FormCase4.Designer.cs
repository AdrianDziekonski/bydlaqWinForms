namespace Forms1
{
    partial class FormCase4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase4));
            this.BoxWyswietlWszytskieZwierzeta = new System.Windows.Forms.TextBox();
            this.BtnWywietlWszytskie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxWyswietlWszytskieZwierzeta
            // 
            this.BoxWyswietlWszytskieZwierzeta.Location = new System.Drawing.Point(23, 40);
            this.BoxWyswietlWszytskieZwierzeta.Multiline = true;
            this.BoxWyswietlWszytskieZwierzeta.Name = "BoxWyswietlWszytskieZwierzeta";
            this.BoxWyswietlWszytskieZwierzeta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BoxWyswietlWszytskieZwierzeta.Size = new System.Drawing.Size(742, 364);
            this.BoxWyswietlWszytskieZwierzeta.TabIndex = 0;
            this.BoxWyswietlWszytskieZwierzeta.TextChanged += new System.EventHandler(this.BoxWyswietlWszytskieZwierzeta_TextChanged);
            // 
            // BtnWywietlWszytskie
            // 
            this.BtnWywietlWszytskie.Location = new System.Drawing.Point(238, 11);
            this.BtnWywietlWszytskie.Name = "BtnWywietlWszytskie";
            this.BtnWywietlWszytskie.Size = new System.Drawing.Size(284, 23);
            this.BtnWywietlWszytskie.TabIndex = 1;
            this.BtnWywietlWszytskie.Text = "Wyswietl wszystkie zwierzęta";
            this.BtnWywietlWszytskie.UseVisualStyleBackColor = true;
            this.BtnWywietlWszytskie.Click += new System.EventHandler(this.BtnWywietlWszytskie_Click);
            // 
            // FormCase4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWywietlWszytskie);
            this.Controls.Add(this.BoxWyswietlWszytskieZwierzeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase4";
            this.Text = "Wyświetl wszystkie zwierzęta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxWyswietlWszytskieZwierzeta;
        private System.Windows.Forms.Button BtnWywietlWszytskie;
    }
}