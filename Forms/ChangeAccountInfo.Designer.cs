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
            this.NewFieldInput = new System.Windows.Forms.TextBox();
            this.RetypePasswordInput = new System.Windows.Forms.TextBox();
            this.NewFieldName = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98265F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.01736F));
            this.TableLayout.Controls.Add(this.PasswordTitle, 0, 1);
            this.TableLayout.Controls.Add(this.NewFieldInput, 1, 0);
            this.TableLayout.Controls.Add(this.RetypePasswordInput, 1, 1);
            this.TableLayout.Controls.Add(this.NewFieldName, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayout.Location = new System.Drawing.Point(3, 3);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 2;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Size = new System.Drawing.Size(461, 59);
            this.TableLayout.TabIndex = 0;
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTitle.Location = new System.Drawing.Point(3, 29);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(123, 30);
            this.PasswordTitle.TabIndex = 1;
            this.PasswordTitle.Text = "Retype password";
            this.PasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewFieldInput
            // 
            this.NewFieldInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewFieldInput.Location = new System.Drawing.Point(132, 4);
            this.NewFieldInput.Name = "NewFieldInput";
            this.NewFieldInput.Size = new System.Drawing.Size(326, 22);
            this.NewFieldInput.TabIndex = 2;
            // 
            // RetypePasswordInput
            // 
            this.RetypePasswordInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RetypePasswordInput.Location = new System.Drawing.Point(132, 34);
            this.RetypePasswordInput.Name = "RetypePasswordInput";
            this.RetypePasswordInput.Size = new System.Drawing.Size(326, 22);
            this.RetypePasswordInput.TabIndex = 3;
            // 
            // NewFieldName
            // 
            this.NewFieldName.AutoSize = true;
            this.NewFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewFieldName.Location = new System.Drawing.Point(3, 0);
            this.NewFieldName.Name = "NewFieldName";
            this.NewFieldName.Size = new System.Drawing.Size(123, 29);
            this.NewFieldName.TabIndex = 0;
            this.NewFieldName.Text = "New Field";
            this.NewFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply.Location = new System.Drawing.Point(0, 65);
            this.Apply.Margin = new System.Windows.Forms.Padding(0);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(461, 31);
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
        private System.Windows.Forms.TextBox NewFieldInput;
        private System.Windows.Forms.TextBox RetypePasswordInput;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}