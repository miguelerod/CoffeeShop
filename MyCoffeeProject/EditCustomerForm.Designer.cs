namespace MyCoffeeProject
{
    partial class EditCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhNumLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PhNumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TypeComboBox = new System.Windows.Forms.Label();
            this.CustTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RNCTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RNCLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.Name = "EmailLabel";
            // 
            // PhNumLabel
            // 
            resources.ApplyResources(this.PhNumLabel, "PhNumLabel");
            this.PhNumLabel.Name = "PhNumLabel";
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(this.EmailTextBox, "EmailTextBox");
            this.EmailTextBox.Name = "EmailTextBox";
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PhNumTextBox
            // 
            resources.ApplyResources(this.PhNumTextBox, "PhNumTextBox");
            this.PhNumTextBox.Name = "PhNumTextBox";
            // 
            // TypeComboBox
            // 
            resources.ApplyResources(this.TypeComboBox, "TypeComboBox");
            this.TypeComboBox.Name = "TypeComboBox";
            // 
            // CustTypeComboBox
            // 
            this.CustTypeComboBox.FormattingEnabled = true;
            this.CustTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("CustTypeComboBox.Items"),
            resources.GetString("CustTypeComboBox.Items1"),
            resources.GetString("CustTypeComboBox.Items2")});
            resources.ApplyResources(this.CustTypeComboBox, "CustTypeComboBox");
            this.CustTypeComboBox.Name = "CustTypeComboBox";
            // 
            // RNCTextBox
            // 
            resources.ApplyResources(this.RNCTextBox, "RNCTextBox");
            this.RNCTextBox.Name = "RNCTextBox";
            // 
            // RNCLabel
            // 
            resources.ApplyResources(this.RNCLabel, "RNCLabel");
            this.RNCLabel.Name = "RNCLabel";
            // 
            // EditCustomerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RNCTextBox);
            this.Controls.Add(this.RNCLabel);
            this.Controls.Add(this.CustTypeComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.PhNumTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PhNumLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhNumLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox PhNumTextBox;
        private System.Windows.Forms.Label TypeComboBox;
        private System.Windows.Forms.ComboBox CustTypeComboBox;
        private System.Windows.Forms.MaskedTextBox RNCTextBox;
        private System.Windows.Forms.Label RNCLabel;
    }
}