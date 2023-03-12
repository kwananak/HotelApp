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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.hotelAppDataSet = new HotelApp.HotelAppDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new HotelApp.HotelAppDataSetTableAdapters.EmployeesTableAdapter();
            this.guestsTableAdapter1 = new HotelApp.HotelAppDataSetTableAdapters.GuestsTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.reservationsTab = new HotelApp.ReservationsTab();
            this.roomsTab = new HotelApp.RoomsTab();
            this.employeesTab = new HotelApp.EmployeesTab();
            this.guestsTab = new HotelApp.GuestsTab();
            this.tasksTab = new HotelApp.TasksTab();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello <Placeholder>!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tasks";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Guests";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 94);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rooms";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(34, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 94);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reservations";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(34, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 94);
            this.button5.TabIndex = 5;
            this.button5.Text = "Employees";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(13, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // reservationsTab
            // 
            this.reservationsTab.Location = new System.Drawing.Point(253, 120);
            this.reservationsTab.Name = "reservationsTab";
            this.reservationsTab.Size = new System.Drawing.Size(872, 574);
            this.reservationsTab.TabIndex = 8;
            this.reservationsTab.Visible = false;
            // 
            // roomsTab
            // 
            this.roomsTab.Location = new System.Drawing.Point(253, 120);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Size = new System.Drawing.Size(877, 575);
            this.roomsTab.TabIndex = 7;
            this.roomsTab.Visible = false;
            // 
            // employeesTab
            // 
            this.employeesTab.Location = new System.Drawing.Point(253, 120);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Size = new System.Drawing.Size(877, 574);
            this.employeesTab.TabIndex = 1;
            this.employeesTab.Visible = false;
            // 
            // guestsTab
            // 
            this.guestsTab.Location = new System.Drawing.Point(253, 120);
            this.guestsTab.Name = "guestsTab";
            this.guestsTab.Size = new System.Drawing.Size(870, 571);
            this.guestsTab.TabIndex = 0;
            this.guestsTab.Visible = false;
            // 
            // todaysTasksTab
            // 
            this.tasksTab.Location = new System.Drawing.Point(253, 120);
            this.tasksTab.Name = "todaysTasksTab";
            this.tasksTab.Size = new System.Drawing.Size(872, 574);
            this.tasksTab.TabIndex = 9;
            this.tasksTab.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 714);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationsTab);
            this.Controls.Add(this.roomsTab);
            this.Controls.Add(this.employeesTab);
            this.Controls.Add(this.guestsTab);
            this.Controls.Add(this.tasksTab);
            this.Name = "MainPage";
            this.Text = "Hotel App";
            ((System.ComponentModel.ISupportInitialize)(this.hotelAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private HotelAppDataSet hotelAppDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HotelAppDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private HotelAppDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GuestsTab guestsTab;
        private EmployeesTab employeesTab;
        private System.Windows.Forms.Button button6;
        private RoomsTab roomsTab;
        private ReservationsTab reservationsTab;
        private TasksTab tasksTab;
    }
}