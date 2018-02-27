namespace MP3_Skull_Downloader
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbEnterSongName = new System.Windows.Forms.GroupBox();
            this.txtEnterSongName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbSongsFound = new System.Windows.Forms.GroupBox();
            this.lbSongsFound = new System.Windows.Forms.ListBox();
            this.lvSongsFound = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Download = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshList = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.gbLinkToDownload = new System.Windows.Forms.GroupBox();
            this.txtLinkToDownload = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbSongsFoundDownloaded = new System.Windows.Forms.GroupBox();
            this.lbSongsFoundDownloaded = new System.Windows.Forms.ListBox();
            this.lvSongsFoundDownloaded = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbEnterSongName.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbSongsFound.SuspendLayout();
            this.cmsOpciones1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbProgress.SuspendLayout();
            this.gbLinkToDownload.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbSongsFoundDownloaded.SuspendLayout();
            this.cmsOpciones2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage2);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Controls.Add(this.tabPage5);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 17);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(467, 243);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.pbLogo);
            this.tabPage1.Controls.Add(this.gbSearch);
            this.tabPage1.Controls.Add(this.gbEnterSongName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(29, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(406, 76);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Location = new System.Drawing.Point(112, 150);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(230, 48);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(17, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(197, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbEnterSongName
            // 
            this.gbEnterSongName.Controls.Add(this.txtEnterSongName);
            this.gbEnterSongName.ForeColor = System.Drawing.Color.Black;
            this.gbEnterSongName.Location = new System.Drawing.Point(60, 88);
            this.gbEnterSongName.Name = "gbEnterSongName";
            this.gbEnterSongName.Size = new System.Drawing.Size(340, 56);
            this.gbEnterSongName.TabIndex = 0;
            this.gbEnterSongName.TabStop = false;
            this.gbEnterSongName.Text = "Enter Song Name";
            // 
            // txtEnterSongName
            // 
            this.txtEnterSongName.BackColor = System.Drawing.Color.Black;
            this.txtEnterSongName.ForeColor = System.Drawing.Color.Lime;
            this.txtEnterSongName.Location = new System.Drawing.Point(19, 19);
            this.txtEnterSongName.Name = "txtEnterSongName";
            this.txtEnterSongName.Size = new System.Drawing.Size(305, 20);
            this.txtEnterSongName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.gbSongsFound);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            // 
            // gbSongsFound
            // 
            this.gbSongsFound.Controls.Add(this.lbSongsFound);
            this.gbSongsFound.Controls.Add(this.lvSongsFound);
            this.gbSongsFound.ForeColor = System.Drawing.Color.Black;
            this.gbSongsFound.Location = new System.Drawing.Point(21, 18);
            this.gbSongsFound.Name = "gbSongsFound";
            this.gbSongsFound.Size = new System.Drawing.Size(421, 183);
            this.gbSongsFound.TabIndex = 0;
            this.gbSongsFound.TabStop = false;
            this.gbSongsFound.Text = "Songs found";
            // 
            // lbSongsFound
            // 
            this.lbSongsFound.FormattingEnabled = true;
            this.lbSongsFound.Location = new System.Drawing.Point(256, 61);
            this.lbSongsFound.Name = "lbSongsFound";
            this.lbSongsFound.Size = new System.Drawing.Size(120, 95);
            this.lbSongsFound.TabIndex = 1;
            this.lbSongsFound.Visible = false;
            // 
            // lvSongsFound
            // 
            this.lvSongsFound.BackColor = System.Drawing.Color.Black;
            this.lvSongsFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSongsFound.ContextMenuStrip = this.cmsOpciones1;
            this.lvSongsFound.ForeColor = System.Drawing.Color.Lime;
            this.lvSongsFound.FullRowSelect = true;
            this.lvSongsFound.Location = new System.Drawing.Point(22, 28);
            this.lvSongsFound.Name = "lvSongsFound";
            this.lvSongsFound.Size = new System.Drawing.Size(381, 141);
            this.lvSongsFound.TabIndex = 0;
            this.lvSongsFound.UseCompatibleStateImageBehavior = false;
            this.lvSongsFound.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Information";
            this.columnHeader2.Width = 167;
            // 
            // cmsOpciones1
            // 
            this.cmsOpciones1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Download,
            this.RefreshList});
            this.cmsOpciones1.Name = "contextMenuStrip1";
            this.cmsOpciones1.Size = new System.Drawing.Size(135, 48);
            // 
            // Download
            // 
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(134, 22);
            this.Download.Text = "Download";
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // RefreshList
            // 
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(134, 22);
            this.RefreshList.Text = "Refresh List";
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.gbProgress);
            this.tabPage3.Controls.Add(this.gbLinkToDownload);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(459, 217);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Downloader";
            // 
            // gbProgress
            // 
            this.gbProgress.Controls.Add(this.pbProgress);
            this.gbProgress.ForeColor = System.Drawing.Color.Black;
            this.gbProgress.Location = new System.Drawing.Point(27, 104);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(414, 72);
            this.gbProgress.TabIndex = 1;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Progress";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(19, 27);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(380, 22);
            this.pbProgress.TabIndex = 0;
            // 
            // gbLinkToDownload
            // 
            this.gbLinkToDownload.Controls.Add(this.txtLinkToDownload);
            this.gbLinkToDownload.ForeColor = System.Drawing.Color.Black;
            this.gbLinkToDownload.Location = new System.Drawing.Point(27, 18);
            this.gbLinkToDownload.Name = "gbLinkToDownload";
            this.gbLinkToDownload.Size = new System.Drawing.Size(414, 69);
            this.gbLinkToDownload.TabIndex = 0;
            this.gbLinkToDownload.TabStop = false;
            this.gbLinkToDownload.Text = "Link to Download";
            // 
            // txtLinkToDownload
            // 
            this.txtLinkToDownload.BackColor = System.Drawing.Color.Black;
            this.txtLinkToDownload.ForeColor = System.Drawing.Color.Lime;
            this.txtLinkToDownload.Location = new System.Drawing.Point(19, 31);
            this.txtLinkToDownload.Name = "txtLinkToDownload";
            this.txtLinkToDownload.Size = new System.Drawing.Size(380, 20);
            this.txtLinkToDownload.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.gbSongsFoundDownloaded);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(459, 217);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Files Downloads";
            // 
            // gbSongsFoundDownloaded
            // 
            this.gbSongsFoundDownloaded.Controls.Add(this.lbSongsFoundDownloaded);
            this.gbSongsFoundDownloaded.Controls.Add(this.lvSongsFoundDownloaded);
            this.gbSongsFoundDownloaded.ForeColor = System.Drawing.Color.Black;
            this.gbSongsFoundDownloaded.Location = new System.Drawing.Point(21, 15);
            this.gbSongsFoundDownloaded.Name = "gbSongsFoundDownloaded";
            this.gbSongsFoundDownloaded.Size = new System.Drawing.Size(420, 185);
            this.gbSongsFoundDownloaded.TabIndex = 0;
            this.gbSongsFoundDownloaded.TabStop = false;
            this.gbSongsFoundDownloaded.Text = "Songs found";
            // 
            // lbSongsFoundDownloaded
            // 
            this.lbSongsFoundDownloaded.FormattingEnabled = true;
            this.lbSongsFoundDownloaded.Location = new System.Drawing.Point(266, 72);
            this.lbSongsFoundDownloaded.Name = "lbSongsFoundDownloaded";
            this.lbSongsFoundDownloaded.Size = new System.Drawing.Size(120, 95);
            this.lbSongsFoundDownloaded.TabIndex = 1;
            this.lbSongsFoundDownloaded.Visible = false;
            // 
            // lvSongsFoundDownloaded
            // 
            this.lvSongsFoundDownloaded.BackColor = System.Drawing.Color.Black;
            this.lvSongsFoundDownloaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvSongsFoundDownloaded.ContextMenuStrip = this.cmsOpciones2;
            this.lvSongsFoundDownloaded.ForeColor = System.Drawing.Color.Lime;
            this.lvSongsFoundDownloaded.FullRowSelect = true;
            this.lvSongsFoundDownloaded.Location = new System.Drawing.Point(23, 29);
            this.lvSongsFoundDownloaded.Name = "lvSongsFoundDownloaded";
            this.lvSongsFoundDownloaded.Size = new System.Drawing.Size(378, 138);
            this.lvSongsFoundDownloaded.TabIndex = 0;
            this.lvSongsFoundDownloaded.UseCompatibleStateImageBehavior = false;
            this.lvSongsFoundDownloaded.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Creation Date";
            this.columnHeader4.Width = 185;
            // 
            // cmsOpciones2
            // 
            this.cmsOpciones2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play,
            this.Refresh});
            this.cmsOpciones2.Name = "contextMenuStrip2";
            this.cmsOpciones2.Size = new System.Drawing.Size(114, 48);
            // 
            // Play
            // 
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(113, 22);
            this.Play.Text = "Play";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(113, 22);
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Transparent;
            this.tabPage5.Controls.Add(this.gbAbout);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(459, 217);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lblAbout);
            this.gbAbout.Controls.Add(this.pbAbout);
            this.gbAbout.ForeColor = System.Drawing.Color.Black;
            this.gbAbout.Location = new System.Drawing.Point(25, 14);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(418, 180);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Black;
            this.lblAbout.Location = new System.Drawing.Point(205, 56);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(197, 65);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "MP3 Skull Downloader \r\nVersion 0.5\r\nWritten By Ismael Heredia\r\nContact : ismael_h" +
    "eredia[at]hotmail[com]\r\nWeb : ismaelheredia123.wordpress.com";
            // 
            // pbAbout
            // 
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(24, 19);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(175, 155);
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Black;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 277);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(491, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(491, 299);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - MP3 Skull Downloader 0.5 - © Ismael Heredia , Argentina , 2014 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbEnterSongName.ResumeLayout(false);
            this.gbEnterSongName.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbSongsFound.ResumeLayout(false);
            this.cmsOpciones1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbProgress.ResumeLayout(false);
            this.gbLinkToDownload.ResumeLayout(false);
            this.gbLinkToDownload.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbSongsFoundDownloaded.ResumeLayout(false);
            this.cmsOpciones2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbEnterSongName;
        private System.Windows.Forms.TextBox txtEnterSongName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox gbSongsFound;
        private System.Windows.Forms.ListView lvSongsFound;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbLinkToDownload;
        private System.Windows.Forms.TextBox txtLinkToDownload;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.GroupBox gbSongsFoundDownloaded;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.ListBox lbSongsFound;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones1;
        private System.Windows.Forms.ToolStripMenuItem Download;
        private System.Windows.Forms.ToolStripMenuItem RefreshList;
        private System.Windows.Forms.ListView lvSongsFoundDownloaded;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones2;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.ListBox lbSongsFoundDownloaded;
        private System.Windows.Forms.ToolStripMenuItem Play;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

