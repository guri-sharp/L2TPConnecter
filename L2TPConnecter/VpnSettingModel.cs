using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace L2TPConnecter
{
    public class VpnSettingModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string vpnName = "";
        private string serverAddress = "";
        private string presharedKey = "";
        private string username = "";
        private string password = "";
        private string authenticationMethod = "MSChapv2";
        private bool isConnected = false;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string VpnName
        {
            get => vpnName ?? "";
            set
            {
                if (vpnName != value)
                {
                    vpnName = value;
                    OnPropertyChanged(nameof(VpnName));
                }
            }
        }

        public string ServerAddress
        {
            get => serverAddress ?? "";
            set
            {
                if (serverAddress != value)
                {
                    serverAddress = value;
                    OnPropertyChanged(nameof(ServerAddress));
                }
            }
        }

        public string PresharedKey
        {
            get => presharedKey ?? "";
            set
            {
                if (presharedKey != value)
                {
                    presharedKey = value;
                    OnPropertyChanged(nameof(PresharedKey));
                }
            }
        }

        public string Username
        {
            get => username ?? "";
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get => password ?? "";
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public string AuthenticationMethod
        {
            get => authenticationMethod ?? "";
            set
            {
                if (authenticationMethod != value)
                {
                    authenticationMethod = value;
                    OnPropertyChanged(nameof(AuthenticationMethod));
                }
            }
        }

        [JsonIgnore]
        public bool IsConnected
        {
            get => isConnected;
            set
            {
                if (isConnected != value)
                {
                    isConnected = value;
                    OnPropertyChanged(nameof(IsConnected));
                }
            }
        }

        public void CopyFrom(VpnSettingModel source)
        {
            VpnName = source.VpnName;
            ServerAddress = source.ServerAddress;
            PresharedKey = source.PresharedKey;
            Username = source.Username;
            Password = source.Password;
        }


        public static List<VpnSettingModel> LoadSettings(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<VpnSettingModel>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<VpnSettingModel>>(json);
        }

        public static void SaveSettings(List<VpnSettingModel> settings, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(settings, options);
            File.WriteAllText(filePath, json);
        }
    }
}
