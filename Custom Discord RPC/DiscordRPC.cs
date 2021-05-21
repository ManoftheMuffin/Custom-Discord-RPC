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
            //773374140321103882
            client.Initialize();
        }
        private void SetState_Click(object sender, EventArgs e) {
            if (LargeImageTextBox.Text != null && FirstLineTextBox.Text != null && SecondLineTextBox.Text != null) {
                client.SetPresence(new RichPresence() {
                    Details = FirstLineTextBox.Text,
                    State = SecondLineTextBox.Text,
                    Assets = new Assets() {
                    LargeImageKey = LargeImageTextBox.Text,
                    //LargeImageText = "Lachee's Discord IPC Library",
                    //SmallImageKey = "large"
                    }
                });
            }
        }
    }
}
