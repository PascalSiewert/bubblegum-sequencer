namespace bubblegum_sequencer
{
    partial class ColorInsertALPHA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorInsertALPHA));
            this.gbxMeasure = new System.Windows.Forms.GroupBox();
            this.pnlMeasureColor = new System.Windows.Forms.Panel();
            this.txtMeasureGreen = new System.Windows.Forms.TextBox();
            this.txtMeasureBlue = new System.Windows.Forms.TextBox();
            this.txtMeasureRed = new System.Windows.Forms.TextBox();
            this.lblMeasureBlue = new System.Windows.Forms.Label();
            this.lblMeasureGreen = new System.Windows.Forms.Label();
            this.lblMeasureRed = new System.Windows.Forms.Label();
            this.btnGetMeasure = new System.Windows.Forms.Button();
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
            this.btnInsertColor = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.vspStream = new AForge.Controls.VideoSourcePlayer();
            this.gbxMeasure.SuspendLayout();
            this.gbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMeasure
            // 
            this.gbxMeasure.Controls.Add(this.pnlMeasureColor);
            this.gbxMeasure.Controls.Add(this.txtMeasureGreen);
            this.gbxMeasure.Controls.Add(this.txtMeasureBlue);
            this.gbxMeasure.Controls.Add(this.txtMeasureRed);
            this.gbxMeasure.Controls.Add(this.lblMeasureBlue);
            this.gbxMeasure.Controls.Add(this.lblMeasureGreen);
            this.gbxMeasure.Controls.Add(this.lblMeasureRed);
            this.gbxMeasure.Location = new System.Drawing.Point(535, 12);
            this.gbxMeasure.Name = "gbxMeasure";
            this.gbxMeasure.Size = new System.Drawing.Size(191, 91);
            this.gbxMeasure.TabIndex = 2;
            this.gbxMeasure.TabStop = false;
            this.gbxMeasure.Text = "Messung";
            // 
            // pnlMeasureColor
            // 
            this.pnlMeasureColor.Location = new System.Drawing.Point(63, 17);
            this.pnlMeasureColor.Name = "pnlMeasureColor";
            this.pnlMeasureColor.Size = new System.Drawing.Size(122, 68);
            this.pnlMeasureColor.TabIndex = 6;
            // 
            // txtMeasureGreen
            // 
            this.txtMeasureGreen.Location = new System.Drawing.Point(31, 41);
            this.txtMeasureGreen.MaxLength = 3;
            this.txtMeasureGreen.Name = "txtMeasureGreen";
            this.txtMeasureGreen.ReadOnly = true;
            this.txtMeasureGreen.Size = new System.Drawing.Size(26, 20);
            this.txtMeasureGreen.TabIndex = 5;
            // 
            // txtMeasureBlue
            // 
            this.txtMeasureBlue.Location = new System.Drawing.Point(31, 65);
            this.txtMeasureBlue.MaxLength = 3;
            this.txtMeasureBlue.Name = "txtMeasureBlue";
            this.txtMeasureBlue.ReadOnly = true;
            this.txtMeasureBlue.Size = new System.Drawing.Size(26, 20);
            this.txtMeasureBlue.TabIndex = 4;
            // 
            // txtMeasureRed
            // 
            this.txtMeasureRed.Location = new System.Drawing.Point(31, 17);
            this.txtMeasureRed.MaxLength = 3;
            this.txtMeasureRed.Name = "txtMeasureRed";
            this.txtMeasureRed.ReadOnly = true;
            this.txtMeasureRed.Size = new System.Drawing.Size(26, 20);
            this.txtMeasureRed.TabIndex = 3;
            // 
            // lblMeasureBlue
            // 
            this.lblMeasureBlue.AutoSize = true;
            this.lblMeasureBlue.Location = new System.Drawing.Point(7, 68);
            this.lblMeasureBlue.Name = "lblMeasureBlue";
            this.lblMeasureBlue.Size = new System.Drawing.Size(17, 13);
            this.lblMeasureBlue.TabIndex = 2;
            this.lblMeasureBlue.Text = "B:";
            // 
            // lblMeasureGreen
            // 
            this.lblMeasureGreen.AutoSize = true;
            this.lblMeasureGreen.Location = new System.Drawing.Point(7, 44);
            this.lblMeasureGreen.Name = "lblMeasureGreen";
            this.lblMeasureGreen.Size = new System.Drawing.Size(18, 13);
            this.lblMeasureGreen.TabIndex = 1;
            this.lblMeasureGreen.Text = "G:";
            // 
            // lblMeasureRed
            // 
            this.lblMeasureRed.AutoSize = true;
            this.lblMeasureRed.Location = new System.Drawing.Point(7, 20);
            this.lblMeasureRed.Name = "lblMeasureRed";
            this.lblMeasureRed.Size = new System.Drawing.Size(18, 13);
            this.lblMeasureRed.TabIndex = 0;
            this.lblMeasureRed.Text = "R:";
            // 
            // btnGetMeasure
            // 
            this.btnGetMeasure.Location = new System.Drawing.Point(535, 103);
            this.btnGetMeasure.Name = "btnGetMeasure";
            this.btnGetMeasure.Size = new System.Drawing.Size(191, 23);
            this.btnGetMeasure.TabIndex = 3;
            this.btnGetMeasure.Text = "Messung übernehmen";
            this.btnGetMeasure.UseVisualStyleBackColor = true;
            this.btnGetMeasure.Click += new System.EventHandler(this.btnGetMeasure_Click);
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.lblColorname);
            this.gbxColor.Controls.Add(this.txtColorname);
            this.gbxColor.Controls.Add(this.pnlColor);
            this.gbxColor.Controls.Add(this.txtGreen);
            this.gbxColor.Controls.Add(this.txtBlue);
            this.gbxColor.Controls.Add(this.txtRed);
            this.gbxColor.Controls.Add(this.lblBlue);
            this.gbxColor.Controls.Add(this.lblGreen);
            this.gbxColor.Controls.Add(this.lblRed);
            this.gbxColor.Location = new System.Drawing.Point(535, 132);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(191, 113);
            this.gbxColor.TabIndex = 7;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Farbe";
            // 
            // lblColorname
            // 
            this.lblColorname.AutoSize = true;
            this.lblColorname.Location = new System.Drawing.Point(7, 90);
            this.lblColorname.Name = "lblColorname";
            this.lblColorname.Size = new System.Drawing.Size(57, 13);
            this.lblColorname.TabIndex = 8;
            this.lblColorname.Text = "Farbname:";
            // 
            // txtColorname
            // 
            this.txtColorname.Location = new System.Drawing.Point(70, 87);
            this.txtColorname.Name = "txtColorname";
            this.txtColorname.Size = new System.Drawing.Size(115, 20);
            this.txtColorname.TabIndex = 7;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.Location = new System.Drawing.Point(63, 17);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(122, 68);
            this.pnlColor.TabIndex = 6;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(31, 41);
            this.txtGreen.MaxLength = 3;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(26, 20);
            this.txtGreen.TabIndex = 5;
            this.txtGreen.Text = "255";
            this.txtGreen.TextChanged += new System.EventHandler(this.txtGreen_TextChanged);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(31, 65);
            this.txtBlue.MaxLength = 3;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(26, 20);
            this.txtBlue.TabIndex = 4;
            this.txtBlue.Text = "255";
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(31, 17);
            this.txtRed.MaxLength = 3;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(26, 20);
            this.txtRed.TabIndex = 3;
            this.txtRed.Text = "255";
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
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
            // btnInsertColor
            // 
            this.btnInsertColor.Location = new System.Drawing.Point(535, 251);
            this.btnInsertColor.Name = "btnInsertColor";
            this.btnInsertColor.Size = new System.Drawing.Size(191, 23);
            this.btnInsertColor.TabIndex = 8;
            this.btnInsertColor.Text = "Farbe hinzufügen";
            this.btnInsertColor.UseVisualStyleBackColor = true;
            this.btnInsertColor.Click += new System.EventHandler(this.btnInsertColor_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(535, 280);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(191, 23);
            this.btnAbort.TabIndex = 9;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // vspStream
            // 
            this.vspStream.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vspStream.BackgroundImage")));
            this.vspStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vspStream.Location = new System.Drawing.Point(12, 12);
            this.vspStream.Name = "vspStream";
            this.vspStream.Size = new System.Drawing.Size(516, 290);
            this.vspStream.TabIndex = 10;
            this.vspStream.Text = "Stream";
            this.vspStream.VideoSource = null;
            this.vspStream.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.vspStream_MouseDoubleClick);
            // 
            // ColorInsertALPHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 315);
            this.Controls.Add(this.vspStream);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnInsertColor);
            this.Controls.Add(this.gbxColor);
            this.Controls.Add(this.btnGetMeasure);
            this.Controls.Add(this.gbxMeasure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorInsertALPHA";
            this.Text = "ColorInsertALPHA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorInsertALPHA_FormClosing);
            this.gbxMeasure.ResumeLayout(false);
            this.gbxMeasure.PerformLayout();
            this.gbxColor.ResumeLayout(false);
            this.gbxColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMeasure;
        private System.Windows.Forms.Panel pnlMeasureColor;
        private System.Windows.Forms.TextBox txtMeasureGreen;
        private System.Windows.Forms.TextBox txtMeasureBlue;
        private System.Windows.Forms.TextBox txtMeasureRed;
        private System.Windows.Forms.Label lblMeasureBlue;
        private System.Windows.Forms.Label lblMeasureGreen;
        private System.Windows.Forms.Label lblMeasureRed;
        private System.Windows.Forms.Button btnGetMeasure;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnInsertColor;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblColorname;
        private System.Windows.Forms.TextBox txtColorname;
        private AForge.Controls.VideoSourcePlayer vspStream;
    }
}