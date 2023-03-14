namespace HotelApp
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.tasksButton = new System.Windows.Forms.Button();
            this.guestsButton = new System.Windows.Forms.Button();
            this.roomsButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.hotelAppDataSet = new HotelApp.HotelAppDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new HotelApp.HotelAppDataSetTableAdapters.EmployeesTableAdapter();
            this.guestsTableAdapter1 = new HotelApp.HotelAppDataSetTableAdapters.GuestsTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reservationsTab = new HotelApp.ReservationsTab();
            this.roomsTab = new HotelApp.RoomsTab();
            this.employeesTab = new HotelApp.EmployeesTab();
            this.guestsTab = new HotelApp.GuestsTab();
            this.tasksTab = new HotelApp.TasksTab();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingsLabel.Font = new System.Drawing.Font("Sitka Heading", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingsLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.greetingsLabel.Location = new System.Drawing.Point(495, 26);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(559, 81);
            this.greetingsLabel.TabIndex = 0;
            this.greetingsLabel.Text = "Hello <Placeholder>!";
            // 
            // tasksButton
            // 
            this.tasksButton.BackColor = System.Drawing.Color.Goldenrod;
            this.tasksButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tasksButton.Location = new System.Drawing.Point(34, 120);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(213, 94);
            this.tasksButton.TabIndex = 1;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.TasksButtonClick);
            // 
            // guestsButton
            // 
            this.guestsButton.BackColor = System.Drawing.Color.Goldenrod;
            this.guestsButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guestsButton.Location = new System.Drawing.Point(34, 243);
            this.guestsButton.Name = "guestsButton";
            this.guestsButton.Size = new System.Drawing.Size(213, 94);
            this.guestsButton.TabIndex = 2;
            this.guestsButton.Text = "Guests";
            this.guestsButton.UseVisualStyleBackColor = false;
            this.guestsButton.Click += new System.EventHandler(this.GuestsButtonClick);
            // 
            // roomsButton
            // 
            this.roomsButton.BackColor = System.Drawing.Color.Goldenrod;
            this.roomsButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomsButton.Location = new System.Drawing.Point(34, 361);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(213, 94);
            this.roomsButton.TabIndex = 3;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = false;
            this.roomsButton.Click += new System.EventHandler(this.RoomsButtonClick);
            // 
            // reservationsButton
            // 
            this.reservationsButton.BackColor = System.Drawing.Color.Goldenrod;
            this.reservationsButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationsButton.Location = new System.Drawing.Point(34, 481);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(213, 94);
            this.reservationsButton.TabIndex = 4;
            this.reservationsButton.Text = "Reservations";
            this.reservationsButton.UseVisualStyleBackColor = false;
            this.reservationsButton.Visible = false;
            this.reservationsButton.Click += new System.EventHandler(this.ReservationButtonClick);
            // 
            // employeesButton
            // 
            this.employeesButton.BackColor = System.Drawing.Color.Goldenrod;
            this.employeesButton.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeesButton.Location = new System.Drawing.Point(34, 608);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(213, 94);
            this.employeesButton.TabIndex = 5;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = false;
            this.employeesButton.Visible = false;
            this.employeesButton.Click += new System.EventHandler(this.EmployeeButtonClick);
            // 
            // hotelAppDataSet
            // 
            this.hotelAppDataSet.DataSetName = "HotelAppDataSet";
            this.hotelAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hotelAppDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // guestsTableAdapter1
            // 
            this.guestsTableAdapter1.ClearBeforeFill = true;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.IndianRed;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutButton.Location = new System.Drawing.Point(13, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(102, 43);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButtonClick);
            // 
            // reservationsTab
            // 
            this.reservationsTab.BackColor = System.Drawing.Color.Transparent;
            this.reservationsTab.Location = new System.Drawing.Point(253, 120);
            this.reservationsTab.Name = "reservationsTab";
            this.reservationsTab.Size = new System.Drawing.Size(872, 574);
            this.reservationsTab.TabIndex = 8;
            this.reservationsTab.Visible = false;
            // 
            // roomsTab
            // 
            this.roomsTab.BackColor = System.Drawing.Color.Transparent;
            this.roomsTab.Location = new System.Drawing.Point(253, 120);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Size = new System.Drawing.Size(877, 575);
            this.roomsTab.TabIndex = 7;
            this.roomsTab.Visible = false;
            // 
            // employeesTab
            // 
            this.employeesTab.BackColor = System.Drawing.Color.Transparent;
            this.employeesTab.Location = new System.Drawing.Point(253, 120);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Size = new System.Drawing.Size(877, 574);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Visible = false;
            // 
            // guestsTab
            // 
            this.guestsTab.BackColor = System.Drawing.Color.Transparent;
            this.guestsTab.Location = new System.Drawing.Point(253, 120);
            this.guestsTab.Name = "guestsTab";
            this.guestsTab.Size = new System.Drawing.Size(870, 571);
            this.guestsTab.TabIndex = 0;
            this.guestsTab.Visible = false;
            // 
            // tasksTab
            // 
            this.tasksTab.BackColor = System.Drawing.Color.Transparent;
            this.tasksTab.Location = new System.Drawing.Point(253, 120);
            this.tasksTab.Name = "tasksTab";
            this.tasksTab.Size = new System.Drawing.Size(872, 574);
            this.tasksTab.TabIndex = 9;
            this.tasksTab.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelApp.Properties.Resources.ao17ME73HFn3OydGBJAw__1__4uelt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 714);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.guestsButton);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.guestsTab);
            this.Controls.Add(this.tasksTab);
            this.Controls.Add(this.reservationsTab);
            this.Controls.Add(this.roomsTab);
            this.Controls.Add(this.employeesTab);
            this.Name = "MainPage";
            this.Text = "Hotel App";
            ((System.ComponentModel.ISupportInitialize)(this.hotelAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button guestsButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button employeesButton;
        private HotelAppDataSet hotelAppDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelAppDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private HotelAppDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GuestsTab guestsTab;
        private EmployeesTab employeesTab;
        private System.Windows.Forms.Button logoutButton;
        private RoomsTab roomsTab;
        private ReservationsTab reservationsTab;
        private TasksTab tasksTab;
    }
}