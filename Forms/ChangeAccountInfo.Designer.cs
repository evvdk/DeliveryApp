namespace DeliveryApp.Forms
{
    partial class ChangeAccountInfo
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
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.NewFieldInput = new DeliveryApp.CustomTextBox();
            this.RetypePasswordInput = new DeliveryApp.CustomTextBox();
            this.NewFieldName = new System.Windows.Forms.Label();
            this.Apply = new DeliveryApp.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.87773F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.12227F));
            this.TableLayout.Controls.Add(this.PasswordTitle, 0, 1);
            this.TableLayout.Controls.Add(this.NewFieldInput, 1, 0);
            this.TableLayout.Controls.Add(this.RetypePasswordInput, 1, 1);
            this.TableLayout.Controls.Add(this.NewFieldName, 0, 0);
            this.TableLayout.Location = new System.Drawing.Point(3, 3);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 2;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Size = new System.Drawing.Size(458, 59);
            this.TableLayout.TabIndex = 0;
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.PasswordTitle.Location = new System.Drawing.Point(3, 29);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(140, 30);
            this.PasswordTitle.TabIndex = 1;
            this.PasswordTitle.Text = "Retype password";
            this.PasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewFieldInput
            // 
            this.NewFieldInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFieldInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewFieldInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewFieldInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.NewFieldInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NewFieldInput.Location = new System.Drawing.Point(146, 1);
            this.NewFieldInput.Margin = new System.Windows.Forms.Padding(0);
            this.NewFieldInput.Name = "NewFieldInput";
            this.NewFieldInput.Size = new System.Drawing.Size(312, 26);
            this.NewFieldInput.TabIndex = 2;
            // 
            // RetypePasswordInput
            // 
            this.RetypePasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RetypePasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RetypePasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetypePasswordInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.RetypePasswordInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RetypePasswordInput.Location = new System.Drawing.Point(146, 31);
            this.RetypePasswordInput.Margin = new System.Windows.Forms.Padding(0);
            this.RetypePasswordInput.Name = "RetypePasswordInput";
            this.RetypePasswordInput.Size = new System.Drawing.Size(312, 26);
            this.RetypePasswordInput.TabIndex = 3;
            // 
            // NewFieldName
            // 
            this.NewFieldName.AutoSize = true;
            this.NewFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.NewFieldName.Location = new System.Drawing.Point(3, 0);
            this.NewFieldName.Name = "NewFieldName";
            this.NewFieldName.Size = new System.Drawing.Size(140, 29);
            this.NewFieldName.TabIndex = 0;
            this.NewFieldName.Text = "New Field";
            this.NewFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Apply.BorderRadius = 5;
            this.Apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(0, 65);
            this.Apply.Margin = new System.Windows.Forms.Padding(0);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(461, 39);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TableLayout);
            this.flowLayoutPanel1.Controls.Add(this.Apply);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 107);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ChangeAccountInfo
            // 
            this.AcceptButton = this.Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 107);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeAccountInfo";
            this.Text = "ChangeAccountInfo";
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Label NewFieldName;
        private System.Windows.Forms.Label PasswordTitle;
        private CustomTextBox NewFieldInput;
        private CustomTextBox RetypePasswordInput;
        private CustomButton Apply;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}