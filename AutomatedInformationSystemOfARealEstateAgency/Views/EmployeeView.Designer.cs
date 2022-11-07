namespace AutomatedInformationSystemOfARealEstateAgency.Views
{
    partial class EmployeeView
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
            this.ToComeInButton = new System.Windows.Forms.Button();
            this.PassWordInputField = new System.Windows.Forms.TextBox();
            this.LoginInputField = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToComeInButton
            // 
            this.ToComeInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToComeInButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToComeInButton.Location = new System.Drawing.Point(495, 271);
            this.ToComeInButton.Name = "ToComeInButton";
            this.ToComeInButton.Size = new System.Drawing.Size(249, 48);
            this.ToComeInButton.TabIndex = 9;
            this.ToComeInButton.Text = "Войти";
            this.ToComeInButton.UseVisualStyleBackColor = true;
            // 
            // PassWordInputField
            // 
            this.PassWordInputField.Location = new System.Drawing.Point(495, 230);
            this.PassWordInputField.Name = "PassWordInputField";
            this.PassWordInputField.Size = new System.Drawing.Size(249, 22);
            this.PassWordInputField.TabIndex = 8;
            this.PassWordInputField.UseSystemPasswordChar = true;
            // 
            // LoginInputField
            // 
            this.LoginInputField.Location = new System.Drawing.Point(495, 192);
            this.LoginInputField.Name = "LoginInputField";
            this.LoginInputField.Size = new System.Drawing.Size(249, 22);
            this.LoginInputField.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(391, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 29);
            this.Password.TabIndex = 6;
            this.Password.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(391, 186);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(73, 29);
            this.Login.TabIndex = 5;
            this.Login.Text = "Логин";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.ToComeInButton);
            this.Controls.Add(this.PassWordInputField);
            this.Controls.Add(this.LoginInputField);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "UserView";
            this.Text = "UserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToComeInButton;
        private System.Windows.Forms.TextBox PassWordInputField;
        private System.Windows.Forms.TextBox LoginInputField;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
    }
}