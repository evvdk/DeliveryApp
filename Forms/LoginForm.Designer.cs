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
            this.RegLogin = new System.Windows.Forms.Label();
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
            this.LoginRegistration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.PasswordInput.ForeColor = System.Drawing.SystemColors.Window;
            this.PasswordInput.Location = new System.Drawing.Point(4, 142);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(355, 26);
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
            this.AuthButton.Location = new System.Drawing.Point(116, 182);
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
            this.PasswordLabel.Location = new System.Drawing.Point(102, 111);
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
            this.LoginLable.Location = new System.Drawing.Point(124, 50);
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
            this.LoginInput.ForeColor = System.Drawing.Color.White;
            this.LoginInput.Location = new System.Drawing.Point(4, 81);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(4);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(355, 26);
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
            this.LoginMessage.Size = new System.Drawing.Size(126, 23);
            this.LoginMessage.TabIndex = 4;
            this.LoginMessage.Text = "Base Message";
            this.LoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginMessage.Visible = false;
            // 
            // RegLogin
            // 
            this.RegLogin.AutoSize = true;
            this.RegLogin.Location = new System.Drawing.Point(3, 27);
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.Size = new System.Drawing.Size(96, 22);
            this.RegLogin.TabIndex = 8;
            this.RegLogin.Text = "Enter login";
            // 
            // Registrate
            // 
            this.Registrate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Registrate.BorderRadius = 15;
            this.Registrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Registrate.ForeColor = System.Drawing.Color.White;
            this.Registrate.Location = new System.Drawing.Point(3, 300);
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
            this.EmailRegistration.Location = new System.Drawing.Point(3, 268);
            this.EmailRegistration.Name = "EmailRegistration";
            this.EmailRegistration.Size = new System.Drawing.Size(294, 26);
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
            this.PhoneRegistration.Location = new System.Drawing.Point(3, 214);
            this.PhoneRegistration.Name = "PhoneRegistration";
            this.PhoneRegistration.Size = new System.Drawing.Size(293, 26);
            this.PhoneRegistration.TabIndex = 4;
            // 
            // NameRegistration
            // 
            this.NameRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.NameRegistration.Location = new System.Drawing.Point(3, 160);
            this.NameRegistration.Name = "NameRegistration";
            this.NameRegistration.Size = new System.Drawing.Size(293, 26);
            this.NameRegistration.TabIndex = 3;
            // 
            // PasswordRegistration
            // 
            this.PasswordRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.PasswordRegistration.Location = new System.Drawing.Point(3, 106);
            this.PasswordRegistration.Name = "PasswordRegistration";
            this.PasswordRegistration.PasswordChar = '*';
            this.PasswordRegistration.Size = new System.Drawing.Size(294, 26);
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
            this.LoginPanel.Size = new System.Drawing.Size(366, 386);
            this.LoginPanel.TabIndex = 10;
            // 
            // LoginButtons
            // 
            this.LoginButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginButtons.AutoSize = true;
            this.LoginButtons.Location = new System.Drawing.Point(181, 175);
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
            this.TabsControl.Size = new System.Drawing.Size(400, 400);
            this.TabsControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabsControl.TabIndex = 11;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.LoginPanel);
            this.LoginPage.Location = new System.Drawing.Point(24, 4);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(372, 392);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RegistrationPage.Controls.Add(this.flowLayoutPanel1);
            this.RegistrationPage.Location = new System.Drawing.Point(24, 4);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegistrationPage.Size = new System.Drawing.Size(372, 392);
            this.RegistrationPage.TabIndex = 1;
            this.RegistrationPage.Text = "Register";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.RegistrationLabel);
            this.flowLayoutPanel1.Controls.Add(this.RegLogin);
            this.flowLayoutPanel1.Controls.Add(this.LoginRegistration);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.PasswordRegistration);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.NameRegistration);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.PhoneRegistration);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.EmailRegistration);
            this.flowLayoutPanel1.Controls.Add(this.Registrate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 386);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // LoginRegistration
            // 
            this.LoginRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.LoginRegistration.Location = new System.Drawing.Point(3, 52);
            this.LoginRegistration.Name = "LoginRegistration";
            this.LoginRegistration.Size = new System.Drawing.Size(197, 26);
            this.LoginRegistration.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Email";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AuthButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.TabsControl);
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
        private Label RegLogin;
        private CustomButton AuthButton;
        private FlowLayoutPanel LoginPanel;
        private FlowLayoutPanel LoginButtons;
        private TabControl TabsControl;
        private TabPage LoginPage;
        private TabPage RegistrationPage;
        private CustomButton Registrate;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox LoginRegistration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

