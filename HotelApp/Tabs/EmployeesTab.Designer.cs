namespace HotelApp
{
    partial class EmployeesTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeIDPanel = new System.Windows.Forms.Panel();
            this.getButton = new System.Windows.Forms.Button();
            this.employeeIDBox = new System.Windows.Forms.TextBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.infosPanel = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.employeeIDPanel.SuspendLayout();
            this.infosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDPanel
            // 
            this.employeeIDPanel.Controls.Add(this.getButton);
            this.employeeIDPanel.Controls.Add(this.employeeIDBox);
            this.employeeIDPanel.Controls.Add(this.employeeIDLabel);
            this.employeeIDPanel.Location = new System.Drawing.Point(3, 179);
            this.employeeIDPanel.Name = "employeeIDPanel";
            this.employeeIDPanel.Size = new System.Drawing.Size(112, 47);
            this.employeeIDPanel.TabIndex = 24;
            this.employeeIDPanel.Visible = false;
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(74, 19);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(35, 23);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.GetButtonClick);
            // 
            // employeeIDBox
            // 
            this.employeeIDBox.Location = new System.Drawing.Point(7, 21);
            this.employeeIDBox.Name = "employeeIDBox";
            this.employeeIDBox.Size = new System.Drawing.Size(64, 20);
            this.employeeIDBox.TabIndex = 1;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeIDLabel.Location = new System.Drawing.Point(4, 5);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIDLabel.TabIndex = 0;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // infosPanel
            // 
            this.infosPanel.Controls.Add(this.firstNameLabel);
            this.infosPanel.Controls.Add(this.confirmButton);
            this.infosPanel.Controls.Add(this.passwordLabel);
            this.infosPanel.Controls.Add(this.firstNameBox);
            this.infosPanel.Controls.Add(this.passwordBox);
            this.infosPanel.Controls.Add(this.roleLabel);
            this.infosPanel.Controls.Add(this.lastNameLabel);
            this.infosPanel.Controls.Add(this.lastNameBox);
            this.infosPanel.Controls.Add(this.roleBox);
            this.infosPanel.Location = new System.Drawing.Point(3, 227);
            this.infosPanel.Name = "infosPanel";
            this.infosPanel.Size = new System.Drawing.Size(112, 188);
            this.infosPanel.TabIndex = 23;
            this.infosPanel.Visible = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 2);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Goldenrod;
            this.confirmButton.Location = new System.Drawing.Point(16, 161);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(3, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(6, 18);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(6, 135);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 8;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roleLabel.Location = new System.Drawing.Point(3, 80);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Role";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 41);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(6, 57);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 6;
            // 
            // roleBox
            // 
            this.roleBox.Location = new System.Drawing.Point(6, 96);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(100, 20);
            this.roleBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 568);
            this.dataGridView1.TabIndex = 22;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 135);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 38);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(10, 47);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 38);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Gainsboro;
            this.newButton.Location = new System.Drawing.Point(10, 91);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 38);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButtonClick);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(10, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 38);
            this.viewButton.TabIndex = 18;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButtonClick);
            // 
            // EmployeesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeIDPanel);
            this.Controls.Add(this.infosPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.viewButton);
            this.Name = "EmployeesTab";
            this.Size = new System.Drawing.Size(872, 574);
            this.employeeIDPanel.ResumeLayout(false);
            this.employeeIDPanel.PerformLayout();
            this.infosPanel.ResumeLayout(false);
            this.infosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeeIDPanel;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox employeeIDBox;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Panel infosPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox roleBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button viewButton;
    }
}
