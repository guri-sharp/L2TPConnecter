namespace VPNClient
{
    public static class PowerShellScript
    {
        public static string GetConnectScript(VpnSettingModel model)
        {
            return $@"# VPN接続名
                    $vpnName = '{model.VpnName}'
                    $serverAddress = '{model.ServerAddress}'

                    # VPN設定の追加
                    Add-VpnConnection -Name $vpnName `
                        -ServerAddress $serverAddress `
                        -TunnelType L2tp `
                        -L2tpPsk '{model.PresharedKey}' `
                        -AuthenticationMethod MSCHAPv2 `
                        -EncryptionLevel Required `
                        -Force

                    # VPN接続の実行
                    rasdial $vpnName '{model.Username}' '{model.Password}'
                    ";
        }

        public static string GetDisconnectScript(VpnSettingModel model)
        {
            return $@"# VPN接続名
                        $vpnName = '{model.VpnName}'

                        # 接続を切断
                        rasdial $vpnName /disconnect 

                        # VPNプロファイルの削除
                        Remove-VpnConnection -Name $vpnName -Force -PassThru
                        ";
        }

        public static string GetStatusScript(VpnSettingModel model)
        {
            return $@"
                    $vpn = Get-VpnConnection -Name '{model.VpnName}'
                    if ($vpn.ConnectionStatus -eq 'Connected') {{ 'Connected' }} else {{ 'Disconnected' }}
                    ";
        }
    }
}