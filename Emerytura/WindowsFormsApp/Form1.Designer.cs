namespace WindowsFormsApp
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
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(123, 23);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(158, 20);
            this.textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(123, 65);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(158, 20);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(123, 112);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(158, 20);
            this.textBoxWiek.TabIndex = 2;
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.BackColor = System.Drawing.SystemColors.Control;
            this.Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Imie.Location = new System.Drawing.Point(57, 22);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(44, 18);
            this.Imie.TabIndex = 3;
            this.Imie.Text = "Imię:";
            this.Imie.Click += new System.EventHandler(this.Imie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wiek:";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOblicz.Location = new System.Drawing.Point(69, 176);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(184, 39);
            this.buttonOblicz.TabIndex = 6;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWynik.Location = new System.Drawing.Point(25, 265);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(311, 24);
            this.labelWynik.TabIndex = 7;
            this.labelWynik.Text = "Wpisz Dane aby zobaczyć wynik";
            this.labelWynik.Click += new System.EventHandler(this.labelWynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Name = "Form1";
            this.Text = "Obliczanie emerytury";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Label labelWynik;
    }
}

