using System.Windows.Forms;
namespace DeliveryApp.Forms
{
    partial class AddressChooser
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
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new DeliveryApp.CustomButton();
            this.Apply = new DeliveryApp.CustomButton();
            this.SuspendLayout();
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(722, 268);
            this.FlowLayout.TabIndex = 0;
            this.FlowLayout.WrapContents = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Add.BorderRadius = 5;
            this.Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(0, 268);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(722, 36);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить адрес";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddNewAddress);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Apply.BorderRadius = 5;
            this.Apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(0, 304);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(722, 35);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Сохранить";
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // AddressChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(722, 339);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddressChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите адрес";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel FlowLayout;
        private CustomButton Add;
        private CustomButton Apply;
    }
}