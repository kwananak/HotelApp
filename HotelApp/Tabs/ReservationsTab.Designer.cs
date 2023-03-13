namespace HotelApp
{
    partial class ReservationsTab
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
            this.infosPanel = new System.Windows.Forms.Panel();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.guestIDBox = new System.Windows.Forms.TextBox();
            this.roomNumberBox = new System.Windows.Forms.TextBox();
            this.checkInDateBox = new System.Windows.Forms.TextBox();
            this.checkOutDateBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.infosPanel.SuspendLayout();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infosPanel
            // 
            this.infosPanel.Controls.Add(this.guestIDLabel);
            this.infosPanel.Controls.Add(this.roomNumberLabel);
            this.infosPanel.Controls.Add(this.checkInDateLabel);
            this.infosPanel.Controls.Add(this.checkOutDateLabel);
            this.infosPanel.Controls.Add(this.notesLabel);
            this.infosPanel.Controls.Add(this.guestIDBox);
            this.infosPanel.Controls.Add(this.roomNumberBox);
            this.infosPanel.Controls.Add(this.checkInDateBox);
            this.infosPanel.Controls.Add(this.checkOutDateBox);
            this.infosPanel.Controls.Add(this.notesBox);
            this.infosPanel.Controls.Add(this.confirmButton);
            this.infosPanel.Location = new System.Drawing.Point(3, 227);
            this.infosPanel.Name = "infosPanel";
            this.infosPanel.Size = new System.Drawing.Size(112, 286);
            this.infosPanel.TabIndex = 37;
            this.infosPanel.Visible = false;
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guestIDLabel.Location = new System.Drawing.Point(3, 2);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 12;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomNumberLabel.Location = new System.Drawing.Point(3, 41);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNumberLabel.TabIndex = 13;
            this.roomNumberLabel.Text = "Room Number";
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
            // guestIDBox
            // 
            this.guestIDBox.Location = new System.Drawing.Point(6, 18);
            this.guestIDBox.Name = "guestIDBox";
            this.guestIDBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDBox.TabIndex = 5;
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Location = new System.Drawing.Point(6, 57);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberBox.TabIndex = 6;
            // 
            // checkInDateBox
            // 
            this.checkInDateBox.Location = new System.Drawing.Point(6, 96);
            this.checkInDateBox.Name = "checkInDateBox";
            this.checkInDateBox.Size = new System.Drawing.Size(100, 20);
            this.checkInDateBox.TabIndex = 7;
            this.checkInDateBox.Text = "YYYY-MM-DD";
            // 
            // checkOutDateBox
            // 
            this.checkOutDateBox.Location = new System.Drawing.Point(6, 135);
            this.checkOutDateBox.Name = "checkOutDateBox";
            this.checkOutDateBox.Size = new System.Drawing.Size(100, 20);
            this.checkOutDateBox.TabIndex = 17;
            this.checkOutDateBox.Text = "YYYY-MM-DD";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(6, 174);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
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
            this.reservationIDPanel.Location = new System.Drawing.Point(3, 179);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(112, 47);
            this.reservationIDPanel.TabIndex = 38;
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
            this.dataGridView1.TabIndex = 36;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(10, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 38);
            this.viewButton.TabIndex = 32;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(10, 47);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 38);
            this.updateButton.TabIndex = 34;
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
            this.newButton.TabIndex = 33;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(10, 135);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 38);
            this.removeButton.TabIndex = 35;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // ReservationsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infosPanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.removeButton);
            this.Name = "ReservationsTab";
            this.Size = new System.Drawing.Size(872, 574);
            this.infosPanel.ResumeLayout(false);
            this.infosPanel.PerformLayout();
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infosPanel;
        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label checkInDateLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox reservationIDBox;
        private System.Windows.Forms.TextBox guestIDBox;
        private System.Windows.Forms.TextBox roomNumberBox;
        private System.Windows.Forms.TextBox checkInDateBox;
        private System.Windows.Forms.TextBox checkOutDateBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button removeButton;
    }
}
