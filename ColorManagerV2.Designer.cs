namespace bubblegum
{
    partial class Farbverwaltung
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lblColourName = new System.Windows.Forms.Label();
            this.txtBoxClrName = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtBoxClr = new System.Windows.Forms.TextBox();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.txtBoxAccu = new System.Windows.Forms.TextBox();
            this.btnAddClr = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(13, 13);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(224, 212);
            this.lstBox.TabIndex = 0;
            // 
            // lblColourName
            // 
            this.lblColourName.AutoSize = true;
            this.lblColourName.Location = new System.Drawing.Point(244, 13);
            this.lblColourName.Name = "lblColourName";
            this.lblColourName.Size = new System.Drawing.Size(57, 13);
            this.lblColourName.TabIndex = 1;
            this.lblColourName.Text = "Farbname:";
            // 
            // txtBoxClrName
            // 
            this.txtBoxClrName.Location = new System.Drawing.Point(319, 13);
            this.txtBoxClrName.Name = "txtBoxClrName";
            this.txtBoxClrName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxClrName.TabIndex = 2;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(247, 59);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 3;
            this.lblColour.Text = "Farbe:";
            // 
            // txtBoxClr
            // 
            this.txtBoxClr.Location = new System.Drawing.Point(319, 59);
            this.txtBoxClr.Name = "txtBoxClr";
            this.txtBoxClr.ReadOnly = true;
            this.txtBoxClr.Size = new System.Drawing.Size(100, 20);
            this.txtBoxClr.TabIndex = 4;
            // 
            // pnlColour
            // 
            this.pnlColour.Location = new System.Drawing.Point(440, 59);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(100, 20);
            this.pnlColour.TabIndex = 5;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(247, 102);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(67, 13);
            this.lblAccuracy.TabIndex = 6;
            this.lblAccuracy.Text = "Genauigkeit:";
            // 
            // txtBoxAccu
            // 
            this.txtBoxAccu.Location = new System.Drawing.Point(319, 102);
            this.txtBoxAccu.Name = "txtBoxAccu";
            this.txtBoxAccu.ReadOnly = true;
            this.txtBoxAccu.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccu.TabIndex = 7;
            // 
            // btnAddClr
            // 
            this.btnAddClr.Location = new System.Drawing.Point(250, 163);
            this.btnAddClr.Name = "btnAddClr";
            this.btnAddClr.Size = new System.Drawing.Size(130, 23);
            this.btnAddClr.TabIndex = 8;
            this.btnAddClr.Text = "Farbe hinzufügen";
            this.btnAddClr.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(310, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Farbverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddClr);
            this.Controls.Add(this.txtBoxAccu);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.txtBoxClr);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.txtBoxClrName);
            this.Controls.Add(this.lblColourName);
            this.Controls.Add(this.lstBox);
            this.Name = "Farbverwaltung";
            this.Text = "Farbverwaltung";
            this.Load += new System.EventHandler(this.Farbverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lblColourName;
        private System.Windows.Forms.TextBox txtBoxClrName;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtBoxClr;
        private System.Windows.Forms.Panel pnlColour;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.TextBox txtBoxAccu;
        private System.Windows.Forms.Button btnAddClr;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}