namespace bubblegum
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.txtBoxAccuracy = new System.Windows.Forms.TextBox();
            this.lblAccu = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtBoxColour = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColourName = new System.Windows.Forms.Label();
            this.txtBoxClrName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCommit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(13, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(516, 290);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(535, 13);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(67, 13);
            this.lblAccuracy.TabIndex = 1;
            this.lblAccuracy.Text = "Genauigkeit:";
            // 
            // txtBoxAccuracy
            // 
            this.txtBoxAccuracy.Location = new System.Drawing.Point(618, 13);
            this.txtBoxAccuracy.Name = "txtBoxAccuracy";
            this.txtBoxAccuracy.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccuracy.TabIndex = 2;
            // 
            // lblAccu
            // 
            this.lblAccu.AutoSize = true;
            this.lblAccu.Location = new System.Drawing.Point(724, 16);
            this.lblAccu.Name = "lblAccu";
            this.lblAccu.Size = new System.Drawing.Size(0, 13);
            this.lblAccu.TabIndex = 3;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(535, 39);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 4;
            this.lblColour.Text = "Farbe:";
            // 
            // txtBoxColour
            // 
            this.txtBoxColour.Location = new System.Drawing.Point(618, 39);
            this.txtBoxColour.Name = "txtBoxColour";
            this.txtBoxColour.ReadOnly = true;
            this.txtBoxColour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxColour.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(734, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 20);
            this.panel1.TabIndex = 6;
            // 
            // lblColourName
            // 
            this.lblColourName.AutoSize = true;
            this.lblColourName.Location = new System.Drawing.Point(535, 65);
            this.lblColourName.Name = "lblColourName";
            this.lblColourName.Size = new System.Drawing.Size(57, 13);
            this.lblColourName.TabIndex = 8;
            this.lblColourName.Text = "Farbname:";
            // 
            // txtBoxClrName
            // 
            this.txtBoxClrName.Location = new System.Drawing.Point(618, 65);
            this.txtBoxClrName.Name = "txtBoxClrName";
            this.txtBoxClrName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxClrName.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(777, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(551, 280);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(97, 23);
            this.btnCommit.TabIndex = 11;
            this.btnCommit.Text = "Übernehmen";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBoxClrName);
            this.Controls.Add(this.lblColourName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxColour);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblAccu);
            this.Controls.Add(this.txtBoxAccuracy);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Farbe hinzufügen";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.TextBox txtBoxAccuracy;
        private System.Windows.Forms.Label lblAccu;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtBoxColour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblColourName;
        private System.Windows.Forms.TextBox txtBoxClrName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button button1;
    }
}

