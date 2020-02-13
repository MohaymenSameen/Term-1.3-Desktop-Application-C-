namespace SomerenUI
{
    partial class Recover
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_Secret = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.textBox_new = new System.Windows.Forms.TextBox();
            this.button1_enter = new System.Windows.Forms.Button();
            this.button_answer = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(42, 130);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(435, 31);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label_Secret
            // 
            this.label_Secret.AutoSize = true;
            this.label_Secret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Secret.Location = new System.Drawing.Point(35, 241);
            this.label_Secret.Name = "label_Secret";
            this.label_Secret.Size = new System.Drawing.Size(108, 37);
            this.label_Secret.TabIndex = 2;
            this.label_Secret.Text = "label2";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(42, 319);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(435, 31);
            this.textBox_Answer.TabIndex = 3;
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newPassword.Location = new System.Drawing.Point(36, 429);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(286, 31);
            this.label_newPassword.TabIndex = 4;
            this.label_newPassword.Text = "Enter New Password";
            this.label_newPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_new
            // 
            this.textBox_new.Location = new System.Drawing.Point(42, 498);
            this.textBox_new.Name = "textBox_new";
            this.textBox_new.Size = new System.Drawing.Size(435, 31);
            this.textBox_new.TabIndex = 5;
            // 
            // button1_enter
            // 
            this.button1_enter.Location = new System.Drawing.Point(536, 107);
            this.button1_enter.Name = "button1_enter";
            this.button1_enter.Size = new System.Drawing.Size(285, 54);
            this.button1_enter.TabIndex = 6;
            this.button1_enter.Text = "Enter";
            this.button1_enter.UseVisualStyleBackColor = true;
            this.button1_enter.Click += new System.EventHandler(this.button1_enter_Click);
            // 
            // button_answer
            // 
            this.button_answer.Location = new System.Drawing.Point(536, 296);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(285, 54);
            this.button_answer.TabIndex = 7;
            this.button_answer.Text = "Enter";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button_answer_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(536, 475);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(285, 54);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Recover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 630);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.button1_enter);
            this.Controls.Add(this.textBox_new);
            this.Controls.Add(this.label_newPassword);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.label_Secret);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Name = "Recover";
            this.Text = "Recover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_Secret;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.TextBox textBox_new;
        private System.Windows.Forms.Button button1_enter;
        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.Button button_Update;
    }
}