namespace _9___Classe_frazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.SempBut = new System.Windows.Forms.Button();
            this.DivBut = new System.Windows.Forms.Button();
            this.MoltBut = new System.Windows.Forms.Button();
            this.SottBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.Numer1 = new System.Windows.Forms.TextBox();
            this.Denom1 = new System.Windows.Forms.TextBox();
            this.NumLab1 = new System.Windows.Forms.Label();
            this.DenLab1 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.ListView();
            this.DenLab2 = new System.Windows.Forms.Label();
            this.Denom2 = new System.Windows.Forms.TextBox();
            this.Numer2 = new System.Windows.Forms.TextBox();
            this.FrazLab1 = new System.Windows.Forms.Label();
            this.FrazLab2 = new System.Windows.Forms.Label();
            this.OperFondBut = new System.Windows.Forms.CheckBox();
            this.NumLab2 = new System.Windows.Forms.Label();
            this.FrazDecBut = new System.Windows.Forms.Button();
            this.DecFrazBut = new System.Windows.Forms.Button();
            this.PotBut = new System.Windows.Forms.Button();
            this.ValDecLab = new System.Windows.Forms.Label();
            this.ValDec = new System.Windows.Forms.TextBox();
            this.AltreFunBut = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SempBut
            // 
            this.SempBut.Enabled = false;
            this.SempBut.Location = new System.Drawing.Point(40, 523);
            this.SempBut.Name = "SempBut";
            this.SempBut.Size = new System.Drawing.Size(169, 50);
            this.SempBut.TabIndex = 0;
            this.SempBut.Text = "Semplifica";
            this.SempBut.UseVisualStyleBackColor = true;
            this.SempBut.Click += new System.EventHandler(this.SempBut_Click);
            // 
            // DivBut
            // 
            this.DivBut.Location = new System.Drawing.Point(252, 399);
            this.DivBut.Name = "DivBut";
            this.DivBut.Size = new System.Drawing.Size(163, 50);
            this.DivBut.TabIndex = 2;
            this.DivBut.Text = "Divisione";
            this.DivBut.UseVisualStyleBackColor = true;
            this.DivBut.Click += new System.EventHandler(this.DivBut_Click);
            // 
            // MoltBut
            // 
            this.MoltBut.Location = new System.Drawing.Point(40, 399);
            this.MoltBut.Name = "MoltBut";
            this.MoltBut.Size = new System.Drawing.Size(169, 50);
            this.MoltBut.TabIndex = 3;
            this.MoltBut.Text = "Moltiplicazione";
            this.MoltBut.UseVisualStyleBackColor = true;
            this.MoltBut.Click += new System.EventHandler(this.MoltBut_Click);
            // 
            // SottBut
            // 
            this.SottBut.Location = new System.Drawing.Point(252, 328);
            this.SottBut.Name = "SottBut";
            this.SottBut.Size = new System.Drawing.Size(163, 50);
            this.SottBut.TabIndex = 4;
            this.SottBut.Text = "Sottrazione";
            this.SottBut.UseVisualStyleBackColor = true;
            this.SottBut.Click += new System.EventHandler(this.SottBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(40, 328);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(169, 50);
            this.AddBut.TabIndex = 5;
            this.AddBut.Text = "Addizione";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // Numer1
            // 
            this.Numer1.Location = new System.Drawing.Point(102, 62);
            this.Numer1.Name = "Numer1";
            this.Numer1.Size = new System.Drawing.Size(100, 22);
            this.Numer1.TabIndex = 6;
            // 
            // Denom1
            // 
            this.Denom1.Location = new System.Drawing.Point(260, 62);
            this.Denom1.Name = "Denom1";
            this.Denom1.Size = new System.Drawing.Size(100, 22);
            this.Denom1.TabIndex = 7;
            // 
            // NumLab1
            // 
            this.NumLab1.AutoSize = true;
            this.NumLab1.Location = new System.Drawing.Point(113, 40);
            this.NumLab1.Name = "NumLab1";
            this.NumLab1.Size = new System.Drawing.Size(78, 16);
            this.NumLab1.TabIndex = 8;
            this.NumLab1.Text = "Numeratore";
            // 
            // DenLab1
            // 
            this.DenLab1.AutoSize = true;
            this.DenLab1.Location = new System.Drawing.Point(263, 40);
            this.DenLab1.Name = "DenLab1";
            this.DenLab1.Size = new System.Drawing.Size(92, 16);
            this.DenLab1.TabIndex = 9;
            this.DenLab1.Text = "Denominatore";
            // 
            // Display
            // 
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(459, 8);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(707, 714);
            this.Display.TabIndex = 10;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.List;
            // 
            // DenLab2
            // 
            this.DenLab2.AutoSize = true;
            this.DenLab2.Location = new System.Drawing.Point(263, 127);
            this.DenLab2.Name = "DenLab2";
            this.DenLab2.Size = new System.Drawing.Size(92, 16);
            this.DenLab2.TabIndex = 14;
            this.DenLab2.Text = "Denominatore";
            // 
            // Denom2
            // 
            this.Denom2.Location = new System.Drawing.Point(260, 149);
            this.Denom2.Name = "Denom2";
            this.Denom2.Size = new System.Drawing.Size(100, 22);
            this.Denom2.TabIndex = 12;
            // 
            // Numer2
            // 
            this.Numer2.Location = new System.Drawing.Point(102, 149);
            this.Numer2.Name = "Numer2";
            this.Numer2.Size = new System.Drawing.Size(100, 22);
            this.Numer2.TabIndex = 11;
            // 
            // FrazLab1
            // 
            this.FrazLab1.AutoSize = true;
            this.FrazLab1.Location = new System.Drawing.Point(192, 9);
            this.FrazLab1.Name = "FrazLab1";
            this.FrazLab1.Size = new System.Drawing.Size(69, 16);
            this.FrazLab1.TabIndex = 15;
            this.FrazLab1.Text = "Frazione 1";
            // 
            // FrazLab2
            // 
            this.FrazLab2.AutoSize = true;
            this.FrazLab2.Location = new System.Drawing.Point(192, 111);
            this.FrazLab2.Name = "FrazLab2";
            this.FrazLab2.Size = new System.Drawing.Size(69, 16);
            this.FrazLab2.TabIndex = 16;
            this.FrazLab2.Text = "Frazione 2";
            // 
            // OperFondBut
            // 
            this.OperFondBut.AutoSize = true;
            this.OperFondBut.Checked = true;
            this.OperFondBut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OperFondBut.Location = new System.Drawing.Point(139, 279);
            this.OperFondBut.Name = "OperFondBut";
            this.OperFondBut.Size = new System.Drawing.Size(179, 20);
            this.OperFondBut.TabIndex = 18;
            this.OperFondBut.Text = "Operazioni Fondamentali";
            this.OperFondBut.UseVisualStyleBackColor = true;
            this.OperFondBut.CheckedChanged += new System.EventHandler(this.OperFondBut_CheckedChanged);
            // 
            // NumLab2
            // 
            this.NumLab2.AutoSize = true;
            this.NumLab2.Location = new System.Drawing.Point(113, 130);
            this.NumLab2.Name = "NumLab2";
            this.NumLab2.Size = new System.Drawing.Size(78, 16);
            this.NumLab2.TabIndex = 19;
            this.NumLab2.Text = "Numeratore";
            // 
            // FrazDecBut
            // 
            this.FrazDecBut.Enabled = false;
            this.FrazDecBut.Location = new System.Drawing.Point(40, 598);
            this.FrazDecBut.Name = "FrazDecBut";
            this.FrazDecBut.Size = new System.Drawing.Size(169, 50);
            this.FrazDecBut.TabIndex = 20;
            this.FrazDecBut.Text = "Frazione => Decimale";
            this.FrazDecBut.UseVisualStyleBackColor = true;
            this.FrazDecBut.Click += new System.EventHandler(this.FrazDecBut_Click);
            // 
            // DecFrazBut
            // 
            this.DecFrazBut.Enabled = false;
            this.DecFrazBut.Location = new System.Drawing.Point(252, 598);
            this.DecFrazBut.Name = "DecFrazBut";
            this.DecFrazBut.Size = new System.Drawing.Size(163, 50);
            this.DecFrazBut.TabIndex = 21;
            this.DecFrazBut.Text = "Decimale => Frazione";
            this.DecFrazBut.UseVisualStyleBackColor = true;
            this.DecFrazBut.Click += new System.EventHandler(this.DecFrazBut_Click);
            // 
            // PotBut
            // 
            this.PotBut.Enabled = false;
            this.PotBut.Location = new System.Drawing.Point(252, 523);
            this.PotBut.Name = "PotBut";
            this.PotBut.Size = new System.Drawing.Size(163, 50);
            this.PotBut.TabIndex = 22;
            this.PotBut.Text = "Potenza";
            this.PotBut.UseVisualStyleBackColor = true;
            this.PotBut.Click += new System.EventHandler(this.PotBut_Click);
            // 
            // ValDecLab
            // 
            this.ValDecLab.AutoSize = true;
            this.ValDecLab.Location = new System.Drawing.Point(175, 207);
            this.ValDecLab.Name = "ValDecLab";
            this.ValDecLab.Size = new System.Drawing.Size(108, 16);
            this.ValDecLab.TabIndex = 23;
            this.ValDecLab.Text = "Valore Decimale";
            // 
            // ValDec
            // 
            this.ValDec.Enabled = false;
            this.ValDec.Location = new System.Drawing.Point(178, 226);
            this.ValDec.Name = "ValDec";
            this.ValDec.Size = new System.Drawing.Size(100, 22);
            this.ValDec.TabIndex = 24;
            // 
            // AltreFunBut
            // 
            this.AltreFunBut.AutoSize = true;
            this.AltreFunBut.Location = new System.Drawing.Point(175, 475);
            this.AltreFunBut.Name = "AltreFunBut";
            this.AltreFunBut.Size = new System.Drawing.Size(108, 20);
            this.AltreFunBut.TabIndex = 25;
            this.AltreFunBut.Text = "Altre Funzioni";
            this.AltreFunBut.UseVisualStyleBackColor = true;
            this.AltreFunBut.CheckedChanged += new System.EventHandler(this.AltreFunBut_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 731);
            this.Controls.Add(this.AltreFunBut);
            this.Controls.Add(this.ValDec);
            this.Controls.Add(this.ValDecLab);
            this.Controls.Add(this.PotBut);
            this.Controls.Add(this.DecFrazBut);
            this.Controls.Add(this.FrazDecBut);
            this.Controls.Add(this.NumLab2);
            this.Controls.Add(this.OperFondBut);
            this.Controls.Add(this.FrazLab2);
            this.Controls.Add(this.FrazLab1);
            this.Controls.Add(this.DenLab2);
            this.Controls.Add(this.Denom2);
            this.Controls.Add(this.Numer2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.DenLab1);
            this.Controls.Add(this.NumLab1);
            this.Controls.Add(this.Denom1);
            this.Controls.Add(this.Numer1);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.SottBut);
            this.Controls.Add(this.MoltBut);
            this.Controls.Add(this.DivBut);
            this.Controls.Add(this.SempBut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SempBut;
        private System.Windows.Forms.Button DivBut;
        private System.Windows.Forms.Button MoltBut;
        private System.Windows.Forms.Button SottBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.TextBox Numer1;
        private System.Windows.Forms.TextBox Denom1;
        private System.Windows.Forms.Label NumLab1;
        private System.Windows.Forms.Label DenLab1;
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.Label DenLab2;
        private System.Windows.Forms.TextBox Denom2;
        private System.Windows.Forms.TextBox Numer2;
        private System.Windows.Forms.Label FrazLab1;
        private System.Windows.Forms.Label FrazLab2;
        private System.Windows.Forms.CheckBox OperFondBut;
        private System.Windows.Forms.Label NumLab2;
        private System.Windows.Forms.Button FrazDecBut;
        private System.Windows.Forms.Button DecFrazBut;
        private System.Windows.Forms.Button PotBut;
        private System.Windows.Forms.Label ValDecLab;
        private System.Windows.Forms.TextBox ValDec;
        private System.Windows.Forms.CheckBox AltreFunBut;
    }
}

