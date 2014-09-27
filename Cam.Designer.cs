namespace bubblegum_sequencer
{
    partial class Cam
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lblCam = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lnsSeperator = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblFps = new System.Windows.Forms.Label();
            this.cbxCam = new System.Windows.Forms.ComboBox();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.txtFps = new System.Windows.Forms.TextBox();
            this.gpxJustification = new System.Windows.Forms.GroupBox();
            this.btnJustification = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.cbxCornerColor = new System.Windows.Forms.ComboBox();
            this.lblCornerColor = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.gpxJustification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(159, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(398, 25);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Kameraeinstellungen und -justierung";
            // 
            // lblCam
            // 
            this.lblCam.AutoSize = true;
            this.lblCam.Location = new System.Drawing.Point(13, 57);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(46, 13);
            this.lblCam.TabIndex = 1;
            this.lblCam.Text = "Kamera:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnsSeperator});
            this.shapeContainer1.Size = new System.Drawing.Size(699, 292);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lnsSeperator
            // 
            this.lnsSeperator.Name = "lnsSeperator";
            this.lnsSeperator.X1 = 13;
            this.lnsSeperator.X2 = 688;
            this.lnsSeperator.Y1 = 39;
            this.lnsSeperator.Y2 = 39;
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(13, 84);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 3;
            this.lblResolution.Text = "Auflösung:";
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(13, 112);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(30, 13);
            this.lblFps.TabIndex = 4;
            this.lblFps.Tag = "";
            this.lblFps.Text = "FPS:";
            // 
            // cbxCam
            // 
            this.cbxCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCam.FormattingEnabled = true;
            this.cbxCam.Location = new System.Drawing.Point(79, 54);
            this.cbxCam.Name = "cbxCam";
            this.cbxCam.Size = new System.Drawing.Size(193, 21);
            this.cbxCam.TabIndex = 5;
            this.cbxCam.SelectedIndexChanged += new System.EventHandler(this.cbxCam_SelectedIndexChanged);
            // 
            // cbxResolution
            // 
            this.cbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(79, 81);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(193, 21);
            this.cbxResolution.TabIndex = 6;
            this.cbxResolution.SelectedIndexChanged += new System.EventHandler(this.cbxResolution_SelectedIndexChanged);
            // 
            // txtFps
            // 
            this.txtFps.Location = new System.Drawing.Point(79, 109);
            this.txtFps.Name = "txtFps";
            this.txtFps.Size = new System.Drawing.Size(193, 20);
            this.txtFps.TabIndex = 7;
            // 
            // gpxJustification
            // 
            this.gpxJustification.Controls.Add(this.btnJustification);
            this.gpxJustification.Controls.Add(this.txtRows);
            this.gpxJustification.Controls.Add(this.txtColumns);
            this.gpxJustification.Controls.Add(this.lblRows);
            this.gpxJustification.Controls.Add(this.lblColumns);
            this.gpxJustification.Controls.Add(this.cbxCornerColor);
            this.gpxJustification.Controls.Add(this.lblCornerColor);
            this.gpxJustification.Location = new System.Drawing.Point(16, 147);
            this.gpxJustification.Name = "gpxJustification";
            this.gpxJustification.Size = new System.Drawing.Size(256, 109);
            this.gpxJustification.TabIndex = 8;
            this.gpxJustification.TabStop = false;
            this.gpxJustification.Text = "Justierung";
            // 
            // btnJustification
            // 
            this.btnJustification.Location = new System.Drawing.Point(6, 72);
            this.btnJustification.Name = "btnJustification";
            this.btnJustification.Size = new System.Drawing.Size(244, 31);
            this.btnJustification.TabIndex = 6;
            this.btnJustification.Text = "Justieren";
            this.btnJustification.UseVisualStyleBackColor = true;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(190, 46);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(60, 20);
            this.txtRows.TabIndex = 5;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(59, 46);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(60, 20);
            this.txtColumns.TabIndex = 4;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(140, 49);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(44, 13);
            this.lblRows.TabIndex = 3;
            this.lblRows.Text = "Reihen:";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(7, 49);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(46, 13);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Spalten:";
            // 
            // cbxCornerColor
            // 
            this.cbxCornerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCornerColor.FormattingEnabled = true;
            this.cbxCornerColor.Location = new System.Drawing.Point(93, 17);
            this.cbxCornerColor.Name = "cbxCornerColor";
            this.cbxCornerColor.Size = new System.Drawing.Size(157, 21);
            this.cbxCornerColor.TabIndex = 1;
            // 
            // lblCornerColor
            // 
            this.lblCornerColor.AutoSize = true;
            this.lblCornerColor.Location = new System.Drawing.Point(7, 20);
            this.lblCornerColor.Name = "lblCornerColor";
            this.lblCornerColor.Size = new System.Drawing.Size(80, 13);
            this.lblCornerColor.TabIndex = 0;
            this.lblCornerColor.Text = "Eckpunktfarbe:";
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(16, 262);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(120, 23);
            this.btnResume.TabIndex = 9;
            this.btnResume.Text = "Übernehmen";
            this.btnResume.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(152, 262);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(120, 23);
            this.btnAbort.TabIndex = 10;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // picPicture
            // 
            this.picPicture.BackColor = System.Drawing.Color.DarkGray;
            this.picPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPicture.Location = new System.Drawing.Point(278, 54);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(410, 230);
            this.picPicture.TabIndex = 11;
            this.picPicture.TabStop = false;
            // 
            // Cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 292);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.gpxJustification);
            this.Controls.Add(this.txtFps);
            this.Controls.Add(this.cbxResolution);
            this.Controls.Add(this.cbxCam);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblCam);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cam";
            this.Text = "Kameraeinstellungen und -justierung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cam_FormClosed);
            this.Load += new System.EventHandler(this.Cam_Load);
            this.gpxJustification.ResumeLayout(false);
            this.gpxJustification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lblCam;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnsSeperator;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.ComboBox cbxCam;
        private System.Windows.Forms.ComboBox cbxResolution;
        private System.Windows.Forms.TextBox txtFps;
        private System.Windows.Forms.GroupBox gpxJustification;
        private System.Windows.Forms.Label lblCornerColor;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.ComboBox cbxCornerColor;
        private System.Windows.Forms.Button btnJustification;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.PictureBox picPicture;
    }
}