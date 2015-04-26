namespace LoudMessaging
{
    partial class Messenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portSelector = new System.Windows.Forms.NumericUpDown();
            this.hostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.SteelBlue;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButton.Location = new System.Drawing.Point(293, 50);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(82, 20);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.LightBlue;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Location = new System.Drawing.Point(12, 50);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(275, 20);
            this.messageBox.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.SlateGray;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectButton.Location = new System.Drawing.Point(293, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(82, 20);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.Color.LightCyan;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipBox.Location = new System.Drawing.Point(12, 12);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(118, 20);
            this.ipBox.TabIndex = 1;
            this.ipBox.Text = "Address";
            // 
            // portSelector
            // 
            this.portSelector.BackColor = System.Drawing.Color.LightCyan;
            this.portSelector.Location = new System.Drawing.Point(134, 12);
            this.portSelector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(65, 20);
            this.portSelector.TabIndex = 2;
            this.portSelector.Value = new decimal(new int[] {
            2323,
            0,
            0,
            0});
            // 
            // hostButton
            // 
            this.hostButton.BackColor = System.Drawing.Color.SlateGray;
            this.hostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hostButton.Location = new System.Drawing.Point(205, 12);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(82, 20);
            this.hostButton.TabIndex = 0;
            this.hostButton.Text = "Host";
            this.hostButton.UseVisualStyleBackColor = false;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 82);
            this.Controls.Add(this.portSelector);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Messenger";
            this.ShowIcon = false;
            this.Text = "Loud Messenger";
            ((System.ComponentModel.ISupportInitialize)(this.portSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.NumericUpDown portSelector;
        private System.Windows.Forms.Button hostButton;
    }
}