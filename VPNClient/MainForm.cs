using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPNClient
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();


        private List<VpnSettingModel> settings = new List<VpnSettingModel>();
        private BindingSource bindingSource = new BindingSource();


        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            settings = VpnSettingModel.LoadSettings("settings.json");
            var t = AllConnectionCheck(sender, e);

            dataGridView1.AutoGenerateColumns = false;

            bindingSource.DataSource = settings;
            dataGridView1.DataSource = bindingSource;

            timer.Tick += Timer_Tick;
            timer.Interval = 10000;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _ = AllConnectionCheck(sender, e);
        }

        private async Task AllConnectionCheck(object sender, EventArgs e)
        {
            foreach (var item in settings)
            {
                await ConnectionCheck(item);
            }

            bindingSource.ResetBindings(false);

        }

        private async Task ConnectionCheck(VpnSettingModel model)
        {
            var script = PowerShellScript.GetStatusScript(model);

            bool isConnected = false;

            await PowerShell.Run(script,
                output =>
                {
                    if (output.Contains("Connected"))
                        isConnected = true;
                },
                error =>
                {
                    // 必要ならログ出力やエラー処理
                });
            model.IsConnected = isConnected;
        }

        private void addSettingButton_Click(object sender, EventArgs e)
        {
            var frm = new SettingForm();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                settings.Add(frm.Settings);
                bindingSource.ResetBindings(false);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public async void DisconnectVpn(VpnSettingModel model)
        {

            var script = PowerShellScript.GetDisconnectScript(model);

            await PowerShell.Run(script,
                output => { /* Handle output if needed */ },
                error => { /* Handle error if needed */ });

            _ = ConnectionCheck(model);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            foreach (var model in settings)
            {
                if (model.IsConnected)
                {
                    DisconnectVpn(model);
                }

            }
            VpnSettingModel.SaveSettings(settings, "settings.json");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex].DataBoundItem as VpnSettingModel;
            if (row == null) return;

            if (e.ColumnIndex == statusColumn.Index)
            {
                if (row.IsConnected)
                {
                    e.Value = "接続中";
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(102, 205, 170); // ミントグリーン
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);    // ダークグレー
                    e.CellStyle.Font = new System.Drawing.Font(e.CellStyle.Font, System.Drawing.FontStyle.Bold);
                }
                else
                {
                    e.Value = "未接続";
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 182, 193); // ライトピンク
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(123, 36, 28);   // ブラウン
                    e.CellStyle.Font = new System.Drawing.Font(e.CellStyle.Font, System.Drawing.FontStyle.Italic);
                }
            }
        }

        private void editSettingButton_Click(object sender, EventArgs e)
        {
            var row = bindingSource.Current as VpnSettingModel;
            if (row == null) return;

            if (row.IsConnected) return;

            var newSetting = new VpnSettingModel();
            newSetting.CopyFrom(row);

            var frm = new SettingForm();
            frm.Settings = newSetting;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                row.CopyFrom(frm.Settings);
                bindingSource.ResetBindings(false);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var row = bindingSource.Current as VpnSettingModel;
            if (row == null) return;

            var dlg = new ConnectionDialog();
            dlg.VpnSetting = row;
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        private void deleteSettingButton_Click(object sender, EventArgs e)
        {
            var row = bindingSource.Current as VpnSettingModel;
            if (row == null) return;

            if (row.IsConnected) return;

            var result = MessageBox.Show(
                $"VPN設定「{row.VpnName}」を削除しますか？",
                "削除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            settings.Remove(row);
            bindingSource.ResetBindings(false);
        }
    }
}
