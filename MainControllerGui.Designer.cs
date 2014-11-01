namespace bubblegum_sequencer
{
    partial class MainControllerGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControllerGui));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTact = new System.Windows.Forms.TextBox();
            this.numBPM = new System.Windows.Forms.NumericUpDown();
            this.lblTact = new System.Windows.Forms.Label();
            this.lblBPM = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lstCoTo = new System.Windows.Forms.ListBox();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBarFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarEditOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.farbverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnGetColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTact);
            this.panel1.Controls.Add(this.numBPM);
            this.panel1.Controls.Add(this.lblTact);
            this.panel1.Controls.Add(this.lblBPM);
            this.panel1.Controls.Add(this.tbVolume);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 52);
            this.panel1.TabIndex = 0;
            // 
            // txtTact
            // 
            this.txtTact.Location = new System.Drawing.Point(738, 27);
            this.txtTact.Name = "txtTact";
            this.txtTact.ReadOnly = true;
            this.txtTact.Size = new System.Drawing.Size(46, 20);
            this.txtTact.TabIndex = 8;
            // 
            // numBPM
            // 
            this.numBPM.Location = new System.Drawing.Point(738, 3);
            this.numBPM.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numBPM.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBPM.Name = "numBPM";
            this.numBPM.Size = new System.Drawing.Size(46, 20);
            this.numBPM.TabIndex = 7;
            this.numBPM.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBPM.ValueChanged += new System.EventHandler(this.numBPM_ValueChanged);
            // 
            // lblTact
            // 
            this.lblTact.AutoSize = true;
            this.lblTact.Location = new System.Drawing.Point(699, 27);
            this.lblTact.Name = "lblTact";
            this.lblTact.Size = new System.Drawing.Size(32, 13);
            this.lblTact.TabIndex = 6;
            this.lblTact.Text = "Takt:";
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.Location = new System.Drawing.Point(699, 9);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(33, 13);
            this.lblBPM.TabIndex = 5;
            this.lblBPM.Text = "BPM:";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(226, 3);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(104, 45);
            this.tbVolume.TabIndex = 4;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(568, 9);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(64, 31);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Aufnahme";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(516, 9);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(46, 31);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(464, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(46, 31);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(412, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 31);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkGrid
            // 
            this.chkGrid.AutoSize = true;
            this.chkGrid.Location = new System.Drawing.Point(226, 360);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(51, 17);
            this.chkGrid.TabIndex = 1;
            this.chkGrid.Text = "Gitter";
            this.chkGrid.UseVisualStyleBackColor = true;
            // 
            // picPicture
            // 
            this.picPicture.BackColor = System.Drawing.Color.DarkGray;
            this.picPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPicture.BackgroundImage")));
            this.picPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPicture.Location = new System.Drawing.Point(226, 38);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(562, 316);
            this.picPicture.TabIndex = 2;
            this.picPicture.TabStop = false;
            this.picPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.picPicture_Paint);
            // 
            // lstCoTo
            // 
            this.lstCoTo.FormattingEnabled = true;
            this.lstCoTo.Location = new System.Drawing.Point(12, 38);
            this.lstCoTo.Name = "lstCoTo";
            this.lstCoTo.Size = new System.Drawing.Size(175, 316);
            this.lstCoTo.TabIndex = 3;
            // 
            // mnuBar
            // 
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBarFile,
            this.mnuBarEdit,
            this.mnuBarHelp});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(801, 24);
            this.mnuBar.TabIndex = 4;
            this.mnuBar.Text = "Menueleiste";
            // 
            // mnuBarFile
            // 
            this.mnuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBarFileSave,
            this.mnuBarFileExport,
            this.toolStripSeparator1,
            this.mnuBarFileExit});
            this.mnuBarFile.Name = "mnuBarFile";
            this.mnuBarFile.Size = new System.Drawing.Size(46, 20);
            this.mnuBarFile.Text = "Datei";
            // 
            // mnuBarFileSave
            // 
            this.mnuBarFileSave.Name = "mnuBarFileSave";
            this.mnuBarFileSave.Size = new System.Drawing.Size(157, 22);
            this.mnuBarFileSave.Text = "Speichern unter";
            // 
            // mnuBarFileExport
            // 
            this.mnuBarFileExport.Name = "mnuBarFileExport";
            this.mnuBarFileExport.Size = new System.Drawing.Size(157, 22);
            this.mnuBarFileExport.Text = "Export";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // mnuBarFileExit
            // 
            this.mnuBarFileExit.Name = "mnuBarFileExit";
            this.mnuBarFileExit.Size = new System.Drawing.Size(157, 22);
            this.mnuBarFileExit.Text = "Beenden";
            // 
            // mnuBarEdit
            // 
            this.mnuBarEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBarEditOptions,
            this.toolStripMenuItem1,
            this.kameraToolStripMenuItem,
            this.toolStripMenuItem2,
            this.farbverwaltungToolStripMenuItem});
            this.mnuBarEdit.Name = "mnuBarEdit";
            this.mnuBarEdit.Size = new System.Drawing.Size(75, 20);
            this.mnuBarEdit.Text = "Bearbeiten";
            // 
            // mnuBarEditOptions
            // 
            this.mnuBarEditOptions.Name = "mnuBarEditOptions";
            this.mnuBarEditOptions.Size = new System.Drawing.Size(156, 22);
            this.mnuBarEditOptions.Text = "Optionen";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            this.kameraToolStripMenuItem.Click += new System.EventHandler(this.kameraToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // farbverwaltungToolStripMenuItem
            // 
            this.farbverwaltungToolStripMenuItem.Name = "farbverwaltungToolStripMenuItem";
            this.farbverwaltungToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.farbverwaltungToolStripMenuItem.Text = "Farbverwaltung";
            this.farbverwaltungToolStripMenuItem.Click += new System.EventHandler(this.farbverwaltungToolStripMenuItem_Click);
            // 
            // mnuBarHelp
            // 
            this.mnuBarHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBarHelpHelp,
            this.mnuBarHelpAbout});
            this.mnuBarHelp.Name = "mnuBarHelp";
            this.mnuBarHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuBarHelp.Text = "Hilfe";
            // 
            // mnuBarHelpHelp
            // 
            this.mnuBarHelpHelp.Name = "mnuBarHelpHelp";
            this.mnuBarHelpHelp.Size = new System.Drawing.Size(99, 22);
            this.mnuBarHelpHelp.Text = "Hilfe";
            // 
            // mnuBarHelpAbout
            // 
            this.mnuBarHelpAbout.Name = "mnuBarHelpAbout";
            this.mnuBarHelpAbout.Size = new System.Drawing.Size(99, 22);
            this.mnuBarHelpAbout.Text = "Über";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(285, 360);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 5;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(391, 360);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 6;
            // 
            // btnGetColor
            // 
            this.btnGetColor.Location = new System.Drawing.Point(497, 358);
            this.btnGetColor.Name = "btnGetColor";
            this.btnGetColor.Size = new System.Drawing.Size(75, 23);
            this.btnGetColor.TabIndex = 7;
            this.btnGetColor.Text = "GetColor";
            this.btnGetColor.UseVisualStyleBackColor = true;
            this.btnGetColor.Click += new System.EventHandler(this.btnGetColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(578, 360);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 8;
            // 
            // MainControllerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnGetColor);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lstCoTo);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.chkGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuBar;
            this.Name = "MainControllerGui";
            this.Text = "Bubblegum-Sequencer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainControllerGui_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.ListBox lstCoTo;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBarFile;
        private System.Windows.Forms.ToolStripMenuItem mnuBarEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuBarHelp;
        private System.Windows.Forms.NumericUpDown numBPM;
        private System.Windows.Forms.Label lblTact;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.TextBox txtTact;
        private System.Windows.Forms.ToolStripMenuItem mnuBarFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuBarFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuBarFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBarEditOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBarHelpHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuBarHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem farbverwaltungToolStripMenuItem;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnGetColor;
        private System.Windows.Forms.TextBox txtColor;
    }
}

