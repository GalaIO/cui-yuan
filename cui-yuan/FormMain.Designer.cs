namespace cui_yuan
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_Shopin = new System.Windows.Forms.TabPage();
            this.panel_shopin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Shopin = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_shopin_photo = new System.Windows.Forms.TableLayoutPanel();
            this.panel_videoPlayer = new System.Windows.Forms.Panel();
            this.groupBox_videoPlayer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_videoPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_videoPlayer = new System.Windows.Forms.ComboBox();
            this.videoPlayer_shopin = new AForge.Controls.VideoSourcePlayer();
            this.panel_photoPreview = new System.Windows.Forms.Panel();
            this.groupBox_photoPreview = new System.Windows.Forms.GroupBox();
            this.panel_shopin_detail = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_detail = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_weight = new System.Windows.Forms.GroupBox();
            this.groupBox_notes = new System.Windows.Forms.GroupBox();
            this.tabPage_Shopout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_photoPreview = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_preview = new AForge.Controls.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_CamKa = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage_Shopin.SuspendLayout();
            this.panel_shopin.SuspendLayout();
            this.tableLayoutPanel_Shopin.SuspendLayout();
            this.tableLayoutPanel_shopin_photo.SuspendLayout();
            this.panel_videoPlayer.SuspendLayout();
            this.groupBox_videoPlayer.SuspendLayout();
            this.tableLayoutPanel_videoPlayer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_photoPreview.SuspendLayout();
            this.groupBox_photoPreview.SuspendLayout();
            this.panel_shopin_detail.SuspendLayout();
            this.tableLayoutPanel_detail.SuspendLayout();
            this.tableLayoutPanel_photoPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("宋体", 14F);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(981, 612);
            this.panelMain.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage_Shopin);
            this.tabControlMain.Controls.Add(this.tabPage_Shopout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(981, 612);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage_Shopin
            // 
            this.tabPage_Shopin.Controls.Add(this.panel_shopin);
            this.tabPage_Shopin.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Shopin.Name = "tabPage_Shopin";
            this.tabPage_Shopin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Shopin.Size = new System.Drawing.Size(973, 579);
            this.tabPage_Shopin.TabIndex = 0;
            this.tabPage_Shopin.Text = "收货";
            this.tabPage_Shopin.UseVisualStyleBackColor = true;
            this.tabPage_Shopin.Enter += new System.EventHandler(this.tabPage_Shopin_Enter);
            this.tabPage_Shopin.Leave += new System.EventHandler(this.tabPage_Shopin_Leave);
            // 
            // panel_shopin
            // 
            this.panel_shopin.Controls.Add(this.tableLayoutPanel_Shopin);
            this.panel_shopin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_shopin.Location = new System.Drawing.Point(3, 3);
            this.panel_shopin.Name = "panel_shopin";
            this.panel_shopin.Size = new System.Drawing.Size(967, 573);
            this.panel_shopin.TabIndex = 0;
            // 
            // tableLayoutPanel_Shopin
            // 
            this.tableLayoutPanel_Shopin.ColumnCount = 2;
            this.tableLayoutPanel_Shopin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Shopin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Shopin.Controls.Add(this.tableLayoutPanel_shopin_photo, 0, 0);
            this.tableLayoutPanel_Shopin.Controls.Add(this.panel_shopin_detail, 0, 1);
            this.tableLayoutPanel_Shopin.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel_Shopin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Shopin.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Shopin.Name = "tableLayoutPanel_Shopin";
            this.tableLayoutPanel_Shopin.RowCount = 2;
            this.tableLayoutPanel_Shopin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel_Shopin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Shopin.Size = new System.Drawing.Size(967, 573);
            this.tableLayoutPanel_Shopin.TabIndex = 0;
            // 
            // tableLayoutPanel_shopin_photo
            // 
            this.tableLayoutPanel_shopin_photo.ColumnCount = 2;
            this.tableLayoutPanel_shopin_photo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_shopin_photo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_shopin_photo.Controls.Add(this.panel_videoPlayer, 0, 0);
            this.tableLayoutPanel_shopin_photo.Controls.Add(this.panel_photoPreview, 1, 0);
            this.tableLayoutPanel_shopin_photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_shopin_photo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_shopin_photo.Name = "tableLayoutPanel_shopin_photo";
            this.tableLayoutPanel_shopin_photo.RowCount = 1;
            this.tableLayoutPanel_shopin_photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_shopin_photo.Size = new System.Drawing.Size(861, 400);
            this.tableLayoutPanel_shopin_photo.TabIndex = 0;
            // 
            // panel_videoPlayer
            // 
            this.panel_videoPlayer.Controls.Add(this.groupBox_videoPlayer);
            this.panel_videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_videoPlayer.Location = new System.Drawing.Point(3, 3);
            this.panel_videoPlayer.Name = "panel_videoPlayer";
            this.panel_videoPlayer.Size = new System.Drawing.Size(424, 394);
            this.panel_videoPlayer.TabIndex = 0;
            // 
            // groupBox_videoPlayer
            // 
            this.groupBox_videoPlayer.Controls.Add(this.tableLayoutPanel_videoPlayer);
            this.groupBox_videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.groupBox_videoPlayer.Name = "groupBox_videoPlayer";
            this.groupBox_videoPlayer.Size = new System.Drawing.Size(424, 394);
            this.groupBox_videoPlayer.TabIndex = 0;
            this.groupBox_videoPlayer.TabStop = false;
            this.groupBox_videoPlayer.Text = "拍照摄像头";
            // 
            // tableLayoutPanel_videoPlayer
            // 
            this.tableLayoutPanel_videoPlayer.ColumnCount = 1;
            this.tableLayoutPanel_videoPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_videoPlayer.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_videoPlayer.Controls.Add(this.videoPlayer_shopin, 0, 1);
            this.tableLayoutPanel_videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_videoPlayer.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel_videoPlayer.Name = "tableLayoutPanel_videoPlayer";
            this.tableLayoutPanel_videoPlayer.RowCount = 2;
            this.tableLayoutPanel_videoPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_videoPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_videoPlayer.Size = new System.Drawing.Size(418, 366);
            this.tableLayoutPanel_videoPlayer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_videoPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 44);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_videoPlayer
            // 
            this.comboBox_videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_videoPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_videoPlayer.FormattingEnabled = true;
            this.comboBox_videoPlayer.Location = new System.Drawing.Point(39, 9);
            this.comboBox_videoPlayer.Name = "comboBox_videoPlayer";
            this.comboBox_videoPlayer.Size = new System.Drawing.Size(323, 27);
            this.comboBox_videoPlayer.TabIndex = 0;
            // 
            // videoPlayer_shopin
            // 
            this.videoPlayer_shopin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer_shopin.Location = new System.Drawing.Point(3, 53);
            this.videoPlayer_shopin.Name = "videoPlayer_shopin";
            this.videoPlayer_shopin.Size = new System.Drawing.Size(412, 310);
            this.videoPlayer_shopin.TabIndex = 1;
            this.videoPlayer_shopin.Text = "VideoPlayer";
            this.videoPlayer_shopin.VideoSource = null;
            // 
            // panel_photoPreview
            // 
            this.panel_photoPreview.Controls.Add(this.groupBox_photoPreview);
            this.panel_photoPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_photoPreview.Location = new System.Drawing.Point(433, 3);
            this.panel_photoPreview.Name = "panel_photoPreview";
            this.panel_photoPreview.Size = new System.Drawing.Size(425, 394);
            this.panel_photoPreview.TabIndex = 1;
            // 
            // groupBox_photoPreview
            // 
            this.groupBox_photoPreview.Controls.Add(this.tableLayoutPanel_photoPreview);
            this.groupBox_photoPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_photoPreview.Location = new System.Drawing.Point(0, 0);
            this.groupBox_photoPreview.Name = "groupBox_photoPreview";
            this.groupBox_photoPreview.Size = new System.Drawing.Size(425, 394);
            this.groupBox_photoPreview.TabIndex = 0;
            this.groupBox_photoPreview.TabStop = false;
            this.groupBox_photoPreview.Text = "照片预览";
            // 
            // panel_shopin_detail
            // 
            this.panel_shopin_detail.Controls.Add(this.tableLayoutPanel_detail);
            this.panel_shopin_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_shopin_detail.Location = new System.Drawing.Point(3, 409);
            this.panel_shopin_detail.Name = "panel_shopin_detail";
            this.panel_shopin_detail.Size = new System.Drawing.Size(861, 161);
            this.panel_shopin_detail.TabIndex = 1;
            // 
            // tableLayoutPanel_detail
            // 
            this.tableLayoutPanel_detail.ColumnCount = 2;
            this.tableLayoutPanel_detail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_detail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_detail.Controls.Add(this.groupBox_weight, 0, 0);
            this.tableLayoutPanel_detail.Controls.Add(this.groupBox_notes, 1, 0);
            this.tableLayoutPanel_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_detail.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_detail.Name = "tableLayoutPanel_detail";
            this.tableLayoutPanel_detail.RowCount = 1;
            this.tableLayoutPanel_detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_detail.Size = new System.Drawing.Size(861, 161);
            this.tableLayoutPanel_detail.TabIndex = 0;
            // 
            // groupBox_weight
            // 
            this.groupBox_weight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_weight.Location = new System.Drawing.Point(3, 3);
            this.groupBox_weight.Name = "groupBox_weight";
            this.groupBox_weight.Size = new System.Drawing.Size(424, 155);
            this.groupBox_weight.TabIndex = 0;
            this.groupBox_weight.TabStop = false;
            this.groupBox_weight.Text = "称重";
            // 
            // groupBox_notes
            // 
            this.groupBox_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_notes.Location = new System.Drawing.Point(433, 3);
            this.groupBox_notes.Name = "groupBox_notes";
            this.groupBox_notes.Size = new System.Drawing.Size(425, 155);
            this.groupBox_notes.TabIndex = 1;
            this.groupBox_notes.TabStop = false;
            this.groupBox_notes.Text = "备注";
            // 
            // tabPage_Shopout
            // 
            this.tabPage_Shopout.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Shopout.Name = "tabPage_Shopout";
            this.tabPage_Shopout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Shopout.Size = new System.Drawing.Size(973, 579);
            this.tabPage_Shopout.TabIndex = 1;
            this.tabPage_Shopout.Text = "发货";
            this.tabPage_Shopout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_photoPreview
            // 
            this.tableLayoutPanel_photoPreview.ColumnCount = 1;
            this.tableLayoutPanel_photoPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_photoPreview.Controls.Add(this.pictureBox_preview, 0, 1);
            this.tableLayoutPanel_photoPreview.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel_photoPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_photoPreview.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel_photoPreview.Name = "tableLayoutPanel_photoPreview";
            this.tableLayoutPanel_photoPreview.RowCount = 2;
            this.tableLayoutPanel_photoPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_photoPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_photoPreview.Size = new System.Drawing.Size(419, 366);
            this.tableLayoutPanel_photoPreview.TabIndex = 0;
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_preview.Image = null;
            this.pictureBox_preview.Location = new System.Drawing.Point(3, 53);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(413, 310);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_preview.TabIndex = 0;
            this.pictureBox_preview.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 44);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "点击右侧的拍照按钮，预览照片";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_CamKa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(870, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 400);
            this.panel3.TabIndex = 2;
            // 
            // btn_CamKa
            // 
            this.btn_CamKa.Location = new System.Drawing.Point(10, 316);
            this.btn_CamKa.Name = "btn_CamKa";
            this.btn_CamKa.Size = new System.Drawing.Size(75, 59);
            this.btn_CamKa.TabIndex = 0;
            this.btn_CamKa.Text = "拍照";
            this.btn_CamKa.UseVisualStyleBackColor = true;
            this.btn_CamKa.Click += new System.EventHandler(this.btn_CamKa_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 612);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "润无声珠宝";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_Shopin.ResumeLayout(false);
            this.panel_shopin.ResumeLayout(false);
            this.tableLayoutPanel_Shopin.ResumeLayout(false);
            this.tableLayoutPanel_shopin_photo.ResumeLayout(false);
            this.panel_videoPlayer.ResumeLayout(false);
            this.groupBox_videoPlayer.ResumeLayout(false);
            this.tableLayoutPanel_videoPlayer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_photoPreview.ResumeLayout(false);
            this.groupBox_photoPreview.ResumeLayout(false);
            this.panel_shopin_detail.ResumeLayout(false);
            this.tableLayoutPanel_detail.ResumeLayout(false);
            this.tableLayoutPanel_photoPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_Shopin;
        private System.Windows.Forms.TabPage tabPage_Shopout;
        private System.Windows.Forms.Panel panel_shopin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Shopin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_shopin_photo;
        private System.Windows.Forms.Panel panel_videoPlayer;
        private System.Windows.Forms.Panel panel_photoPreview;
        private System.Windows.Forms.GroupBox groupBox_videoPlayer;
        private System.Windows.Forms.GroupBox groupBox_photoPreview;
        private System.Windows.Forms.Panel panel_shopin_detail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_detail;
        private System.Windows.Forms.GroupBox groupBox_weight;
        private System.Windows.Forms.GroupBox groupBox_notes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_videoPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_videoPlayer;
        private AForge.Controls.VideoSourcePlayer videoPlayer_shopin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_photoPreview;
        private AForge.Controls.PictureBox pictureBox_preview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_CamKa;
    }
}

