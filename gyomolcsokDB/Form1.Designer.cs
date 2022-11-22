namespace gyomolcsokDB
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
            this.listBox_Gyomolcsok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_azonosito = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_egysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.newFruite = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.torlse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Gyomolcsok
            // 
            this.listBox_Gyomolcsok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_Gyomolcsok.FormattingEnabled = true;
            this.listBox_Gyomolcsok.Location = new System.Drawing.Point(537, 0);
            this.listBox_Gyomolcsok.Name = "listBox_Gyomolcsok";
            this.listBox_Gyomolcsok.Size = new System.Drawing.Size(263, 450);
            this.listBox_Gyomolcsok.TabIndex = 0;
            this.listBox_Gyomolcsok.SelectedIndexChanged += new System.EventHandler(this.listBox_Gyomolcsok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.torlse);
            this.groupBox1.Controls.Add(this.modositas);
            this.groupBox1.Controls.Add(this.newFruite);
            this.groupBox1.Controls.Add(this.numericUpDown_mennyiseg);
            this.groupBox1.Controls.Add(this.numericUpDown_egysegar);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.textBox_azonosito);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresett gyömölcsök";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonositó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egység ár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség";
            // 
            // textBox_azonosito
            // 
            this.textBox_azonosito.Location = new System.Drawing.Point(176, 44);
            this.textBox_azonosito.Name = "textBox_azonosito";
            this.textBox_azonosito.ReadOnly = true;
            this.textBox_azonosito.Size = new System.Drawing.Size(154, 20);
            this.textBox_azonosito.TabIndex = 4;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(176, 89);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(154, 20);
            this.textBox_nev.TabIndex = 5;
            // 
            // numericUpDown_egysegar
            // 
            this.numericUpDown_egysegar.Location = new System.Drawing.Point(176, 129);
            this.numericUpDown_egysegar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_egysegar.Name = "numericUpDown_egysegar";
            this.numericUpDown_egysegar.Size = new System.Drawing.Size(154, 20);
            this.numericUpDown_egysegar.TabIndex = 6;
            this.numericUpDown_egysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(176, 176);
            this.numericUpDown_mennyiseg.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(154, 20);
            this.numericUpDown_mennyiseg.TabIndex = 7;
            this.numericUpDown_mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newFruite
            // 
            this.newFruite.Location = new System.Drawing.Point(119, 232);
            this.newFruite.Name = "newFruite";
            this.newFruite.Size = new System.Drawing.Size(181, 40);
            this.newFruite.TabIndex = 8;
            this.newFruite.Text = "Új gyümölcs";
            this.newFruite.UseVisualStyleBackColor = true;
            this.newFruite.Click += new System.EventHandler(this.newFruite_Click);
            // 
            // modositas
            // 
            this.modositas.Location = new System.Drawing.Point(119, 290);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(181, 40);
            this.modositas.TabIndex = 9;
            this.modositas.Text = "Módosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // torlse
            // 
            this.torlse.Location = new System.Drawing.Point(119, 349);
            this.torlse.Name = "torlse";
            this.torlse.Size = new System.Drawing.Size(181, 40);
            this.torlse.TabIndex = 10;
            this.torlse.Text = "Törlés";
            this.torlse.UseVisualStyleBackColor = true;
            this.torlse.Click += new System.EventHandler(this.torlse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Gyomolcsok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Gyomolcsok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown_egysegar;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_azonosito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button torlse;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button newFruite;
    }
}

