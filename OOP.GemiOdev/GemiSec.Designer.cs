namespace OOP.GemiOdev
{
    partial class GemiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGemiAdi = new System.Windows.Forms.ComboBox();
            this.numGemiTon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numGemiTon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gemi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gemi Tonajı:";
            // 
            // cmbGemiAdi
            // 
            this.cmbGemiAdi.FormattingEnabled = true;
            this.cmbGemiAdi.Location = new System.Drawing.Point(123, 26);
            this.cmbGemiAdi.Name = "cmbGemiAdi";
            this.cmbGemiAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbGemiAdi.TabIndex = 2;
            // 
            // numGemiTon
            // 
            this.numGemiTon.Location = new System.Drawing.Point(123, 69);
            this.numGemiTon.Name = "numGemiTon";
            this.numGemiTon.Size = new System.Drawing.Size(120, 20);
            this.numGemiTon.TabIndex = 3;
            // 
            // GemiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 128);
            this.Controls.Add(this.numGemiTon);
            this.Controls.Add(this.cmbGemiAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GemiEkle";
            this.Text = "GemiEkle";
            ((System.ComponentModel.ISupportInitialize)(this.numGemiTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGemiAdi;
        private System.Windows.Forms.NumericUpDown numGemiTon;
    }
}