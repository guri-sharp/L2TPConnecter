using System;
using System.Windows.Forms;

namespace L2TPConnecter
{
    public partial class SettingForm : Form
    {
        private VpnSettingModel settings = new VpnSettingModel();
        public VpnSettingModel Settings { get => settings; set => settings = value; }

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            authenticationMethodComboBox.Items.AddRange( "Pap,Chap,MSChapv2,Eap,MachineCertificate".Split(','));

            vpnNameTextBox.DataBindings.Add(nameof(vpnNameTextBox.Text), Settings, nameof(Settings.VpnName));
            serverAddressTextBox.DataBindings.Add(nameof(serverAddressTextBox.Text), Settings, nameof(Settings.ServerAddress));
            presharedKeyTextBox.DataBindings.Add(nameof(presharedKeyTextBox.Text), Settings, nameof(Settings.PresharedKey));
            usernameTextBox.DataBindings.Add(nameof(usernameTextBox.Text), Settings, nameof(Settings.Username));
            passwordTextBox.DataBindings.Add(nameof(passwordTextBox.Text), Settings, nameof(Settings.Password));
            authenticationMethodComboBox.DataBindings.Add(
                nameof(authenticationMethodComboBox.SelectedItem),
                Settings,
                nameof(Settings.AuthenticationMethod),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
