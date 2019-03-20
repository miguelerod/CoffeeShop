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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomersSearchBar = new System.Windows.Forms.TextBox();
            this.phoneNumtextBox = new System.Windows.Forms.MaskedTextBox();
            this.DeleteCustButton = new System.Windows.Forms.Button();
            this.InvalidEmail = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
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
            this.enterFNameLabel.Location = new System.Drawing.Point(296, 111);
            this.enterFNameLabel.Name = "enterFNameLabel";
            this.enterFNameLabel.Size = new System.Drawing.Size(134, 13);
            this.enterFNameLabel.TabIndex = 1;
            this.enterFNameLabel.Text = "Please Enter Client\'s Name";
            this.enterFNameLabel.Click += new System.EventHandler(this.enterFNameLabel_Click);
            // 
            // phoneNumlabel
            // 
            this.phoneNumlabel.AutoSize = true;
            this.phoneNumlabel.Location = new System.Drawing.Point(296, 173);
            this.phoneNumlabel.Name = "phoneNumlabel";
            this.phoneNumlabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumlabel.TabIndex = 3;
            this.phoneNumlabel.Text = "Phone Number:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(444, 108);
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
            this.ClientListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
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
            this.emailTxtBox.Location = new System.Drawing.Point(444, 139);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 144);
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
            this.lblCustomerHeader.Click += new System.EventHandler(this.lblCustomerHeader_Click);
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
            // CustomersSearchBar
            // 
            this.CustomersSearchBar.Location = new System.Drawing.Point(5, 265);
            this.CustomersSearchBar.Name = "CustomersSearchBar";
            this.CustomersSearchBar.Size = new System.Drawing.Size(282, 20);
            this.CustomersSearchBar.TabIndex = 27;
            this.CustomersSearchBar.Text = "Enter Customer\'s Name Here";
            this.CustomersSearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // phoneNumtextBox
            // 
            this.phoneNumtextBox.Location = new System.Drawing.Point(444, 170);
            this.phoneNumtextBox.Mask = "000-000-0000";
            this.phoneNumtextBox.Name = "phoneNumtextBox";
            this.phoneNumtextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumtextBox.TabIndex = 28;
            // 
            // DeleteCustButton
            // 
            this.DeleteCustButton.Location = new System.Drawing.Point(294, 300);
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
            this.InvalidEmail.Location = new System.Drawing.Point(550, 144);
            this.InvalidEmail.Name = "InvalidEmail";
            this.InvalidEmail.Size = new System.Drawing.Size(104, 13);
            this.InvalidEmail.TabIndex = 30;
            this.InvalidEmail.Text = "*Email Already Exists";
            this.InvalidEmail.Visible = false;
            this.InvalidEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Location = new System.Drawing.Point(294, 330);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.ShowOrdersButton.TabIndex = 31;
            this.ShowOrdersButton.Text = "Orders";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(685, 330);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 36;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(685, 301);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 35;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductSearchBar
            // 
            this.ProductSearchBar.Location = new System.Drawing.Point(388, 265);
            this.ProductSearchBar.Name = "ProductSearchBar";
            this.ProductSearchBar.Size = new System.Drawing.Size(282, 20);
            this.ProductSearchBar.TabIndex = 34;
            this.ProductSearchBar.Text = "Enter Product\'s Name Here";
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
            // 
            // OrderListBox
            // 
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.Location = new System.Drawing.Point(779, 293);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(174, 186);
            this.OrderListBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Order";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(831, 491);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 39;
            this.SubTotalLabel.Text = "Sub-Total:";
            // 
            // ITBISLabel
            // 
            this.ITBISLabel.AutoSize = true;
            this.ITBISLabel.Location = new System.Drawing.Point(835, 514);
            this.ITBISLabel.Name = "ITBISLabel";
            this.ITBISLabel.Size = new System.Drawing.Size(37, 13);
            this.ITBISLabel.TabIndex = 40;
            this.ITBISLabel.Text = "ITBIS:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(837, 538);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 44;
            this.TotalLabel.Text = "Total:";
            this.TotalLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // SubTotalBox
            // 
            this.SubTotalBox.Location = new System.Drawing.Point(893, 488);
            this.SubTotalBox.Name = "SubTotalBox";
            this.SubTotalBox.ReadOnly = true;
            this.SubTotalBox.Size = new System.Drawing.Size(54, 20);
            this.SubTotalBox.TabIndex = 47;
            this.SubTotalBox.Text = "$00.00";
            this.SubTotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(893, 535);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(54, 20);
            this.TotalBox.TabIndex = 48;
            this.TotalBox.Text = "$00.00";
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ITBISBox
            // 
            this.ITBISBox.Location = new System.Drawing.Point(893, 511);
            this.ITBISBox.Name = "ITBISBox";
            this.ITBISBox.ReadOnly = true;
            this.ITBISBox.Size = new System.Drawing.Size(54, 20);
            this.ITBISBox.TabIndex = 49;
            this.ITBISBox.Text = "$00.00";
            this.ITBISBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(959, 301);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckoutButton.TabIndex = 51;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(677, 359);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(96, 23);
            this.NewProductButton.TabIndex = 52;
            this.NewProductButton.Text = "New Product";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // YodaCoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 579);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ITBISBox);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.SubTotalBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ITBISLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ProductSearchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.InvalidEmail);
            this.Controls.Add(this.DeleteCustButton);
            this.Controls.Add(this.phoneNumtextBox);
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
        private System.Windows.Forms.MaskedTextBox phoneNumtextBox;
        private System.Windows.Forms.Button DeleteCustButton;
        private System.Windows.Forms.Label InvalidEmail;
        private System.Windows.Forms.Button ShowOrdersButton;
        private System.Windows.Forms.Button AddProductButton;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button NewProductButton;
    }
}

