namespace Forms1
{
    partial class FormCase7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCase7));
            this.BoxWyswietlPrzyszleWycielenia = new System.Windows.Forms.TextBox();
            this.BtnPokazPrzyszleWycielenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxWyswietlPrzyszleWycielenia
            // 
            this.BoxWyswietlPrzyszleWycielenia.Location = new System.Drawing.Point(65, 111);
            this.BoxWyswietlPrzyszleWycielenia.Multiline = true;
            this.BoxWyswietlPrzyszleWycielenia.Name = "BoxWyswietlPrzyszleWycielenia";
            this.BoxWyswietlPrzyszleWycielenia.Size = new System.Drawing.Size(666, 107);
            this.BoxWyswietlPrzyszleWycielenia.TabIndex = 9;
            this.BoxWyswietlPrzyszleWycielenia.TextChanged += new System.EventHandler(this.BoxWyswietlPrzyszleWycielenia_TextChanged);
            // 
            // BtnPokazPrzyszleWycielenia
            // 
            this.BtnPokazPrzyszleWycielenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPokazPrzyszleWycielenia.Location = new System.Drawing.Point(252, 27);
            this.BtnPokazPrzyszleWycielenia.Name = "BtnPokazPrzyszleWycielenia";
            this.BtnPokazPrzyszleWycielenia.Size = new System.Drawing.Size(264, 57);
            this.BtnPokazPrzyszleWycielenia.TabIndex = 8;
            this.BtnPokazPrzyszleWycielenia.Text = "Pokaż wycielenia w ciągu  najbliższych 30 dni";
            this.BtnPokazPrzyszleWycielenia.UseVisualStyleBackColor = true;
            // 
            // FormCase7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxWyswietlPrzyszleWycielenia);
            this.Controls.Add(this.BtnPokazPrzyszleWycielenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCase7";
            this.Text = "Pokaż przyszłe wycielenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxWyswietlPrzyszleWycielenia;
        private System.Windows.Forms.Button BtnPokazPrzyszleWycielenia;
    }
}