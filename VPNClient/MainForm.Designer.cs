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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusColumn,
            this.vpnNameColumn,
            this.serverAddressColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.editSettingButton);
            this.panel1.Controls.Add(this.deleteSettingButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.addSettingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 40);
            this.panel1.TabIndex = 1;
            // 
            // editSettingButton
            // 
            this.editSettingButton.Location = new System.Drawing.Point(127, 7);
            this.editSettingButton.Name = "editSettingButton";
            this.editSettingButton.Size = new System.Drawing.Size(109, 30);
            this.editSettingButton.TabIndex = 0;
            this.editSettingButton.Text = "編集";
            this.editSettingButton.UseVisualStyleBackColor = true;
            this.editSettingButton.Click += new System.EventHandler(this.editSettingButton_Click);
            // 
            // deleteSettingButton
            // 
            this.deleteSettingButton.Location = new System.Drawing.Point(242, 7);
            this.deleteSettingButton.Name = "deleteSettingButton";
            this.deleteSettingButton.Size = new System.Drawing.Size(109, 30);
            this.deleteSettingButton.TabIndex = 0;
            this.deleteSettingButton.Text = "削除";
            this.deleteSettingButton.UseVisualStyleBackColor = true;
            this.deleteSettingButton.Click += new System.EventHandler(this.deleteSettingButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(514, 7);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(109, 30);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "接続/切断";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // addSettingButton
            // 
            this.addSettingButton.Location = new System.Drawing.Point(12, 7);
            this.addSettingButton.Name = "addSettingButton";
            this.addSettingButton.Size = new System.Drawing.Size(109, 30);
            this.addSettingButton.TabIndex = 0;
            this.addSettingButton.Text = "追加";
            this.addSettingButton.UseVisualStyleBackColor = true;
            this.addSettingButton.Click += new System.EventHandler(this.addSettingButton_Click);
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "IsConnected";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.statusColumn.HeaderText = "状態";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Width = 70;
            // 
            // vpnNameColumn
            // 
            this.vpnNameColumn.DataPropertyName = "VpnName";
            this.vpnNameColumn.HeaderText = "設定名";
            this.vpnNameColumn.Name = "vpnNameColumn";
            this.vpnNameColumn.ReadOnly = true;
            this.vpnNameColumn.Width = 250;
            // 
            // serverAddressColumn
            // 
            this.serverAddressColumn.DataPropertyName = "ServerAddress";
            this.serverAddressColumn.HeaderText = "ホスト名";
            this.serverAddressColumn.Name = "serverAddressColumn";
            this.serverAddressColumn.ReadOnly = true;
            this.serverAddressColumn.Width = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(635, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "VPN 接続ツール";
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

