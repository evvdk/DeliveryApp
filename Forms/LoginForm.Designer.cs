using System.Windows.Forms;

namespace DeliveryApp
{
    partial class LoginForm
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
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.AuthButton = new DeliveryApp.CustomButton();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.LoginMessage = new System.Windows.Forms.Label();
            this.RegLoginLabel = new System.Windows.Forms.Label();
            this.Registrate = new DeliveryApp.CustomButton();
            this.EmailRegistration = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.PhoneRegistration = new System.Windows.Forms.TextBox();
            this.NameRegistration = new System.Windows.Forms.TextBox();
            this.PasswordRegistration = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LoginButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.RegistrationPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RegMessage = new System.Windows.Forms.Label();
            this.LoginRegistration = new System.Windows.Forms.TextBox();
            this.PasswordRegLabel = new System.Windows.Forms.Label();
            this.NameRegLabel = new System.Windows.Forms.Label();
            this.PhoneRegLabel = new System.Windows.Forms.Label();
            this.EmailRegLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.TabsControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegistrationPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.PasswordInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordInput.Location = new System.Drawing.Point(4, 142);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(415, 26);
            this.PasswordInput.TabIndex = 1;
            // 
            // AuthButton
            // 
            this.AuthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AuthButton.AutoSize = true;
            this.AuthButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AuthButton.BorderRadius = 15;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(146, 182);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(4);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(130, 40);
            this.AuthButton.TabIndex = 2;
            this.AuthButton.Text = "Auth";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(132, 111);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(158, 27);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Enter Password";
            // 
            // LoginLable
            // 
            this.LoginLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LoginLable.Location = new System.Drawing.Point(154, 50);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(115, 27);
            this.LoginLable.TabIndex = 6;
            this.LoginLable.Text = "Enter login";
            // 
            // LoginInput
            // 
            this.LoginInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LoginInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginInput.Location = new System.Drawing.Point(4, 81);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(4);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(415, 26);
            this.LoginInput.TabIndex = 0;
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LoginTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(65, 27);
            this.LoginTitleLabel.TabIndex = 5;
            this.LoginTitleLabel.Text = "Login";
            // 
            // LoginMessage
            // 
            this.LoginMessage.AllowDrop = true;
            this.LoginMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginMessage.AutoSize = true;
            this.LoginMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.LoginMessage.Location = new System.Drawing.Point(4, 27);
            this.LoginMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginMessage.Name = "LoginMessage";
            this.LoginMessage.Size = new System.Drawing.Size(48, 23);
            this.LoginMessage.TabIndex = 4;
            this.LoginMessage.Text = "Base";
            this.LoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegLoginLabel
            // 
            this.RegLoginLabel.AutoSize = true;
            this.RegLoginLabel.Location = new System.Drawing.Point(3, 49);
            this.RegLoginLabel.Name = "RegLoginLabel";
            this.RegLoginLabel.Size = new System.Drawing.Size(96, 22);
            this.RegLoginLabel.TabIndex = 8;
            this.RegLoginLabel.Text = "Enter login";
            // 
            // Registrate
            // 
            this.Registrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Registrate.AutoSize = true;
            this.Registrate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Registrate.BorderRadius = 15;
            this.Registrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Registrate.ForeColor = System.Drawing.Color.White;
            this.Registrate.Location = new System.Drawing.Point(147, 322);
            this.Registrate.Name = "Registrate";
            this.Registrate.Size = new System.Drawing.Size(126, 40);
            this.Registrate.TabIndex = 6;
            this.Registrate.Text = "Registrate";
            this.Registrate.UseVisualStyleBackColor = false;
            this.Registrate.Click += new System.EventHandler(this.Registrate_Click);
            // 
            // EmailRegistration
            // 
            this.EmailRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.EmailRegistration.Location = new System.Drawing.Point(3, 290);
            this.EmailRegistration.Name = "EmailRegistration";
            this.EmailRegistration.Size = new System.Drawing.Size(415, 26);
            this.EmailRegistration.TabIndex = 5;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.RegistrationLabel.Location = new System.Drawing.Point(3, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(126, 27);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.Text = "Registration";
            // 
            // PhoneRegistration
            // 
            this.PhoneRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.PhoneRegistration.Location = new System.Drawing.Point(3, 236);
            this.PhoneRegistration.Name = "PhoneRegistration";
            this.PhoneRegistration.Size = new System.Drawing.Size(415, 26);
            this.PhoneRegistration.TabIndex = 4;
            // 
            // NameRegistration
            // 
            this.NameRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.NameRegistration.Location = new System.Drawing.Point(3, 182);
            this.NameRegistration.Name = "NameRegistration";
            this.NameRegistration.Size = new System.Drawing.Size(415, 26);
            this.NameRegistration.TabIndex = 3;
            // 
            // PasswordRegistration
            // 
            this.PasswordRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.PasswordRegistration.Location = new System.Drawing.Point(3, 128);
            this.PasswordRegistration.Name = "PasswordRegistration";
            this.PasswordRegistration.PasswordChar = '*';
            this.PasswordRegistration.Size = new System.Drawing.Size(415, 26);
            this.PasswordRegistration.TabIndex = 2;
            // 
            // LoginPanel
            // 
            this.LoginPanel.AutoSize = true;
            this.LoginPanel.Controls.Add(this.LoginTitleLabel);
            this.LoginPanel.Controls.Add(this.LoginMessage);
            this.LoginPanel.Controls.Add(this.LoginLable);
            this.LoginPanel.Controls.Add(this.LoginInput);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Controls.Add(this.LoginButtons);
            this.LoginPanel.Controls.Add(this.AuthButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LoginPanel.Location = new System.Drawing.Point(3, 3);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(423, 389);
            this.LoginPanel.TabIndex = 10;
            // 
            // LoginButtons
            // 
            this.LoginButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginButtons.AutoSize = true;
            this.LoginButtons.Location = new System.Drawing.Point(211, 175);
            this.LoginButtons.Name = "LoginButtons";
            this.LoginButtons.Size = new System.Drawing.Size(0, 0);
            this.LoginButtons.TabIndex = 11;
            // 
            // TabsControl
            // 
            this.TabsControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabsControl.Controls.Add(this.LoginPage);
            this.TabsControl.Controls.Add(this.RegistrationPage);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.ItemSize = new System.Drawing.Size(0, 20);
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Multiline = true;
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(457, 403);
            this.TabsControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabsControl.TabIndex = 11;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.LoginPanel);
            this.LoginPage.Location = new System.Drawing.Point(24, 4);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(429, 395);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.BackColor = System.Drawing.SystemColors.Control;
            this.RegistrationPage.Controls.Add(this.flowLayoutPanel1);
            this.RegistrationPage.Location = new System.Drawing.Point(24, 4);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationPage.Size = new System.Drawing.Size(429, 395);
            this.RegistrationPage.TabIndex = 1;
            this.RegistrationPage.Text = "Register";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.RegistrationLabel);
            this.flowLayoutPanel1.Controls.Add(this.RegMessage);
            this.flowLayoutPanel1.Controls.Add(this.RegLoginLabel);
            this.flowLayoutPanel1.Controls.Add(this.LoginRegistration);
            this.flowLayoutPanel1.Controls.Add(this.PasswordRegLabel);
            this.flowLayoutPanel1.Controls.Add(this.PasswordRegistration);
            this.flowLayoutPanel1.Controls.Add(this.NameRegLabel);
            this.flowLayoutPanel1.Controls.Add(this.NameRegistration);
            this.flowLayoutPanel1.Controls.Add(this.PhoneRegLabel);
            this.flowLayoutPanel1.Controls.Add(this.PhoneRegistration);
            this.flowLayoutPanel1.Controls.Add(this.EmailRegLabel);
            this.flowLayoutPanel1.Controls.Add(this.EmailRegistration);
            this.flowLayoutPanel1.Controls.Add(this.Registrate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(423, 389);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // RegMessage
            // 
            this.RegMessage.AutoSize = true;
            this.RegMessage.Location = new System.Drawing.Point(3, 27);
            this.RegMessage.Name = "RegMessage";
            this.RegMessage.Size = new System.Drawing.Size(51, 22);
            this.RegMessage.TabIndex = 14;
            this.RegMessage.Text = "Base";
            // 
            // LoginRegistration
            // 
            this.LoginRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LoginRegistration.Location = new System.Drawing.Point(3, 74);
            this.LoginRegistration.Name = "LoginRegistration";
            this.LoginRegistration.Size = new System.Drawing.Size(415, 26);
            this.LoginRegistration.TabIndex = 9;
            // 
            // PasswordRegLabel
            // 
            this.PasswordRegLabel.AutoSize = true;
            this.PasswordRegLabel.Location = new System.Drawing.Point(3, 103);
            this.PasswordRegLabel.Name = "PasswordRegLabel";
            this.PasswordRegLabel.Size = new System.Drawing.Size(137, 22);
            this.PasswordRegLabel.TabIndex = 10;
            this.PasswordRegLabel.Text = "Enter Password";
            // 
            // NameRegLabel
            // 
            this.NameRegLabel.AutoSize = true;
            this.NameRegLabel.Location = new System.Drawing.Point(3, 157);
            this.NameRegLabel.Name = "NameRegLabel";
            this.NameRegLabel.Size = new System.Drawing.Size(105, 22);
            this.NameRegLabel.TabIndex = 11;
            this.NameRegLabel.Text = "Enter Name";
            // 
            // PhoneRegLabel
            // 
            this.PhoneRegLabel.AutoSize = true;
            this.PhoneRegLabel.Location = new System.Drawing.Point(3, 211);
            this.PhoneRegLabel.Name = "PhoneRegLabel";
            this.PhoneRegLabel.Size = new System.Drawing.Size(110, 22);
            this.PhoneRegLabel.TabIndex = 12;
            this.PhoneRegLabel.Text = "Enter Phone";
            // 
            // EmailRegLabel
            // 
            this.EmailRegLabel.AutoSize = true;
            this.EmailRegLabel.Location = new System.Drawing.Point(3, 265);
            this.EmailRegLabel.Name = "EmailRegLabel";
            this.EmailRegLabel.Size = new System.Drawing.Size(102, 22);
            this.EmailRegLabel.TabIndex = 13;
            this.EmailRegLabel.Text = "Enter Email";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AuthButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(457, 403);
            this.Controls.Add(this.TabsControl);
            this.FormClosed += new FormClosedEventHandler(this.LoginForm_Closed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.TabsControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegistrationPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordInput;
        private Label LoginMessage;
        private TextBox LoginInput;
        private Label RegistrationLabel;
        private TextBox PasswordRegistration;
        private TextBox PhoneRegistration;
        private TextBox NameRegistration;
        private TextBox EmailRegistration;
        private Label PasswordLabel;
        private Label LoginLable;
        private Label LoginTitleLabel;
        private Label RegLoginLabel;
        private CustomButton AuthButton;
        private FlowLayoutPanel LoginPanel;
        private FlowLayoutPanel LoginButtons;
        private TabControl TabsControl;
        private TabPage LoginPage;
        private TabPage RegistrationPage;
        private CustomButton Registrate;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox LoginRegistration;
        private Label PasswordRegLabel;
        private Label NameRegLabel;
        private Label PhoneRegLabel;
        private Label EmailRegLabel;
        private Label RegMessage;
    }
}

