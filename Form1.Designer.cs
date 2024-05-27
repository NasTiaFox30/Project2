namespace Projekt_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnEUR3 = new System.Windows.Forms.RadioButton();
            this.radioBtnUSD2 = new System.Windows.Forms.RadioButton();
            this.radioBtnAB4 = new System.Windows.Forms.RadioButton();
            this.radioBtnPLN1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnAB8 = new System.Windows.Forms.RadioButton();
            this.radioBtnPLN7 = new System.Windows.Forms.RadioButton();
            this.radioBtnEUR6 = new System.Windows.Forms.RadioButton();
            this.radioBtnUSD5 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelWalutaŹród = new System.Windows.Forms.Label();
            this.labelWalutaDocel = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.labelZnak1 = new System.Windows.Forms.Label();
            this.labelZnak2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioBtnEUR3);
            this.groupBox1.Controls.Add(this.radioBtnUSD2);
            this.groupBox1.Controls.Add(this.radioBtnAB4);
            this.groupBox1.Controls.Add(this.radioBtnPLN1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waluta źródłowa";
            // 
            // radioBtnEUR3
            // 
            this.radioBtnEUR3.AutoSize = true;
            this.radioBtnEUR3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEUR3.Location = new System.Drawing.Point(19, 82);
            this.radioBtnEUR3.Name = "radioBtnEUR3";
            this.radioBtnEUR3.Size = new System.Drawing.Size(61, 21);
            this.radioBtnEUR3.TabIndex = 2;
            this.radioBtnEUR3.Text = "EUR";
            this.radioBtnEUR3.UseVisualStyleBackColor = true;
            this.radioBtnEUR3.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnUSD2
            // 
            this.radioBtnUSD2.AutoSize = true;
            this.radioBtnUSD2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUSD2.Location = new System.Drawing.Point(19, 56);
            this.radioBtnUSD2.Name = "radioBtnUSD2";
            this.radioBtnUSD2.Size = new System.Drawing.Size(61, 21);
            this.radioBtnUSD2.TabIndex = 1;
            this.radioBtnUSD2.Text = "USD";
            this.radioBtnUSD2.UseVisualStyleBackColor = true;
            this.radioBtnUSD2.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnAB4
            // 
            this.radioBtnAB4.AutoSize = true;
            this.radioBtnAB4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAB4.Location = new System.Drawing.Point(19, 108);
            this.radioBtnAB4.Name = "radioBtnAB4";
            this.radioBtnAB4.Size = new System.Drawing.Size(51, 21);
            this.radioBtnAB4.TabIndex = 3;
            this.radioBtnAB4.Text = "AB";
            this.radioBtnAB4.UseVisualStyleBackColor = true;
            this.radioBtnAB4.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnPLN1
            // 
            this.radioBtnPLN1.AutoSize = true;
            this.radioBtnPLN1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPLN1.Location = new System.Drawing.Point(19, 30);
            this.radioBtnPLN1.Name = "radioBtnPLN1";
            this.radioBtnPLN1.Size = new System.Drawing.Size(59, 21);
            this.radioBtnPLN1.TabIndex = 0;
            this.radioBtnPLN1.Text = "PLN";
            this.radioBtnPLN1.UseVisualStyleBackColor = true;
            this.radioBtnPLN1.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioBtnAB8);
            this.groupBox2.Controls.Add(this.radioBtnPLN7);
            this.groupBox2.Controls.Add(this.radioBtnEUR6);
            this.groupBox2.Controls.Add(this.radioBtnUSD5);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(361, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waluta docelowa";
            // 
            // radioBtnAB8
            // 
            this.radioBtnAB8.AutoSize = true;
            this.radioBtnAB8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAB8.Location = new System.Drawing.Point(15, 108);
            this.radioBtnAB8.Name = "radioBtnAB8";
            this.radioBtnAB8.Size = new System.Drawing.Size(51, 21);
            this.radioBtnAB8.TabIndex = 7;
            this.radioBtnAB8.Text = "AB";
            this.radioBtnAB8.UseVisualStyleBackColor = true;
            this.radioBtnAB8.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnPLN7
            // 
            this.radioBtnPLN7.AutoSize = true;
            this.radioBtnPLN7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPLN7.Location = new System.Drawing.Point(15, 82);
            this.radioBtnPLN7.Name = "radioBtnPLN7";
            this.radioBtnPLN7.Size = new System.Drawing.Size(59, 21);
            this.radioBtnPLN7.TabIndex = 6;
            this.radioBtnPLN7.Text = "PLN";
            this.radioBtnPLN7.UseVisualStyleBackColor = true;
            this.radioBtnPLN7.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnEUR6
            // 
            this.radioBtnEUR6.AutoSize = true;
            this.radioBtnEUR6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEUR6.Location = new System.Drawing.Point(15, 56);
            this.radioBtnEUR6.Name = "radioBtnEUR6";
            this.radioBtnEUR6.Size = new System.Drawing.Size(61, 21);
            this.radioBtnEUR6.TabIndex = 5;
            this.radioBtnEUR6.Text = "EUR";
            this.radioBtnEUR6.UseVisualStyleBackColor = true;
            this.radioBtnEUR6.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // radioBtnUSD5
            // 
            this.radioBtnUSD5.AutoSize = true;
            this.radioBtnUSD5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUSD5.Location = new System.Drawing.Point(15, 30);
            this.radioBtnUSD5.Name = "radioBtnUSD5";
            this.radioBtnUSD5.Size = new System.Drawing.Size(61, 21);
            this.radioBtnUSD5.TabIndex = 4;
            this.radioBtnUSD5.Text = "USD";
            this.radioBtnUSD5.UseVisualStyleBackColor = true;
            this.radioBtnUSD5.CheckedChanged += new System.EventHandler(this.radioBtnPLN1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(96, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Location = new System.Drawing.Point(96, 136);
            this.textBox2.MinimumSize = new System.Drawing.Size(465, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(465, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWalutaŹród
            // 
            this.labelWalutaŹród.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWalutaŹród.AutoSize = true;
            this.labelWalutaŹród.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWalutaŹród.Location = new System.Drawing.Point(38, 103);
            this.labelWalutaŹród.Name = "labelWalutaŹród";
            this.labelWalutaŹród.Size = new System.Drawing.Size(18, 22);
            this.labelWalutaŹród.TabIndex = 4;
            this.labelWalutaŹród.Text = "-";
            // 
            // labelWalutaDocel
            // 
            this.labelWalutaDocel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWalutaDocel.AutoSize = true;
            this.labelWalutaDocel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWalutaDocel.Location = new System.Drawing.Point(38, 142);
            this.labelWalutaDocel.Name = "labelWalutaDocel";
            this.labelWalutaDocel.Size = new System.Drawing.Size(18, 22);
            this.labelWalutaDocel.TabIndex = 5;
            this.labelWalutaDocel.Text = "-";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(31, 371);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(529, 29);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.BackColor = System.Drawing.Color.AliceBlue;
            this.labelNazwa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazwa.Location = new System.Drawing.Point(174, 35);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(253, 34);
            this.labelNazwa.TabIndex = 7;
            this.labelNazwa.Text = "Kalkulator walut";
            // 
            // labelZnak1
            // 
            this.labelZnak1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelZnak1.AutoSize = true;
            this.labelZnak1.Location = new System.Drawing.Point(567, 101);
            this.labelZnak1.Name = "labelZnak1";
            this.labelZnak1.Size = new System.Drawing.Size(10, 16);
            this.labelZnak1.TabIndex = 8;
            this.labelZnak1.Text = ".";
            // 
            // labelZnak2
            // 
            this.labelZnak2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelZnak2.AutoSize = true;
            this.labelZnak2.Location = new System.Drawing.Point(567, 142);
            this.labelZnak2.Name = "labelZnak2";
            this.labelZnak2.Size = new System.Drawing.Size(10, 16);
            this.labelZnak2.TabIndex = 9;
            this.labelZnak2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 428);
            this.Controls.Add(this.labelZnak2);
            this.Controls.Add(this.labelZnak1);
            this.Controls.Add(this.labelNazwa);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.labelWalutaDocel);
            this.Controls.Add(this.labelWalutaŹród);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(610, 475);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator walut";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelWalutaŹród;
        private System.Windows.Forms.Label labelWalutaDocel;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.RadioButton radioBtnEUR3;
        private System.Windows.Forms.RadioButton radioBtnUSD2;
        private System.Windows.Forms.RadioButton radioBtnPLN1;
        private System.Windows.Forms.RadioButton radioBtnEUR6;
        private System.Windows.Forms.RadioButton radioBtnUSD5;
        private System.Windows.Forms.RadioButton radioBtnAB4;
        private System.Windows.Forms.RadioButton radioBtnAB8;
        private System.Windows.Forms.RadioButton radioBtnPLN7;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.Label labelZnak1;
        private System.Windows.Forms.Label labelZnak2;
    }
}

