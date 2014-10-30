namespace bubblegum_sequencer
{
    partial class ColorInsert
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
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lblReadingcount = new System.Windows.Forms.Label();
            this.txtReadingcount = new System.Windows.Forms.TextBox();
            this.lblAccu = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColorName = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.prbWork = new System.Windows.Forms.ProgressBar();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(13, 13);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(516, 290);
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            this.picPicture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picPicture_MouseDoubleClick);
            // 
            // lblReadingcount
            // 
            this.lblReadingcount.AutoSize = true;
            this.lblReadingcount.Location = new System.Drawing.Point(535, 13);
            this.lblReadingcount.Name = "lblReadingcount";
            this.lblReadingcount.Size = new System.Drawing.Size(89, 13);
            this.lblReadingcount.TabIndex = 1;
            this.lblReadingcount.Text = "Messungsanzahl:";
            // 
            // txtReadingcount
            // 
            this.txtReadingcount.Location = new System.Drawing.Point(688, 10);
            this.txtReadingcount.Name = "txtReadingcount";
            this.txtReadingcount.Size = new System.Drawing.Size(30, 20);
            this.txtReadingcount.TabIndex = 2;
            // 
            // lblAccu
            // 
            this.lblAccu.AutoSize = true;
            this.lblAccu.Location = new System.Drawing.Point(724, 16);
            this.lblAccu.Name = "lblAccu";
            this.lblAccu.Size = new System.Drawing.Size(0, 13);
            this.lblAccu.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(535, 39);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Farbe:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(618, 39);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 5;
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(734, 39);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(56, 20);
            this.pnlColor.TabIndex = 6;
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Location = new System.Drawing.Point(535, 65);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(57, 13);
            this.lblColorName.TabIndex = 8;
            this.lblColorName.Text = "Farbname:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(618, 65);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(100, 20);
            this.txtColorName.TabIndex = 9;
            this.txtColorName.Text = "0";
            // 
            // prbWork
            // 
            this.prbWork.Location = new System.Drawing.Point(13, 332);
            this.prbWork.Name = "prbWork";
            this.prbWork.Size = new System.Drawing.Size(777, 23);
            this.prbWork.Step = 1;
            this.prbWork.TabIndex = 10;
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
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(688, 280);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(102, 23);
            this.btnAbort.TabIndex = 12;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // ColorInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 375);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.prbWork);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.lblColorName);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAccu);
            this.Controls.Add(this.txtReadingcount);
            this.Controls.Add(this.lblReadingcount);
            this.Controls.Add(this.picPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ColorInsert";
            this.Text = "Farbe hinzufügen";
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label lblReadingcount;
        private System.Windows.Forms.TextBox txtReadingcount;
        private System.Windows.Forms.Label lblAccu;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.ProgressBar prbWork;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnAbort;
    }
}

