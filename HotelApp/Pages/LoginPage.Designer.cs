namespace HotelApp
{
    partial class LoginPage
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.employeeIDBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.invCredLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.loginLabel.Location = new System.Drawing.Point(132, 26);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(298, 139);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(186, 174);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(175, 47);
            this.employeeIDLabel.TabIndex = 1;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(202, 277);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(137, 47);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // employeeIDBox
            // 
            this.employeeIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDBox.Location = new System.Drawing.Point(165, 233);
            this.employeeIDBox.Name = "employeeIDBox";
            this.employeeIDBox.Size = new System.Drawing.Size(223, 32);
            this.employeeIDBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(165, 336);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(223, 32);
            this.passwordBox.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.YellowGreen;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.submitButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(210, 389);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(128, 59);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // invCredLabel
            // 
            this.invCredLabel.AutoSize = true;
            this.invCredLabel.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invCredLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.invCredLabel.Location = new System.Drawing.Point(120, 478);
            this.invCredLabel.Name = "invCredLabel";
            this.invCredLabel.Size = new System.Drawing.Size(318, 47);
            this.invCredLabel.TabIndex = 6;
            this.invCredLabel.Text = "Invalid Credentials x0";
            this.invCredLabel.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 619);
            this.Controls.Add(this.invCredLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.employeeIDBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginPage";
            this.Text = "Hotel App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox employeeIDBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label invCredLabel;
    }
}

