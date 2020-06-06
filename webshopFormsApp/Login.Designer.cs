namespace webshopFormsApp
{
    partial class Login
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
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userField
            // 
            this.userField.AccessibleName = "userField";
            this.userField.Location = new System.Drawing.Point(28, 47);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(315, 22);
            this.userField.TabIndex = 0;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(28, 125);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(315, 22);
            this.passField.TabIndex = 1;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(31, 188);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(107, 37);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "register";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(236, 188);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(107, 37);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(28, 249);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(117, 17);
            this.alert.TabIndex = 7;
            this.alert.Text = "*** dummy text ***";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 284);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.userField);
            this.Name = "Login";
            this.Text = "Login page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alert;
    }
}

