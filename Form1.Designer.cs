namespace Forms1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCase1 = new System.Windows.Forms.Button();
            this.btnCase2 = new System.Windows.Forms.Button();
            this.btnCase3 = new System.Windows.Forms.Button();
            this.btnCase6 = new System.Windows.Forms.Button();
            this.btnCase5 = new System.Windows.Forms.Button();
            this.btnCase4 = new System.Windows.Forms.Button();
            this.btnCase7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(255, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "BydlaQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aplikacja do zarządzania Twoim stadem bydła";
            // 
            // btnCase1
            // 
            this.btnCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase1.Location = new System.Drawing.Point(19, 129);
            this.btnCase1.Name = "btnCase1";
            this.btnCase1.Size = new System.Drawing.Size(279, 28);
            this.btnCase1.TabIndex = 2;
            this.btnCase1.Text = "Dodaj zwierzę";
            this.btnCase1.UseVisualStyleBackColor = true;
            this.btnCase1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCase2
            // 
            this.btnCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase2.Location = new System.Drawing.Point(19, 179);
            this.btnCase2.Name = "btnCase2";
            this.btnCase2.Size = new System.Drawing.Size(279, 28);
            this.btnCase2.TabIndex = 3;
            this.btnCase2.Text = "Wyświetl zwierzę po numerze identyfikacyjnym";
            this.btnCase2.UseVisualStyleBackColor = true;
            this.btnCase2.Click += new System.EventHandler(this.btnCase2_Click);
            // 
            // btnCase3
            // 
            this.btnCase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase3.Location = new System.Drawing.Point(19, 227);
            this.btnCase3.Name = "btnCase3";
            this.btnCase3.Size = new System.Drawing.Size(279, 28);
            this.btnCase3.TabIndex = 4;
            this.btnCase3.Text = "Wyświetl zwierzę po nazwie";
            this.btnCase3.UseVisualStyleBackColor = true;
            this.btnCase3.Click += new System.EventHandler(this.btnCase3_Click);
            // 
            // btnCase6
            // 
            this.btnCase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase6.Location = new System.Drawing.Point(19, 405);
            this.btnCase6.Name = "btnCase6";
            this.btnCase6.Size = new System.Drawing.Size(279, 28);
            this.btnCase6.TabIndex = 5;
            this.btnCase6.Text = "Usuń zwierzę";
            this.btnCase6.UseVisualStyleBackColor = true;
            this.btnCase6.Click += new System.EventHandler(this.btnCase6_Click);
            // 
            // btnCase5
            // 
            this.btnCase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase5.Location = new System.Drawing.Point(19, 317);
            this.btnCase5.Name = "btnCase5";
            this.btnCase5.Size = new System.Drawing.Size(279, 28);
            this.btnCase5.TabIndex = 6;
            this.btnCase5.Text = "Sprawdź cielność";
            this.btnCase5.UseVisualStyleBackColor = true;
            this.btnCase5.Click += new System.EventHandler(this.btnCase5_Click);
            // 
            // btnCase4
            // 
            this.btnCase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase4.Location = new System.Drawing.Point(19, 272);
            this.btnCase4.Name = "btnCase4";
            this.btnCase4.Size = new System.Drawing.Size(279, 28);
            this.btnCase4.TabIndex = 7;
            this.btnCase4.Text = "Wyświetl wszytskie zwierzęta z listy";
            this.btnCase4.UseVisualStyleBackColor = true;
            this.btnCase4.Click += new System.EventHandler(this.btnCase4_Click);
            // 
            // btnCase7
            // 
            this.btnCase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCase7.Location = new System.Drawing.Point(19, 361);
            this.btnCase7.Name = "btnCase7";
            this.btnCase7.Size = new System.Drawing.Size(279, 28);
            this.btnCase7.TabIndex = 8;
            this.btnCase7.Text = "Pokaż przyszłe wycielenia";
            this.btnCase7.UseVisualStyleBackColor = true;
            this.btnCase7.Click += new System.EventHandler(this.btnCase7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::Forms1.Properties.Resources.listeria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnCase7);
            this.Controls.Add(this.btnCase4);
            this.Controls.Add(this.btnCase5);
            this.Controls.Add(this.btnCase6);
            this.Controls.Add(this.btnCase3);
            this.Controls.Add(this.btnCase2);
            this.Controls.Add(this.btnCase1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BydlaQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCase1;
        private System.Windows.Forms.Button btnCase2;
        private System.Windows.Forms.Button btnCase3;
        private System.Windows.Forms.Button btnCase6;
        private System.Windows.Forms.Button btnCase5;
        private System.Windows.Forms.Button btnCase4;
        private System.Windows.Forms.Button btnCase7;
    }
}

