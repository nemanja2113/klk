namespace tim2
{
    partial class Dodavanje
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
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbPozicija = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(351, 75);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(148, 22);
            this.txbIme.TabIndex = 0;
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(351, 119);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(148, 22);
            this.txbPrezime.TabIndex = 1;
            // 
            // txbPozicija
            // 
            this.txbPozicija.Location = new System.Drawing.Point(351, 163);
            this.txbPozicija.Name = "txbPozicija";
            this.txbPozicija.Size = new System.Drawing.Size(148, 22);
            this.txbPozicija.TabIndex = 2;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(366, 226);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(133, 45);
            this.btnPotvrdi.TabIndex = 3;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(366, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pozicija";
            // 
            // Dodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txbPozicija);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Name = "Dodavanje";
            this.Text = "Dodavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbPozicija;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}