using System;
using System.Windows.Forms;

namespace MyCoffeeProject
{
    partial class YodaCoffeeShop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YodaCoffeeShop));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.enterFNameLabel = new System.Windows.Forms.Label();
            this.phoneNumlabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveCustBtn = new System.Windows.Forms.Button();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerHeader = new System.Windows.Forms.Label();
            this.CustomersSearchBar = new System.Windows.Forms.TextBox();
            this.PhNumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DeleteCustButton = new System.Windows.Forms.Button();
            this.InvalidEmail = new System.Windows.Forms.Label();
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ProductSearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.ITBISLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubTotalBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.ITBISBox = new System.Windows.Forms.TextBox();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.EditCustButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TipBox = new System.Windows.Forms.TextBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.CustTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerTypeLabel = new System.Windows.Forms.Label();
            this.RNCTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RNCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(293, 18);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(346, 33);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Dream Bean Coffee Shop";
            // 
            // enterFNameLabel
            // 
            this.enterFNameLabel.AutoSize = true;
            this.enterFNameLabel.Location = new System.Drawing.Point(296, 60);
            this.enterFNameLabel.Name = "enterFNameLabel";
            this.enterFNameLabel.Size = new System.Drawing.Size(134, 13);
            this.enterFNameLabel.TabIndex = 1;
            this.enterFNameLabel.Text = "Please Enter Client\'s Name";
            // 
            // phoneNumlabel
            // 
            this.phoneNumlabel.AutoSize = true;
            this.phoneNumlabel.Location = new System.Drawing.Point(296, 116);
            this.phoneNumlabel.Name = "phoneNumlabel";
            this.phoneNumlabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumlabel.TabIndex = 3;
            this.phoneNumlabel.Text = "Phone Number:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(444, 57);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.Location = new System.Drawing.Point(6, 293);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(282, 238);
            this.ClientListBox.TabIndex = 9;
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Location = new System.Drawing.Point(299, 367);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(0, 13);
            this.outPutLabel.TabIndex = 11;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(412, 196);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveCustBtn
            // 
            this.saveCustBtn.Location = new System.Drawing.Point(493, 196);
            this.saveCustBtn.Name = "saveCustBtn";
            this.saveCustBtn.Size = new System.Drawing.Size(100, 23);
            this.saveCustBtn.TabIndex = 5;
            this.saveCustBtn.Text = "Save Customer";
            this.saveCustBtn.UseVisualStyleBackColor = true;
            this.saveCustBtn.Click += new System.EventHandler(this.saveCustBtn_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(444, 83);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email:";
            // 
            // lblCustomerHeader
            // 
            this.lblCustomerHeader.AutoSize = true;
            this.lblCustomerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerHeader.Location = new System.Drawing.Point(87, 233);
            this.lblCustomerHeader.Name = "lblCustomerHeader";
            this.lblCustomerHeader.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerHeader.TabIndex = 25;
            this.lblCustomerHeader.Text = "Customers:";
            // 
            // CustomersSearchBar
            // 
            this.CustomersSearchBar.Location = new System.Drawing.Point(5, 265);
            this.CustomersSearchBar.Name = "CustomersSearchBar";
            this.CustomersSearchBar.Size = new System.Drawing.Size(282, 20);
            this.CustomersSearchBar.TabIndex = 27;
            this.CustomersSearchBar.Text = "Enter Customer\'s Name Here";
            this.CustomersSearchBar.Click += new System.EventHandler(this.EmptyTextBoxOnClick_Click);
            this.CustomersSearchBar.TextChanged += new System.EventHandler(this.CustomerSearchBar_TextChanged);
            // 
            // PhNumTextBox
            // 
            this.PhNumTextBox.Location = new System.Drawing.Point(444, 113);
            this.PhNumTextBox.Mask = "000-000-0000";
            this.PhNumTextBox.Name = "PhNumTextBox";
            this.PhNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhNumTextBox.TabIndex = 28;
            // 
            // DeleteCustButton
            // 
            this.DeleteCustButton.Location = new System.Drawing.Point(294, 349);
            this.DeleteCustButton.Name = "DeleteCustButton";
            this.DeleteCustButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCustButton.TabIndex = 29;
            this.DeleteCustButton.Text = "Delete";
            this.DeleteCustButton.UseVisualStyleBackColor = true;
            this.DeleteCustButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InvalidEmail
            // 
            this.InvalidEmail.AutoSize = true;
            this.InvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmail.Location = new System.Drawing.Point(550, 88);
            this.InvalidEmail.Name = "InvalidEmail";
            this.InvalidEmail.Size = new System.Drawing.Size(104, 13);
            this.InvalidEmail.TabIndex = 30;
            this.InvalidEmail.Text = "*Email Already Exists";
            this.InvalidEmail.Visible = false;
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Location = new System.Drawing.Point(294, 293);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.ShowOrdersButton.TabIndex = 31;
            this.ShowOrdersButton.Text = "Orders";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(677, 293);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(85, 23);
            this.AddToOrderButton.TabIndex = 36;
            this.AddToOrderButton.Text = "Add To Order";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(677, 376);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 35;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ProductSearchBar
            // 
            this.ProductSearchBar.Location = new System.Drawing.Point(388, 265);
            this.ProductSearchBar.Name = "ProductSearchBar";
            this.ProductSearchBar.Size = new System.Drawing.Size(282, 20);
            this.ProductSearchBar.TabIndex = 34;
            this.ProductSearchBar.Text = "Enter Product\'s Name Here";
            this.ProductSearchBar.Click += new System.EventHandler(this.EmptyTextBoxOnClick_Click);
            this.ProductSearchBar.TextChanged += new System.EventHandler(this.ProductSearchBar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 33;
            // 
            // ProductListBox
            // 
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.Location = new System.Drawing.Point(389, 293);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(282, 238);
            this.ProductListBox.TabIndex = 32;
            this.ProductListBox.DoubleClick += new System.EventHandler(this.ProductListBox_DoubleClick);
            // 
            // OrderListBox
            // 
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(779, 274);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(174, 186);
            this.OrderListBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Order";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(831, 472);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 39;
            this.SubTotalLabel.Text = "Sub-Total:";
            // 
            // ITBISLabel
            // 
            this.ITBISLabel.AutoSize = true;
            this.ITBISLabel.Location = new System.Drawing.Point(835, 495);
            this.ITBISLabel.Name = "ITBISLabel";
            this.ITBISLabel.Size = new System.Drawing.Size(37, 13);
            this.ITBISLabel.TabIndex = 40;
            this.ITBISLabel.Text = "ITBIS:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(838, 542);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 44;
            this.TotalLabel.Text = "Total:";
            // 
            // SubTotalBox
            // 
            this.SubTotalBox.Location = new System.Drawing.Point(893, 469);
            this.SubTotalBox.Name = "SubTotalBox";
            this.SubTotalBox.ReadOnly = true;
            this.SubTotalBox.Size = new System.Drawing.Size(54, 20);
            this.SubTotalBox.TabIndex = 47;
            this.SubTotalBox.Text = "$00.00";
            this.SubTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(894, 539);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(54, 20);
            this.TotalBox.TabIndex = 48;
            this.TotalBox.Text = "$00.00";
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ITBISBox
            // 
            this.ITBISBox.Location = new System.Drawing.Point(893, 492);
            this.ITBISBox.Name = "ITBISBox";
            this.ITBISBox.ReadOnly = true;
            this.ITBISBox.Size = new System.Drawing.Size(54, 20);
            this.ITBISBox.TabIndex = 49;
            this.ITBISBox.Text = "$00.00";
            this.ITBISBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(955, 283);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckoutButton.TabIndex = 51;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // EditCustButton
            // 
            this.EditCustButton.Location = new System.Drawing.Point(294, 322);
            this.EditCustButton.Name = "EditCustButton";
            this.EditCustButton.Size = new System.Drawing.Size(75, 23);
            this.EditCustButton.TabIndex = 53;
            this.EditCustButton.Text = "Edit";
            this.EditCustButton.UseVisualStyleBackColor = true;
            this.EditCustButton.Click += new System.EventHandler(this.EditCustButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Location = new System.Drawing.Point(677, 322);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(75, 23);
            this.EditProductButton.TabIndex = 54;
            this.EditProductButton.Text = "Edit";
            this.EditProductButton.UseVisualStyleBackColor = true;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(677, 349);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(75, 23);
            this.NewProductButton.TabIndex = 55;
            this.NewProductButton.Text = "New";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(955, 312);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 56;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TipBox
            // 
            this.TipBox.Location = new System.Drawing.Point(893, 515);
            this.TipBox.Name = "TipBox";
            this.TipBox.ReadOnly = true;
            this.TipBox.Size = new System.Drawing.Size(54, 20);
            this.TipBox.TabIndex = 58;
            this.TipBox.Text = "$00.00";
            this.TipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(843, 518);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(25, 13);
            this.TipLabel.TabIndex = 57;
            this.TipLabel.Text = "Tip:";
            // 
            // CustTypeComboBox
            // 
            this.CustTypeComboBox.FormattingEnabled = true;
            this.CustTypeComboBox.Location = new System.Drawing.Point(444, 167);
            this.CustTypeComboBox.Name = "CustTypeComboBox";
            this.CustTypeComboBox.Size = new System.Drawing.Size(210, 21);
            this.CustTypeComboBox.TabIndex = 59;
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Location = new System.Drawing.Point(299, 170);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(81, 13);
            this.CustomerTypeLabel.TabIndex = 60;
            this.CustomerTypeLabel.Text = "Customer Type:";
            // 
            // RNCTextBox
            // 
            this.RNCTextBox.Location = new System.Drawing.Point(444, 142);
            this.RNCTextBox.Mask = "000-0000000-0";
            this.RNCTextBox.Name = "RNCTextBox";
            this.RNCTextBox.Size = new System.Drawing.Size(100, 20);
            this.RNCTextBox.TabIndex = 62;
            // 
            // RNCLabel
            // 
            this.RNCLabel.AutoSize = true;
            this.RNCLabel.Location = new System.Drawing.Point(296, 145);
            this.RNCLabel.Name = "RNCLabel";
            this.RNCLabel.Size = new System.Drawing.Size(33, 13);
            this.RNCLabel.TabIndex = 61;
            this.RNCLabel.Text = "RNC:";
            // 
            // YodaCoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 564);
            this.Controls.Add(this.RNCTextBox);
            this.Controls.Add(this.RNCLabel);
            this.Controls.Add(this.CustomerTypeLabel);
            this.Controls.Add(this.CustTypeComboBox);
            this.Controls.Add(this.TipBox);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.EditCustButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ITBISBox);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.SubTotalBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ITBISLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ProductSearchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.InvalidEmail);
            this.Controls.Add(this.DeleteCustButton);
            this.Controls.Add(this.PhNumTextBox);
            this.Controls.Add(this.CustomersSearchBar);
            this.Controls.Add(this.lblCustomerHeader);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveCustBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.phoneNumlabel);
            this.Controls.Add(this.enterFNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "YodaCoffeeShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCoffeeProject";
            this.Load += new System.EventHandler(this.YodaCoffeeShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label enterFNameLabel;
        private System.Windows.Forms.Label phoneNumlabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveCustBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerHeader;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox CustomersSearchBar;
        private System.Windows.Forms.MaskedTextBox PhNumTextBox;
        private System.Windows.Forms.Button DeleteCustButton;
        private System.Windows.Forms.Label InvalidEmail;
        private System.Windows.Forms.Button ShowOrdersButton;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox ProductSearchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label ITBISLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SubTotalBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox ITBISBox;
        private System.Windows.Forms.Button CheckoutButton;
        private Button EditCustButton;
        private Button EditProductButton;
        private Button NewProductButton;
        private Button RemoveButton;
        private TextBox TipBox;
        private Label TipLabel;
        private ComboBox CustTypeComboBox;
        private Label CustomerTypeLabel;
        private MaskedTextBox RNCTextBox;
        private Label RNCLabel;
    }
}

