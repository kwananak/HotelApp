namespace HotelApp
{
    partial class RoomsTab
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
            this.roomNumberPanel = new System.Windows.Forms.Panel();
            this.getButton = new System.Windows.Forms.Button();
            this.roomNumberBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.infosPanel = new System.Windows.Forms.Panel();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.guestIDBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.roomNumberPanel.SuspendLayout();
            this.infosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNumberPanel
            // 
            this.roomNumberPanel.Controls.Add(this.getButton);
            this.roomNumberPanel.Controls.Add(this.roomNumberBox);
            this.roomNumberPanel.Controls.Add(this.roomNumberLabel);
            this.roomNumberPanel.Location = new System.Drawing.Point(3, 179);
            this.roomNumberPanel.Name = "roomNumberPanel";
            this.roomNumberPanel.Size = new System.Drawing.Size(112, 47);
            this.roomNumberPanel.TabIndex = 31;
            this.roomNumberPanel.Visible = false;
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
            // roomNumberBox
            // 
            this.roomNumberBox.Location = new System.Drawing.Point(7, 21);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(64, 20);
            this.roomNumberBox.TabIndex = 1;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomNumberLabel.Location = new System.Drawing.Point(4, 5);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNumberLabel.TabIndex = 0;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // infosPanel
            // 
            this.infosPanel.Controls.Add(this.guestIDLabel);
            this.infosPanel.Controls.Add(this.confirmButton);
            this.infosPanel.Controls.Add(this.guestIDBox);
            this.infosPanel.Controls.Add(this.notesLabel);
            this.infosPanel.Controls.Add(this.notesBox);
            this.infosPanel.Location = new System.Drawing.Point(3, 227);
            this.infosPanel.Name = "infosPanel";
            this.infosPanel.Size = new System.Drawing.Size(112, 187);
            this.infosPanel.TabIndex = 30;
            this.infosPanel.Visible = false;
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guestIDLabel.Location = new System.Drawing.Point(3, 0);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 12;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Goldenrod;
            this.confirmButton.Location = new System.Drawing.Point(17, 159);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // guestIDBox
            // 
            this.guestIDBox.Location = new System.Drawing.Point(7, 16);
            this.guestIDBox.Name = "guestIDBox";
            this.guestIDBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDBox.TabIndex = 5;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notesLabel.Location = new System.Drawing.Point(4, 39);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 13;
            this.notesLabel.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(6, 55);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(100, 98);
            this.notesBox.TabIndex = 6;
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
            // RoomsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomNumberPanel);
            this.Controls.Add(this.infosPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.viewButton);
            this.Name = "RoomsTab";
            this.Size = new System.Drawing.Size(872, 574);
            this.roomNumberPanel.ResumeLayout(false);
            this.roomNumberPanel.PerformLayout();
            this.infosPanel.ResumeLayout(false);
            this.infosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomNumberPanel;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox roomNumberBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Panel infosPanel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox guestIDBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button viewButton;
    }
}
