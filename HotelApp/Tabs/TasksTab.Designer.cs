namespace HotelApp
{
    partial class TasksTab
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
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.EmployeeIDBox = new System.Windows.Forms.TextBox();
            this.checkInBox = new System.Windows.Forms.CheckBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.checkOutBox = new System.Windows.Forms.CheckBox();
            this.cleanUpBox = new System.Windows.Forms.CheckBox();
            this.infosPanel = new System.Windows.Forms.Panel();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.roomNumberBox = new System.Windows.Forms.TextBox();
            this.guestNameBox = new System.Windows.Forms.TextBox();
            this.checkInDateBox = new System.Windows.Forms.TextBox();
            this.checkOutDateBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.getDateButton = new System.Windows.Forms.Button();
            this.selectionPanel.SuspendLayout();
            this.infosPanel.SuspendLayout();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionPanel
            // 
            this.selectionPanel.Controls.Add(this.EmployeeIDBox);
            this.selectionPanel.Controls.Add(this.checkInBox);
            this.selectionPanel.Controls.Add(this.employeeIDLabel);
            this.selectionPanel.Controls.Add(this.checkOutBox);
            this.selectionPanel.Controls.Add(this.cleanUpBox);
            this.selectionPanel.Location = new System.Drawing.Point(3, 463);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(112, 111);
            this.selectionPanel.TabIndex = 48;
            this.selectionPanel.Visible = false;
            // 
            // EmployeeIDBox
            // 
            this.EmployeeIDBox.Location = new System.Drawing.Point(6, 87);
            this.EmployeeIDBox.Name = "EmployeeIDBox";
            this.EmployeeIDBox.Size = new System.Drawing.Size(65, 20);
            this.EmployeeIDBox.TabIndex = 23;
            // 
            // checkInBox
            // 
            this.checkInBox.AutoSize = true;
            this.checkInBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkInBox.Location = new System.Drawing.Point(6, 5);
            this.checkInBox.Name = "checkInBox";
            this.checkInBox.Size = new System.Drawing.Size(69, 17);
            this.checkInBox.TabIndex = 19;
            this.checkInBox.Text = "Check In";
            this.checkInBox.UseVisualStyleBackColor = true;
            this.checkInBox.CheckedChanged += new System.EventHandler(this.CheckInBoxCheckedChanged);
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeIDLabel.Location = new System.Drawing.Point(4, 71);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIDLabel.TabIndex = 22;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // checkOutBox
            // 
            this.checkOutBox.AutoSize = true;
            this.checkOutBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkOutBox.Location = new System.Drawing.Point(6, 28);
            this.checkOutBox.Name = "checkOutBox";
            this.checkOutBox.Size = new System.Drawing.Size(77, 17);
            this.checkOutBox.TabIndex = 20;
            this.checkOutBox.Text = "Check Out";
            this.checkOutBox.UseVisualStyleBackColor = true;
            this.checkOutBox.CheckedChanged += new System.EventHandler(this.CheckOutBoxCheckedChanged);
            // 
            // cleanUpBox
            // 
            this.cleanUpBox.AutoSize = true;
            this.cleanUpBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cleanUpBox.Location = new System.Drawing.Point(6, 51);
            this.cleanUpBox.Name = "cleanUpBox";
            this.cleanUpBox.Size = new System.Drawing.Size(70, 17);
            this.cleanUpBox.TabIndex = 21;
            this.cleanUpBox.Text = "Clean Up";
            this.cleanUpBox.UseVisualStyleBackColor = true;
            this.cleanUpBox.CheckedChanged += new System.EventHandler(this.CleanUpBoxCheckedChanged);
            // 
            // infosPanel
            // 
            this.infosPanel.Controls.Add(this.roomNumberLabel);
            this.infosPanel.Controls.Add(this.guestNameLabel);
            this.infosPanel.Controls.Add(this.checkInDateLabel);
            this.infosPanel.Controls.Add(this.checkOutDateLabel);
            this.infosPanel.Controls.Add(this.notesLabel);
            this.infosPanel.Controls.Add(this.roomNumberBox);
            this.infosPanel.Controls.Add(this.guestNameBox);
            this.infosPanel.Controls.Add(this.checkInDateBox);
            this.infosPanel.Controls.Add(this.checkOutDateBox);
            this.infosPanel.Controls.Add(this.notesBox);
            this.infosPanel.Controls.Add(this.confirmButton);
            this.infosPanel.Location = new System.Drawing.Point(3, 179);
            this.infosPanel.Name = "infosPanel";
            this.infosPanel.Size = new System.Drawing.Size(112, 280);
            this.infosPanel.TabIndex = 44;
            this.infosPanel.Visible = false;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomNumberLabel.Location = new System.Drawing.Point(3, 2);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNumberLabel.TabIndex = 12;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guestNameLabel.Location = new System.Drawing.Point(3, 41);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(66, 13);
            this.guestNameLabel.TabIndex = 13;
            this.guestNameLabel.Text = "Guest Name";
            // 
            // checkInDateLabel
            // 
            this.checkInDateLabel.AutoSize = true;
            this.checkInDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkInDateLabel.Location = new System.Drawing.Point(3, 80);
            this.checkInDateLabel.Name = "checkInDateLabel";
            this.checkInDateLabel.Size = new System.Drawing.Size(76, 13);
            this.checkInDateLabel.TabIndex = 14;
            this.checkInDateLabel.Text = "Check In Date";
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.AutoSize = true;
            this.checkOutDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkOutDateLabel.Location = new System.Drawing.Point(3, 119);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(84, 13);
            this.checkOutDateLabel.TabIndex = 16;
            this.checkOutDateLabel.Text = "Check Out Date";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notesLabel.Location = new System.Drawing.Point(3, 158);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 15;
            this.notesLabel.Text = "Notes";
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Location = new System.Drawing.Point(6, 18);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberBox.TabIndex = 5;
            // 
            // guestNameBox
            // 
            this.guestNameBox.Location = new System.Drawing.Point(6, 57);
            this.guestNameBox.Name = "guestNameBox";
            this.guestNameBox.Size = new System.Drawing.Size(100, 20);
            this.guestNameBox.TabIndex = 6;
            // 
            // checkInDateBox
            // 
            this.checkInDateBox.Location = new System.Drawing.Point(6, 96);
            this.checkInDateBox.Name = "checkInDateBox";
            this.checkInDateBox.Size = new System.Drawing.Size(100, 20);
            this.checkInDateBox.TabIndex = 7;
            // 
            // checkOutDateBox
            // 
            this.checkOutDateBox.Location = new System.Drawing.Point(6, 135);
            this.checkOutDateBox.Name = "checkOutDateBox";
            this.checkOutDateBox.Size = new System.Drawing.Size(100, 20);
            this.checkOutDateBox.TabIndex = 17;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(6, 174);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesBox.Size = new System.Drawing.Size(100, 75);
            this.notesBox.TabIndex = 8;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Goldenrod;
            this.confirmButton.Location = new System.Drawing.Point(18, 255);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // reservationIDPanel
            // 
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDBox);
            this.reservationIDPanel.Controls.Add(this.getButton);
            this.reservationIDPanel.Location = new System.Drawing.Point(3, 131);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(112, 47);
            this.reservationIDPanel.TabIndex = 45;
            this.reservationIDPanel.Visible = false;
            // 
            // reservationIDLabel
            // 
            this.reservationIDLabel.AutoSize = true;
            this.reservationIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationIDLabel.Location = new System.Drawing.Point(4, 5);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(78, 13);
            this.reservationIDLabel.TabIndex = 0;
            this.reservationIDLabel.Text = "Reservation ID";
            // 
            // reservationIDBox
            // 
            this.reservationIDBox.Location = new System.Drawing.Point(7, 21);
            this.reservationIDBox.Name = "reservationIDBox";
            this.reservationIDBox.Size = new System.Drawing.Size(64, 20);
            this.reservationIDBox.TabIndex = 1;
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
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Location = new System.Drawing.Point(6, 88);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Date";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(9, 104);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(65, 20);
            this.dateBox.TabIndex = 46;
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
            this.dataGridView1.TabIndex = 43;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(10, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 38);
            this.viewButton.TabIndex = 39;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButtonClick);
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(10, 47);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(100, 38);
            this.completeButton.TabIndex = 41;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.CompleteButtonClick);
            // 
            // getDateButton
            // 
            this.getDateButton.Location = new System.Drawing.Point(77, 102);
            this.getDateButton.Name = "getDateButton";
            this.getDateButton.Size = new System.Drawing.Size(35, 23);
            this.getDateButton.TabIndex = 47;
            this.getDateButton.Text = "Get";
            this.getDateButton.UseVisualStyleBackColor = true;
            this.getDateButton.Click += new System.EventHandler(this.DateGetButtonClick);
            // 
            // TasksTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectionPanel);
            this.Controls.Add(this.getDateButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.infosPanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.completeButton);
            this.Name = "TasksTab";
            this.Size = new System.Drawing.Size(872, 574);
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.infosPanel.ResumeLayout(false);
            this.infosPanel.PerformLayout();
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel infosPanel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label guestNameLabel;
        private System.Windows.Forms.Label checkInDateLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox roomNumberBox;
        private System.Windows.Forms.TextBox guestNameBox;
        private System.Windows.Forms.TextBox checkInDateBox;
        private System.Windows.Forms.TextBox checkOutDateBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Button getDateButton;
        private System.Windows.Forms.CheckBox checkInBox;
        private System.Windows.Forms.CheckBox checkOutBox;
        private System.Windows.Forms.CheckBox cleanUpBox;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.TextBox EmployeeIDBox;
        private System.Windows.Forms.Panel selectionPanel;
    }
}
