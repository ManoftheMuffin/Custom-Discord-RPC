using System;
using System.Windows.Forms;
using DiscordRPC;

namespace Custom_Discord_RPC {
    public partial class DiscordRPC : Form {
        public DiscordRPC() {
            InitializeComponent();
        }
        public DiscordRpcClient client;

        private void SetAppID_Click(object sender, EventArgs e) {
            client = new DiscordRpcClient(ApplicationIDTextBox.Text);
            client.Initialize();
        }
        private void SetState_Click(object sender, EventArgs e) {
            client.SetPresence(new RichPresence() {
                Details = FirstLineTextBox.Text,
                State = SecondLineTextBox.Text,
                Assets = new Assets() {
                    LargeImageKey = LargeImageTextBox.Text,
                    LargeImageText = LargeImageTextTextBox.Text,
                    SmallImageKey = SmallImageTextBox.Text,
                    SmallImageText = SmallImageTextTextBox.Text
                    
                }
            });
        }
    }
}
