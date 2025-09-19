namespace VPNClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSettingButton = new System.Windows.Forms.Button();
            this.deleteSettingButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.addSettingButton = new System.Windows.Forms.Button();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpnNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusColumn,
            this.vpnNameColumn,
            this.serverAddressColumn});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.editSettingButton);
            this.panel1.Controls.Add(this.deleteSettingButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.addSettingButton);
            this.panel1.Name = "panel1";
            // 
            // editSettingButton
            // 
            resources.ApplyResources(this.editSettingButton, "editSettingButton");
            this.editSettingButton.Name = "editSettingButton";
            this.editSettingButton.UseVisualStyleBackColor = true;
            this.editSettingButton.Click += new System.EventHandler(this.editSettingButton_Click);
            // 
            // deleteSettingButton
            // 
            resources.ApplyResources(this.deleteSettingButton, "deleteSettingButton");
            this.deleteSettingButton.Name = "deleteSettingButton";
            this.deleteSettingButton.UseVisualStyleBackColor = true;
            this.deleteSettingButton.Click += new System.EventHandler(this.deleteSettingButton_Click);
            // 
            // connectButton
            // 
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // addSettingButton
            // 
            resources.ApplyResources(this.addSettingButton, "addSettingButton");
            this.addSettingButton.Name = "addSettingButton";
            this.addSettingButton.UseVisualStyleBackColor = true;
            this.addSettingButton.Click += new System.EventHandler(this.addSettingButton_Click);
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.statusColumn.DataPropertyName = "IsConnected";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.statusColumn, "statusColumn");
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // vpnNameColumn
            // 
            this.vpnNameColumn.DataPropertyName = "VpnName";
            resources.ApplyResources(this.vpnNameColumn, "vpnNameColumn");
            this.vpnNameColumn.Name = "vpnNameColumn";
            this.vpnNameColumn.ReadOnly = true;
            // 
            // serverAddressColumn
            // 
            this.serverAddressColumn.DataPropertyName = "ServerAddress";
            resources.ApplyResources(this.serverAddressColumn, "serverAddressColumn");
            this.serverAddressColumn.Name = "serverAddressColumn";
            this.serverAddressColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addSettingButton;
        private System.Windows.Forms.Button editSettingButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button deleteSettingButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpnNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverAddressColumn;
    }
}

