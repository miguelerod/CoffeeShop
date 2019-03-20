using System.ComponentModel;
using System.Windows.Forms;

namespace MyCoffeeProject
{
    partial class LoginForm
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
            this.signInButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wrongCredentials = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(408, 186);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(87, 23);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.SystemColors.Window;
            this.UserBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserBox.Location = new System.Drawing.Point(292, 74);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(203, 20);
            this.UserBox.TabIndex = 2;
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            this.UserBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserBox_inputKey);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(292, 141);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(203, 20);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_inputKey);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameLabel.Location = new System.Drawing.Point(292, 58);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLabel.Location = new System.Drawing.Point(288, 125);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyCoffeeProject.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // wrongCredentials
            // 
            this.wrongCredentials.AutoSize = true;
            this.wrongCredentials.ForeColor = System.Drawing.Color.Red;
            this.wrongCredentials.Location = new System.Drawing.Point(292, 167);
            this.wrongCredentials.Name = "wrongCredentials";
            this.wrongCredentials.Size = new System.Drawing.Size(198, 13);
            this.wrongCredentials.TabIndex = 7;
            this.wrongCredentials.Text = "*Incorrect Password Or Username";
            this.wrongCredentials.Visible = false;
            this.wrongCredentials.Click += new System.EventHandler(this.wrongCredentials_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(546, 243);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.wrongCredentials);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.signInButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wrongCredentials;
    }
}