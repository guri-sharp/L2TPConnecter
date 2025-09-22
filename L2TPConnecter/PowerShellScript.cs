namespace L2TPConnecter
{
    public static class PowerShellScript
    {
        private const string prefix = @"vpn_";

        public static string GetConnectScript(VpnSettingModel model)
        {
            return $@"# VPN接続名
                    $vpnName = '{prefix + model.VpnName}'
                    $serverAddress = '{model.ServerAddress}'

                    # VPN設定の追加
                    Add-VpnConnection -Name $vpnName `
                        -ServerAddress $serverAddress `
                        -TunnelType L2tp `
                        -L2tpPsk '{model.PresharedKey}' `
                        -AuthenticationMethod {model.AuthenticationMethod} `
                        -EncryptionLevel Required `
                        -Force

                    # VPN接続の実行
                    rasdial $vpnName '{model.Username}' '{model.Password}'
                    ";
        }

        public static string GetDisconnectScript(VpnSettingModel model)
        {
            return $@"# VPN接続名
                        $vpnName = '{prefix + model.VpnName}'

                        # 接続を切断
                        rasdial $vpnName /disconnect 

                        # VPNプロファイルの削除
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