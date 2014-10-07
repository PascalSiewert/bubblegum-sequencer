namespace bubblegum_sequencer
{
    partial class ColorManagerV2
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
            this.lstColors = new System.Windows.Forms.ListBox();
            this.lblColourName = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.lblReadingcount = new System.Windows.Forms.Label();
            this.txtReadingcount = new System.Windows.Forms.TextBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(13, 13);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(224, 212);
            this.lstColors.TabIndex = 0;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // lblColourName
            // 
            this.lblColourName.AutoSize = true;
            this.lblColourName.Location = new System.Drawing.Point(247, 16);
            this.lblColourName.Name = "lblColourName";
            this.lblColourName.Size = new System.Drawing.Size(57, 13);
            this.lblColourName.TabIndex = 1;
            this.lblColourName.Text = "Farbname:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(319, 13);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(220, 20);
            this.txtColorName.TabIndex = 2;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(247, 59);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Farbe:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(319, 56);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 4;
            // 
            // pnlColour
            // 
            this.pnlColour.Location = new System.Drawing.Point(439, 56);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(100, 20);
            this.pnlColour.TabIndex = 5;
            // 
            // lblReadingcount
            // 
            this.lblReadingcount.AutoSize = true;
            this.lblReadingcount.Location = new System.Drawing.Point(247, 102);
            this.lblReadingcount.Name = "lblReadingcount";
            this.lblReadingcount.Size = new System.Drawing.Size(89, 13);
            this.lblReadingcount.TabIndex = 6;
            this.lblReadingcount.Text = "Messungsanzahl:";
            // 
            // txtReadingcount
            // 
            this.txtReadingcount.Location = new System.Drawing.Point(342, 99);
            this.txtReadingcount.Name = "txtReadingcount";
            this.txtReadingcount.ReadOnly = true;
            this.txtReadingcount.Size = new System.Drawing.Size(30, 20);
            this.txtReadingcount.TabIndex = 7;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(250, 163);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(130, 23);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "Farbe hinzufügen";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
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
            // ColorManagerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.txtReadingcount);
            this.Controls.Add(this.lblReadingcount);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.lblColourName);
            this.Controls.Add(this.lstColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorManagerV2";
            this.Text = "Farbverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblColourName;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel pnlColour;
        private System.Windows.Forms.Label lblReadingcount;
        private System.Windows.Forms.TextBox txtReadingcount;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}