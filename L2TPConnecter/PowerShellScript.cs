namespace L2TPConnecter
{
    public static class PowerShellScript
    {
        private const string prefix = @"vpn_";

        public static string GetConnectScript(VpnSettingModel model)
        {
            return $@"# VPN�ڑ���
                    $vpnName = '{prefix + model.VpnName}'
                    $serverAddress = '{model.ServerAddress}'

                    # VPN�ݒ�̒ǉ�
                    Add-VpnConnection -Name $vpnName `
                        -ServerAddress $serverAddress `
                        -TunnelType L2tp `
                        -L2tpPsk '{model.PresharedKey}' `
                        -AuthenticationMethod {model.AuthenticationMethod} `
                        -EncryptionLevel Required `
                        -Force

                    # VPN�ڑ��̎��s
                    rasdial $vpnName '{model.Username}' '{model.Password}'
                    ";
        }

        public static string GetDisconnectScript(VpnSettingModel model)
        {
            return $@"# VPN�ڑ���
                        $vpnName = '{prefix + model.VpnName}'

                        # �ڑ���ؒf
                        rasdial $vpnName /disconnect 

                        # VPN�v���t�@�C���̍폜
                        Remove-VpnConnection -Name $vpnName -Force -PassThru
                        ";
        }

        public static string GetStatusScript(VpnSettingModel model)
        {
            return $@"
                    $vpn = Get-VpnConnection -Name '{prefix + model.VpnName}'
                    if ($vpn.ConnectionStatus -eq 'Connected') {{ 'Connected' }} else {{ 'Disconnected' }}
                    ";
        }
    }
}