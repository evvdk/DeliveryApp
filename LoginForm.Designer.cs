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
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Message = new System.Windows.Forms.Label();
            this.CloseWindowButton = new DeliveryApp.CustomButton();
            this.Register = new DeliveryApp.CustomButton();
            this.AuthButton = new DeliveryApp.CustomButton();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(0, 70);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(4);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(300, 28);
            this.LoginInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(0, 106);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(300, 28);
            this.PasswordInput.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.Message);
            this.LoginPanel.Controls.Add(this.LoginInput);
            this.LoginPanel.Controls.Add(this.Register);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Controls.Add(this.AuthButton);
            this.LoginPanel.Location = new System.Drawing.Point(50, 50);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(300, 300);
            this.LoginPanel.TabIndex = 4;
            this.LoginPanel.Visible = false;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(90, 44);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(128, 22);
            this.Message.TabIndex = 4;
            this.Message.Text = "Base Message";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Message.Visible = false;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackColor = System.Drawing.Color.Red;
            this.CloseWindowButton.BorderRadius = 7;
            this.CloseWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindowButton.FlatAppearance.BorderSize = 0;
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.ForeColor = System.Drawing.Color.White;
            this.CloseWindowButton.Location = new System.Drawing.Point(374, 8);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(16, 16);
            this.CloseWindowButton.TabIndex = 5;
            this.CloseWindowButton.UseVisualStyleBackColor = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Register.BorderRadius = 15;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(0, 182);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(300, 32);
            this.Register.TabIndex = 3;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AuthButton.BorderRadius = 15;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(0, 142);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(4);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(300, 32);
            this.AuthButton.TabIndex = 2;
            this.AuthButton.Text = "Auth";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Panel LoginPanel;
        private Label Message;
        private CustomButton Register;
        private CustomButton CloseWindowButton;
        private CustomButton AuthButton;
    }
}

