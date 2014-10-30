namespace bubblegum_sequencer
{
    partial class ColorManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorManager));
            this.tosColorManager = new System.Windows.Forms.ToolStrip();
            this.tlblAccuracy = new System.Windows.Forms.ToolStripLabel();
            this.ttxtAccuracy = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.pgb_Colormeasure = new System.Windows.Forms.ProgressBar();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColorname = new System.Windows.Forms.Label();
            this.txtColorname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.tosColorManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tosColorManager
            // 
            this.tosColorManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblAccuracy,
            this.ttxtAccuracy,
            this.tbtnHelp});
            this.tosColorManager.Location = new System.Drawing.Point(0, 0);
            this.tosColorManager.Name = "tosColorManager";
            this.tosColorManager.Size = new System.Drawing.Size(834, 25);
            this.tosColorManager.TabIndex = 0;
            this.tosColorManager.Text = "ColorManager";
            // 
            // tlblAccuracy
            // 
            this.tlblAccuracy.Name = "tlblAccuracy";
            this.tlblAccuracy.Size = new System.Drawing.Size(73, 22);
            this.tlblAccuracy.Text = "Genauigkeit:";
            // 
            // ttxtAccuracy
            // 
            this.ttxtAccuracy.MaxLength = 4;
            this.ttxtAccuracy.Name = "ttxtAccuracy";
            this.ttxtAccuracy.Size = new System.Drawing.Size(30, 25);
            // 
            // tbtnHelp
            // 
            this.tbtnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tbtnHelp.Image")));
            this.tbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHelp.Name = "tbtnHelp";
            this.tbtnHelp.Size = new System.Drawing.Size(36, 22);
            this.tbtnHelp.Text = "Hilfe";
            // 
            // picPicture
            // 
            this.picPicture.BackColor = System.Drawing.Color.DarkGray;
            this.picPicture.Location = new System.Drawing.Point(13, 29);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(570, 320);
            this.picPicture.TabIndex = 1;
            this.picPicture.TabStop = false;
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(589, 29);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(233, 342);
            this.lstColors.TabIndex = 2;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(13, 356);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(67, 13);
            this.lblAccuracy.TabIndex = 3;
            this.lblAccuracy.Text = "Genauigkeit:";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(86, 353);
            this.txtAccuracy.MaxLength = 4;
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.ReadOnly = true;
            this.txtAccuracy.Size = new System.Drawing.Size(30, 20);
            this.txtAccuracy.TabIndex = 4;
            // 
            // pgb_Colormeasure
            // 
            this.pgb_Colormeasure.Location = new System.Drawing.Point(122, 350);
            this.pgb_Colormeasure.Name = "pgb_Colormeasure";
            this.pgb_Colormeasure.Size = new System.Drawing.Size(461, 23);
            this.pgb_Colormeasure.TabIndex = 5;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(13, 384);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Farbe:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(56, 381);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(203, 20);
            this.txtColor.TabIndex = 7;
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(265, 381);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(20, 20);
            this.pnlColor.TabIndex = 8;
            // 
            // lblColorname
            // 
            this.lblColorname.AutoSize = true;
            this.lblColorname.Location = new System.Drawing.Point(291, 384);
            this.lblColorname.Name = "lblColorname";
            this.lblColorname.Size = new System.Drawing.Size(57, 13);
            this.lblColorname.TabIndex = 9;
            this.lblColorname.Text = "Farbname:";
            // 
            // txtColorname
            // 
            this.txtColorname.Location = new System.Drawing.Point(354, 381);
            this.txtColorname.Name = "txtColorname";
            this.txtColorname.Size = new System.Drawing.Size(229, 20);
            this.txtColorname.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(589, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 27);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(749, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(669, 374);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(73, 27);
            this.btnBearbeiten.TabIndex = 13;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // ColorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 408);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtColorname);
            this.Controls.Add(this.lblColorname);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.pgb_Colormeasure);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.tosColorManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorManager";
            this.Text = "Farbverwaltung";
            this.tosColorManager.ResumeLayout(false);
            this.tosColorManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tosColorManager;
        private System.Windows.Forms.ToolStripLabel tlblAccuracy;
        private System.Windows.Forms.ToolStripTextBox ttxtAccuracy;
        private System.Windows.Forms.ToolStripButton tbtnHelp;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.ProgressBar pgb_Colormeasure;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColorname;
        private System.Windows.Forms.TextBox txtColorname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBearbeiten;
    }
}