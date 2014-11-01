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
            this.lblReadingcount = new System.Windows.Forms.Label();
            this.txtReadingcount = new System.Windows.Forms.TextBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.lblColorname = new System.Windows.Forms.Label();
            this.txtColorname = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.gbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(13, 13);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(224, 173);
            this.lstColors.TabIndex = 0;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // lblReadingcount
            // 
            this.lblReadingcount.AutoSize = true;
            this.lblReadingcount.Enabled = false;
            this.lblReadingcount.Location = new System.Drawing.Point(180, 94);
            this.lblReadingcount.Name = "lblReadingcount";
            this.lblReadingcount.Size = new System.Drawing.Size(89, 13);
            this.lblReadingcount.TabIndex = 6;
            this.lblReadingcount.Text = "Messungsanzahl:";
            this.lblReadingcount.Visible = false;
            // 
            // txtReadingcount
            // 
            this.txtReadingcount.Enabled = false;
            this.txtReadingcount.Location = new System.Drawing.Point(274, 91);
            this.txtReadingcount.Name = "txtReadingcount";
            this.txtReadingcount.ReadOnly = true;
            this.txtReadingcount.Size = new System.Drawing.Size(30, 20);
            this.txtReadingcount.TabIndex = 7;
            this.txtReadingcount.Visible = false;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(250, 137);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(130, 23);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "Farbe hinzufügen";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(310, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.lblColorname);
            this.gbxColor.Controls.Add(this.txtColorname);
            this.gbxColor.Controls.Add(this.pnlColor);
            this.gbxColor.Controls.Add(this.txtGreen);
            this.gbxColor.Controls.Add(this.txtReadingcount);
            this.gbxColor.Controls.Add(this.txtBlue);
            this.gbxColor.Controls.Add(this.lblReadingcount);
            this.gbxColor.Controls.Add(this.txtRed);
            this.gbxColor.Controls.Add(this.lblBlue);
            this.gbxColor.Controls.Add(this.lblGreen);
            this.gbxColor.Controls.Add(this.lblRed);
            this.gbxColor.Location = new System.Drawing.Point(250, 13);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(310, 118);
            this.gbxColor.TabIndex = 11;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Farbe";
            // 
            // lblColorname
            // 
            this.lblColorname.AutoSize = true;
            this.lblColorname.Location = new System.Drawing.Point(7, 94);
            this.lblColorname.Name = "lblColorname";
            this.lblColorname.Size = new System.Drawing.Size(57, 13);
            this.lblColorname.TabIndex = 8;
            this.lblColorname.Text = "Farbname:";
            // 
            // txtColorname
            // 
            this.txtColorname.Location = new System.Drawing.Point(70, 91);
            this.txtColorname.Name = "txtColorname";
            this.txtColorname.Size = new System.Drawing.Size(104, 20);
            this.txtColorname.TabIndex = 7;
            this.txtColorname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorname_KeyDown);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(70, 13);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(234, 72);
            this.pnlColor.TabIndex = 6;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(31, 41);
            this.txtGreen.MaxLength = 3;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(26, 20);
            this.txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(31, 65);
            this.txtBlue.MaxLength = 3;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(26, 20);
            this.txtBlue.TabIndex = 4;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(31, 17);
            this.txtRed.MaxLength = 3;
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(26, 20);
            this.txtRed.TabIndex = 3;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(7, 68);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(17, 13);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "B:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(7, 44);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(18, 13);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "G:";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(7, 20);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(18, 13);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "R:";
            // 
            // ColorManagerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 195);
            this.Controls.Add(this.gbxColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.lstColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorManagerV2";
            this.Text = "Farbverwaltung";
            this.gbxColor.ResumeLayout(false);
            this.gbxColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblReadingcount;
        private System.Windows.Forms.TextBox txtReadingcount;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.Label lblColorname;
        private System.Windows.Forms.TextBox txtColorname;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
    }
}