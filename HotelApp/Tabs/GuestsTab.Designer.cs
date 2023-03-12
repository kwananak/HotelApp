namespace HotelApp
{
    partial class GuestsTab
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
            this.guestIDPanel = new System.Windows.Forms.Panel();
            this.Button = new System.Windows.Forms.Button();
            this.GuestIDBox = new System.Windows.Forms.TextBox();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.infosPanel = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.notesLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.countryCodeBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.guestIDPanel.SuspendLayout();
            this.infosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guestIDPanel
            // 
            this.guestIDPanel.Controls.Add(this.Button);
            this.guestIDPanel.Controls.Add(this.GuestIDBox);
            this.guestIDPanel.Controls.Add(this.guestIDLabel);
            this.guestIDPanel.Location = new System.Drawing.Point(3, 179);
            this.guestIDPanel.Name = "guestIDPanel";
            this.guestIDPanel.Size = new System.Drawing.Size(112, 47);
            this.guestIDPanel.TabIndex = 31;
            this.guestIDPanel.Visible = false;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(74, 19);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(35, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Get";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.GetButtonClick);
            // 
            // GuestIDBox
            // 
            this.GuestIDBox.Location = new System.Drawing.Point(7, 21);
            this.GuestIDBox.Name = "GuestIDBox";
            this.GuestIDBox.Size = new System.Drawing.Size(64, 20);
            this.GuestIDBox.TabIndex = 1;
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Location = new System.Drawing.Point(4, 5);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 0;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // infosPanel
            // 
            this.infosPanel.Controls.Add(this.firstNameLabel);
            this.infosPanel.Controls.Add(this.confirmButton);
            this.infosPanel.Controls.Add(this.notesLabel);
            this.infosPanel.Controls.Add(this.firstNameBox);
            this.infosPanel.Controls.Add(this.notesBox);
            this.infosPanel.Controls.Add(this.countryCodeLabel);
            this.infosPanel.Controls.Add(this.lastNameLabel);
            this.infosPanel.Controls.Add(this.lastNameBox);
            this.infosPanel.Controls.Add(this.countryCodeBox);
            this.infosPanel.Location = new System.Drawing.Point(3, 227);
            this.infosPanel.Name = "infosPanel";
            this.infosPanel.Size = new System.Drawing.Size(112, 247);
            this.infosPanel.TabIndex = 30;
            this.infosPanel.Visible = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 2);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.YellowGreen;
            this.confirmButton.Location = new System.Drawing.Point(17, 216);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(4, 119);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 15;
            this.notesLabel.Text = "Notes";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(6, 18);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 5;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(6, 135);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(100, 75);
            this.notesBox.TabIndex = 8;
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.AutoSize = true;
            this.countryCodeLabel.Location = new System.Drawing.Point(3, 80);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.countryCodeLabel.TabIndex = 14;
            this.countryCodeLabel.Text = "Country Code";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
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
            // countryCodeBox
            // 
            this.countryCodeBox.Location = new System.Drawing.Point(6, 96);
            this.countryCodeBox.Name = "countryCodeBox";
            this.countryCodeBox.Size = new System.Drawing.Size(100, 20);
            this.countryCodeBox.TabIndex = 7;
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
            this.dataGridView1.TabIndex = 29;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 135);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 38);
            this.removeButton.TabIndex = 28;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(10, 47);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 38);
            this.updateButton.TabIndex = 27;
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
            this.newButton.TabIndex = 26;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButtonClick);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(10, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 38);
            this.viewButton.TabIndex = 25;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButtonClick);
            // 
            // GuestsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guestIDPanel);
            this.Controls.Add(this.infosPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.viewButton);
            this.Name = "GuestsTab";
            this.Size = new System.Drawing.Size(872, 574);
            this.guestIDPanel.ResumeLayout(false);
            this.guestIDPanel.PerformLayout();
            this.infosPanel.ResumeLayout(false);
            this.infosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel guestIDPanel;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox GuestIDBox;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Panel infosPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label countryCodeLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox countryCodeBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button viewButton;
    }
}
