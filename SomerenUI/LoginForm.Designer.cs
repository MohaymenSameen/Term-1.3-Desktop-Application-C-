namespace SomerenUI
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.button_Forgot = new System.Windows.Forms.Button();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.button_Forgot);
            this.pnl_Login.Controls.Add(this.btn_SignUp);
            this.pnl_Login.Controls.Add(this.Login);
            this.pnl_Login.Controls.Add(this.PasswordBox);
            this.pnl_Login.Controls.Add(this.UsernameBox);
            this.pnl_Login.Controls.Add(this.Password);
            this.pnl_Login.Controls.Add(this.Username);
            this.pnl_Login.Location = new System.Drawing.Point(2, 31);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1192, 650);
            this.pnl_Login.TabIndex = 6;
            this.pnl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Login_Paint);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(524, 415);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(224, 54);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "Sign Up!";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(222, 415);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(274, 54);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(342, 294);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(612, 31);
            this.PasswordBox.TabIndex = 9;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(342, 183);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(612, 31);
            this.UsernameBox.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(216, 294);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(216, 190);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(110, 25);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // button_Forgot
            // 
            this.button_Forgot.Location = new System.Drawing.Point(379, 531);
            this.button_Forgot.Name = "button_Forgot";
            this.button_Forgot.Size = new System.Drawing.Size(235, 54);
            this.button_Forgot.TabIndex = 12;
            this.button_Forgot.Text = "Forgot Password";
            this.button_Forgot.UseVisualStyleBackColor = true;
            this.button_Forgot.Click += new System.EventHandler(this.button_Forgot_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.pnl_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button button_Forgot;
    }
}