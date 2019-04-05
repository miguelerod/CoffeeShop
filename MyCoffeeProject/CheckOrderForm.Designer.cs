namespace MyCoffeeProject
{
    partial class CheckOrderForm
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
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.CustInfoTextBox = new System.Windows.Forms.TextBox();
            this.OrderInfoTextBox = new System.Windows.Forms.TextBox();
            this.OrderItemListBox = new System.Windows.Forms.ListBox();
            this.PriceBox = new System.Windows.Forms.ListBox();
            this.SubTotalBox = new System.Windows.Forms.TextBox();
            this.ITBISBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TipBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.ITBISLabel = new System.Windows.Forms.Label();
            this.TipLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Location = new System.Drawing.Point(47, 13);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.ReadOnly = true;
            this.CompanyTextBox.Size = new System.Drawing.Size(399, 20);
            this.CompanyTextBox.TabIndex = 1;
            this.CompanyTextBox.Text = " Yoda CoffeeShop";
            this.CompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustInfoTextBox
            // 
            this.CustInfoTextBox.Location = new System.Drawing.Point(47, 40);
            this.CustInfoTextBox.Name = "CustInfoTextBox";
            this.CustInfoTextBox.ReadOnly = true;
            this.CustInfoTextBox.Size = new System.Drawing.Size(399, 20);
            this.CustInfoTextBox.TabIndex = 2;
            // 
            // OrderInfoTextBox
            // 
            this.OrderInfoTextBox.Location = new System.Drawing.Point(47, 67);
            this.OrderInfoTextBox.Name = "OrderInfoTextBox";
            this.OrderInfoTextBox.ReadOnly = true;
            this.OrderInfoTextBox.Size = new System.Drawing.Size(399, 20);
            this.OrderInfoTextBox.TabIndex = 3;
            this.OrderInfoTextBox.TextChanged += new System.EventHandler(this.OrderInfoTextBox_TextChanged);
            // 
            // OrderItemListBox
            // 
            this.OrderItemListBox.FormattingEnabled = true;
            this.OrderItemListBox.Location = new System.Drawing.Point(47, 94);
            this.OrderItemListBox.Name = "OrderItemListBox";
            this.OrderItemListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.OrderItemListBox.Size = new System.Drawing.Size(309, 303);
            this.OrderItemListBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            this.PriceBox.FormattingEnabled = true;
            this.PriceBox.Location = new System.Drawing.Point(362, 94);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceBox.Size = new System.Drawing.Size(96, 303);
            this.PriceBox.TabIndex = 5;
            // 
            // SubTotalBox
            // 
            this.SubTotalBox.Location = new System.Drawing.Point(378, 405);
            this.SubTotalBox.Name = "SubTotalBox";
            this.SubTotalBox.ReadOnly = true;
            this.SubTotalBox.Size = new System.Drawing.Size(84, 20);
            this.SubTotalBox.TabIndex = 6;
            this.SubTotalBox.Text = "$00.00";
            this.SubTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ITBISBox
            // 
            this.ITBISBox.Location = new System.Drawing.Point(378, 431);
            this.ITBISBox.Name = "ITBISBox";
            this.ITBISBox.ReadOnly = true;
            this.ITBISBox.Size = new System.Drawing.Size(84, 20);
            this.ITBISBox.TabIndex = 7;
            this.ITBISBox.Text = "$00.00";
            this.ITBISBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(378, 483);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(84, 20);
            this.TotalBox.TabIndex = 8;
            this.TotalBox.Text = "$00.00";
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TipBox
            // 
            this.TipBox.Location = new System.Drawing.Point(378, 457);
            this.TipBox.Name = "TipBox";
            this.TipBox.ReadOnly = true;
            this.TipBox.Size = new System.Drawing.Size(84, 20);
            this.TipBox.TabIndex = 9;
            this.TipBox.Text = "$00.00";
            this.TipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(318, 408);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 10;
            this.SubTotalLabel.Text = "Sub-Total:";
            // 
            // ITBISLabel
            // 
            this.ITBISLabel.AutoSize = true;
            this.ITBISLabel.Location = new System.Drawing.Point(319, 434);
            this.ITBISLabel.Name = "ITBISLabel";
            this.ITBISLabel.Size = new System.Drawing.Size(37, 13);
            this.ITBISLabel.TabIndex = 11;
            this.ITBISLabel.Text = "ITBIS:";
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(318, 460);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(25, 13);
            this.TipLabel.TabIndex = 12;
            this.TipLabel.Text = "Tip:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(318, 486);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 13;
            this.TotalLabel.Text = "Total:";
            // 
            // CheckOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 514);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.ITBISLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.TipBox);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.ITBISBox);
            this.Controls.Add(this.SubTotalBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.OrderItemListBox);
            this.Controls.Add(this.OrderInfoTextBox);
            this.Controls.Add(this.CustInfoTextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Name = "CheckOrderForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.TextBox CustInfoTextBox;
        private System.Windows.Forms.TextBox OrderInfoTextBox;
        private System.Windows.Forms.ListBox OrderItemListBox;
        private System.Windows.Forms.ListBox PriceBox;
        private System.Windows.Forms.TextBox SubTotalBox;
        private System.Windows.Forms.TextBox ITBISBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox TipBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label ITBISLabel;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label TotalLabel;
    }
}