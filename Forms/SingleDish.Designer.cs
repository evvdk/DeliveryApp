namespace DeliveryApp.Forms
{
    partial class SingleDish
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
            this.DishFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DishName = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Panel();
            this.DishDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CostLabelValue = new System.Windows.Forms.Label();
            this.CalValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProducerName = new System.Windows.Forms.Label();
            this.IngridientsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new DeliveryApp.CustomButton();
            this.DishFlowLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DishFlowLayout
            // 
            this.DishFlowLayout.AutoScroll = true;
            this.DishFlowLayout.Controls.Add(this.tableLayoutPanel1);
            this.DishFlowLayout.Controls.Add(this.DishDescription);
            this.DishFlowLayout.Controls.Add(this.tableLayoutPanel2);
            this.DishFlowLayout.Controls.Add(this.IngridientsLabel);
            this.DishFlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.DishFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DishFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.DishFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DishFlowLayout.Name = "DishFlowLayout";
            this.DishFlowLayout.Size = new System.Drawing.Size(549, 412);
            this.DishFlowLayout.TabIndex = 0;
            this.DishFlowLayout.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.DishName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Image, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DishName
            // 
            this.DishName.AutoSize = true;
            this.DishName.Dock = System.Windows.Forms.DockStyle.Left;
            this.DishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DishName.Location = new System.Drawing.Point(3, 0);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(146, 144);
            this.DishName.TabIndex = 0;
            this.DishName.Text = "DishName";
            this.DishName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(332, 0);
            this.Image.Margin = new System.Windows.Forms.Padding(0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(200, 144);
            this.Image.TabIndex = 1;
            // 
            // DishDescription
            // 
            this.DishDescription.AutoSize = true;
            this.DishDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DishDescription.Location = new System.Drawing.Point(3, 144);
            this.DishDescription.Name = "DishDescription";
            this.DishDescription.Size = new System.Drawing.Size(109, 25);
            this.DishDescription.TabIndex = 3;
            this.DishDescription.Text = "Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.77273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.22727F));
            this.tableLayoutPanel2.Controls.Add(this.CostLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CostLabelValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CalValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProducerName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 169);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 66);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CostLabel.Location = new System.Drawing.Point(3, 22);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(53, 22);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostLabelValue
            // 
            this.CostLabelValue.AutoSize = true;
            this.CostLabelValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.CostLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabelValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CostLabelValue.Location = new System.Drawing.Point(112, 22);
            this.CostLabelValue.Name = "CostLabelValue";
            this.CostLabelValue.Size = new System.Drawing.Size(104, 22);
            this.CostLabelValue.TabIndex = 2;
            this.CostLabelValue.Text = "CostValue";
            this.CostLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalValue
            // 
            this.CalValue.AutoSize = true;
            this.CalValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.CalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalValue.Location = new System.Drawing.Point(112, 44);
            this.CalValue.Name = "CalValue";
            this.CalValue.Size = new System.Drawing.Size(93, 22);
            this.CalValue.TabIndex = 3;
            this.CalValue.Text = "CalValue";
            this.CalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Producer";
            // 
            // ProducerName
            // 
            this.ProducerName.AutoSize = true;
            this.ProducerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProducerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProducerName.Location = new System.Drawing.Point(112, 0);
            this.ProducerName.Name = "ProducerName";
            this.ProducerName.Size = new System.Drawing.Size(82, 22);
            this.ProducerName.TabIndex = 5;
            this.ProducerName.Text = "ProdVal";
            this.ProducerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngridientsLabel
            // 
            this.IngridientsLabel.AutoSize = true;
            this.IngridientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngridientsLabel.Location = new System.Drawing.Point(3, 235);
            this.IngridientsLabel.Name = "IngridientsLabel";
            this.IngridientsLabel.Size = new System.Drawing.Size(101, 25);
            this.IngridientsLabel.TabIndex = 2;
            this.IngridientsLabel.Text = "Ingridients";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CloseButton.BorderRadius = 5;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(0, 412);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(549, 39);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SingleDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(549, 451);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DishFlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SingleDish";
            this.Text = "SingleDish";
            this.DishFlowLayout.ResumeLayout(false);
            this.DishFlowLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DishFlowLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DishName;
        private System.Windows.Forms.Panel Image;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CostLabelValue;
        private System.Windows.Forms.Label CalValue;
        private System.Windows.Forms.Label IngridientsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProducerName;
        private CustomButton CloseButton;
        private System.Windows.Forms.Label DishDescription;
    }
}