
namespace Custom_Discord_RPC {
    partial class DiscordRPC {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLine = new System.Windows.Forms.Label();
            this.SecondLine = new System.Windows.Forms.Label();
            this.FirstLineTextBox = new System.Windows.Forms.TextBox();
            this.SecondLineTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationIDTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationID = new System.Windows.Forms.Label();
            this.SetAppID = new System.Windows.Forms.Button();
            this.LargeImage = new System.Windows.Forms.Label();
            this.LargeImageTextBox = new System.Windows.Forms.TextBox();
            this.SetState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // FirstLine
            // 
            this.FirstLine.AutoSize = true;
            this.FirstLine.Location = new System.Drawing.Point(12, 47);
            this.FirstLine.Name = "FirstLine";
            this.FirstLine.Size = new System.Drawing.Size(49, 13);
            this.FirstLine.TabIndex = 1;
            this.FirstLine.Text = "First Line";
            // 
            // SecondLine
            // 
            this.SecondLine.AutoSize = true;
            this.SecondLine.Location = new System.Drawing.Point(12, 85);
            this.SecondLine.Name = "SecondLine";
            this.SecondLine.Size = new System.Drawing.Size(67, 13);
            this.SecondLine.TabIndex = 2;
            this.SecondLine.Text = "Second Line";
            // 
            // FirstLineTextBox
            // 
            this.FirstLineTextBox.Location = new System.Drawing.Point(91, 40);
            this.FirstLineTextBox.Name = "FirstLineTextBox";
            this.FirstLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstLineTextBox.TabIndex = 3;
            // 
            // SecondLineTextBox
            // 
            this.SecondLineTextBox.Location = new System.Drawing.Point(91, 78);
            this.SecondLineTextBox.Name = "SecondLineTextBox";
            this.SecondLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondLineTextBox.TabIndex = 4;
            // 
            // ApplicationIDTextBox
            // 
            this.ApplicationIDTextBox.Location = new System.Drawing.Point(91, 3);
            this.ApplicationIDTextBox.Name = "ApplicationIDTextBox";
            this.ApplicationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApplicationIDTextBox.TabIndex = 6;
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSize = true;
            this.ApplicationID.Location = new System.Drawing.Point(12, 10);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(73, 13);
            this.ApplicationID.TabIndex = 7;
            this.ApplicationID.Text = "Application ID";
            // 
            // SetAppID
            // 
            this.SetAppID.Location = new System.Drawing.Point(207, 1);
            this.SetAppID.Name = "SetAppID";
            this.SetAppID.Size = new System.Drawing.Size(95, 23);
            this.SetAppID.TabIndex = 13;
            this.SetAppID.Text = "Set App ID";
            this.SetAppID.Click += new System.EventHandler(this.SetAppID_Click);
            // 
            // LargeImage
            // 
            this.LargeImage.AutoSize = true;
            this.LargeImage.Location = new System.Drawing.Point(12, 115);
            this.LargeImage.Name = "LargeImage";
            this.LargeImage.Size = new System.Drawing.Size(66, 13);
            this.LargeImage.TabIndex = 10;
            this.LargeImage.Text = "Large Image";
            // 
            // LargeImageTextBox
            // 
            this.LargeImageTextBox.Location = new System.Drawing.Point(91, 115);
            this.LargeImageTextBox.Name = "LargeImageTextBox";
            this.LargeImageTextBox.Size = new System.Drawing.Size(100, 20);
            this.LargeImageTextBox.TabIndex = 11;
            // 
            // SetState
            // 
            this.SetState.Location = new System.Drawing.Point(207, 110);
            this.SetState.Name = "SetState";
            this.SetState.Size = new System.Drawing.Size(95, 23);
            this.SetState.TabIndex = 12;
            this.SetState.Text = "Set State";
            this.SetState.UseVisualStyleBackColor = true;
            this.SetState.Click += new System.EventHandler(this.SetState_Click);
            // 
            // DiscordRPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 155);
            this.Controls.Add(this.SetState);
            this.Controls.Add(this.LargeImageTextBox);
            this.Controls.Add(this.LargeImage);
            this.Controls.Add(this.SetAppID);
            this.Controls.Add(this.ApplicationID);
            this.Controls.Add(this.ApplicationIDTextBox);
            this.Controls.Add(this.SecondLineTextBox);
            this.Controls.Add(this.FirstLineTextBox);
            this.Controls.Add(this.SecondLine);
            this.Controls.Add(this.FirstLine);
            this.Controls.Add(this.label1);
            this.Name = "DiscordRPC";
            this.ShowIcon = false;
            this.Text = "DiscordRPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstLine;
        private System.Windows.Forms.Label SecondLine;
        private System.Windows.Forms.TextBox FirstLineTextBox;
        private System.Windows.Forms.TextBox SecondLineTextBox;
        private System.Windows.Forms.TextBox ApplicationIDTextBox;
        private System.Windows.Forms.Label ApplicationID;
        private System.Windows.Forms.Button SetAppID;
        private System.Windows.Forms.Label LargeImage;
        private System.Windows.Forms.TextBox LargeImageTextBox;
        private System.Windows.Forms.Button SetState;
    }
}

