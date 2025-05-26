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
            this.Apply = new System.Windows.Forms.Button();
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
            // Apply
            // 
            this.Apply.Dock = System.Windows.Forms.DockStyle.Top;
            this.Apply.Location = new System.Drawing.Point(0, 268);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(722, 27);
            this.Apply.TabIndex = 0;
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // AddressChooser
            // 
            this.AcceptButton = this.Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 303);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.FlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddressChooser";
            this.Text = "Choose Address";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel FlowLayout;
        private Button Apply;
    }
}