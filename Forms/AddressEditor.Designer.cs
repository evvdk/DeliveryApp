namespace DeliveryApp.Forms
{
    partial class AddressEditor
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DataTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.City_Label = new System.Windows.Forms.Label();
            this.CityField = new DeliveryApp.CustomTextBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.DistrictField = new DeliveryApp.CustomTextBox();
            this.StreetField = new DeliveryApp.CustomTextBox();
            this.BuildingField = new DeliveryApp.CustomTextBox();
            this.RoomField = new DeliveryApp.CustomTextBox();
            this.Apply = new DeliveryApp.CustomButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.DataTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.DataTableLayout);
            this.flowLayoutPanel1.Controls.Add(this.Apply);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 252);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DataTableLayout
            // 
            this.DataTableLayout.ColumnCount = 2;
            this.DataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.38045F));
            this.DataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.61955F));
            this.DataTableLayout.Controls.Add(this.City_Label, 0, 0);
            this.DataTableLayout.Controls.Add(this.CityField, 1, 0);
            this.DataTableLayout.Controls.Add(this.DistrictLabel, 0, 1);
            this.DataTableLayout.Controls.Add(this.StreetLabel, 0, 2);
            this.DataTableLayout.Controls.Add(this.BuildingLabel, 0, 3);
            this.DataTableLayout.Controls.Add(this.RoomLabel, 0, 4);
            this.DataTableLayout.Controls.Add(this.DistrictField, 1, 1);
            this.DataTableLayout.Controls.Add(this.StreetField, 1, 2);
            this.DataTableLayout.Controls.Add(this.BuildingField, 1, 3);
            this.DataTableLayout.Controls.Add(this.RoomField, 1, 4);
            this.DataTableLayout.Location = new System.Drawing.Point(3, 3);
            this.DataTableLayout.Name = "DataTableLayout";
            this.DataTableLayout.RowCount = 5;
            this.DataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DataTableLayout.Size = new System.Drawing.Size(618, 197);
            this.DataTableLayout.TabIndex = 0;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.City_Label.Location = new System.Drawing.Point(3, 0);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(95, 39);
            this.City_Label.TabIndex = 2;
            this.City_Label.Text = "City";
            this.City_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityField
            // 
            this.CityField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CityField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityField.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.CityField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CityField.Location = new System.Drawing.Point(101, 6);
            this.CityField.Margin = new System.Windows.Forms.Padding(0);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(517, 26);
            this.CityField.TabIndex = 3;
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistrictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DistrictLabel.Location = new System.Drawing.Point(3, 39);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(95, 39);
            this.DistrictLabel.TabIndex = 4;
            this.DistrictLabel.Text = "District";
            this.DistrictLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StreetLabel.Location = new System.Drawing.Point(3, 78);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(95, 39);
            this.StreetLabel.TabIndex = 5;
            this.StreetLabel.Text = "Street";
            this.StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BuildingLabel.Location = new System.Drawing.Point(3, 117);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(95, 39);
            this.BuildingLabel.TabIndex = 6;
            this.BuildingLabel.Text = "Building";
            this.BuildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RoomLabel.Location = new System.Drawing.Point(3, 156);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(95, 41);
            this.RoomLabel.TabIndex = 8;
            this.RoomLabel.Text = "Room";
            this.RoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DistrictField
            // 
            this.DistrictField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DistrictField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DistrictField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DistrictField.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.DistrictField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DistrictField.Location = new System.Drawing.Point(101, 45);
            this.DistrictField.Margin = new System.Windows.Forms.Padding(0);
            this.DistrictField.Name = "DistrictField";
            this.DistrictField.Size = new System.Drawing.Size(517, 26);
            this.DistrictField.TabIndex = 9;
            // 
            // StreetField
            // 
            this.StreetField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StreetField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreetField.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.StreetField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StreetField.Location = new System.Drawing.Point(101, 84);
            this.StreetField.Margin = new System.Windows.Forms.Padding(0);
            this.StreetField.Name = "StreetField";
            this.StreetField.Size = new System.Drawing.Size(517, 26);
            this.StreetField.TabIndex = 10;
            // 
            // BuildingField
            // 
            this.BuildingField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BuildingField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuildingField.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.BuildingField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BuildingField.Location = new System.Drawing.Point(101, 123);
            this.BuildingField.Margin = new System.Windows.Forms.Padding(0);
            this.BuildingField.Name = "BuildingField";
            this.BuildingField.Size = new System.Drawing.Size(517, 26);
            this.BuildingField.TabIndex = 11;
            // 
            // RoomField
            // 
            this.RoomField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RoomField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomField.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.RoomField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RoomField.Location = new System.Drawing.Point(101, 163);
            this.RoomField.Margin = new System.Windows.Forms.Padding(0);
            this.RoomField.Name = "RoomField";
            this.RoomField.Size = new System.Drawing.Size(517, 26);
            this.RoomField.TabIndex = 13;
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
            this.Apply.Location = new System.Drawing.Point(3, 206);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(618, 39);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // AddressEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 252);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddressEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressEditor";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.DataTableLayout.ResumeLayout(false);
            this.DataTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel DataTableLayout;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private CustomTextBox CityField;
        private System.Windows.Forms.Label RoomLabel;
        private CustomTextBox DistrictField;
        private CustomTextBox StreetField;
        private CustomTextBox BuildingField;
        private CustomTextBox RoomField;
        private CustomButton Apply;
    }
}