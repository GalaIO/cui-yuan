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
            this.tabPage_Shopout = new System.Windows.Forms.TabPage();
            this.panel_shopin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Shopin = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage_Shopin.SuspendLayout();
            this.panel_shopin.SuspendLayout();
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
            this.tableLayoutPanel_Shopin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Shopin.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Shopin.Name = "tableLayoutPanel_Shopin";
            this.tableLayoutPanel_Shopin.RowCount = 2;
            this.tableLayoutPanel_Shopin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel_Shopin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Shopin.Size = new System.Drawing.Size(967, 573);
            this.tableLayoutPanel_Shopin.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 612);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "润无声珠宝";
            this.panelMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_Shopin.ResumeLayout(false);
            this.panel_shopin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_Shopin;
        private System.Windows.Forms.TabPage tabPage_Shopout;
        private System.Windows.Forms.Panel panel_shopin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Shopin;
    }
}

