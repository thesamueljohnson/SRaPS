
namespace PHP_SRaPS
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
            this.lblRequires = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequires
            // 
            this.lblRequires.AutoSize = true;
            this.lblRequires.Location = new System.Drawing.Point(11, 7);
            this.lblRequires.Name = "lblRequires";
            this.lblRequires.Size = new System.Drawing.Size(49, 13);
            this.lblRequires.TabIndex = 0;
            this.lblRequires.Text = "Requires";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.lblUsername.Location = new System.Drawing.Point(33, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(131, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Administrator";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(11, 54);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(250, 20);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(69, 86);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Authorise Changes";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(169, 38);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(97, 13);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "Incorrect password";
            this.lblIncorrect.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 120);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRequires);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequires;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIncorrect;
    }
}