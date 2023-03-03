namespace HotelElina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ReservedStatus = new System.Windows.Forms.RadioButton();
            this.FreeStatus = new System.Windows.Forms.RadioButton();
            this.AccupiedStatus = new System.Windows.Forms.RadioButton();
            this.LeavingStatus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientsList = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNum = new System.Windows.Forms.Label();
            this.stlabel = new System.Windows.Forms.Label();
            this.CurrentStatusLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.GBDateOfEnter = new System.Windows.Forms.GroupBox();
            this.DateOfEnter = new System.Windows.Forms.Label();
            this.GBDateOfLeaving = new System.Windows.Forms.GroupBox();
            this.DateOfLeaving = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PictureOfClient = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ShowCardButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.AllStatuses = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).BeginInit();
            this.GBDateOfEnter.SuspendLayout();
            this.GBDateOfLeaving.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(444, 917);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(117, 25);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(219, 36);
            this.TimeLabel.TabIndex = 28;
            this.TimeLabel.Text = "00 : 00 : 00 AM";
            // 
            // ReservedStatus
            // 
            this.ReservedStatus.AutoSize = true;
            this.ReservedStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReservedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservedStatus.Location = new System.Drawing.Point(25, 253);
            this.ReservedStatus.Name = "ReservedStatus";
            this.ReservedStatus.Size = new System.Drawing.Size(285, 37);
            this.ReservedStatus.TabIndex = 30;
            this.ReservedStatus.TabStop = true;
            this.ReservedStatus.Text = "Зарезервировано";
            this.ReservedStatus.UseVisualStyleBackColor = false;
            this.ReservedStatus.CheckedChanged += new System.EventHandler(this.ReservedStatus_CheckedChanged);
            // 
            // FreeStatus
            // 
            this.FreeStatus.AutoSize = true;
            this.FreeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeStatus.Location = new System.Drawing.Point(25, 325);
            this.FreeStatus.Name = "FreeStatus";
            this.FreeStatus.Size = new System.Drawing.Size(180, 37);
            this.FreeStatus.TabIndex = 31;
            this.FreeStatus.TabStop = true;
            this.FreeStatus.Text = "Свободно";
            this.FreeStatus.UseVisualStyleBackColor = true;
            this.FreeStatus.CheckedChanged += new System.EventHandler(this.FreeStatus_CheckedChanged);
            // 
            // AccupiedStatus
            // 
            this.AccupiedStatus.AutoSize = true;
            this.AccupiedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccupiedStatus.Location = new System.Drawing.Point(25, 403);
            this.AccupiedStatus.Name = "AccupiedStatus";
            this.AccupiedStatus.Size = new System.Drawing.Size(141, 37);
            this.AccupiedStatus.TabIndex = 32;
            this.AccupiedStatus.TabStop = true;
            this.AccupiedStatus.Text = "Занято";
            this.AccupiedStatus.UseVisualStyleBackColor = true;
            this.AccupiedStatus.CheckedChanged += new System.EventHandler(this.AccupiedStatus_CheckedChanged);
            // 
            // LeavingStatus
            // 
            this.LeavingStatus.AutoSize = true;
            this.LeavingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeavingStatus.Location = new System.Drawing.Point(25, 479);
            this.LeavingStatus.Name = "LeavingStatus";
            this.LeavingStatus.Size = new System.Drawing.Size(251, 37);
            this.LeavingStatus.TabIndex = 33;
            this.LeavingStatus.TabStop = true;
            this.LeavingStatus.Text = "Выписываются";
            this.LeavingStatus.UseVisualStyleBackColor = true;
            this.LeavingStatus.CheckedChanged += new System.EventHandler(this.LeavingStatus_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 50);
            this.label2.TabIndex = 34;
            this.label2.Text = "СТАТУС";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter2.Location = new System.Drawing.Point(444, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(16, 917);
            this.splitter2.TabIndex = 36;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.Menu;
            this.splitter3.Location = new System.Drawing.Point(460, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(490, 917);
            this.splitter3.TabIndex = 37;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter4.Location = new System.Drawing.Point(950, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(18, 917);
            this.splitter4.TabIndex = 38;
            this.splitter4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(534, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 50);
            this.label3.TabIndex = 39;
            this.label3.Text = "СПИСОК ГОСТЕЙ";
            // 
            // ClientsList
            // 
            this.ClientsList.AllowUserToAddRows = false;
            this.ClientsList.AllowUserToDeleteRows = false;
            this.ClientsList.AllowUserToResizeColumns = false;
            this.ClientsList.AllowUserToResizeRows = false;
            this.ClientsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClientsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.Status,
            this.Room});
            this.ClientsList.Location = new System.Drawing.Point(479, 199);
            this.ClientsList.Margin = new System.Windows.Forms.Padding(6);
            this.ClientsList.MultiSelect = false;
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.ReadOnly = true;
            this.ClientsList.RowHeadersVisible = false;
            this.ClientsList.RowHeadersWidth = 82;
            this.ClientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsList.Size = new System.Drawing.Size(445, 677);
            this.ClientsList.TabIndex = 40;
            this.ClientsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsList_CellMouseDoubleClick);
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Имя";
            this.fullName.MinimumWidth = 10;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 120;
            // 
            // Room
            // 
            this.Room.HeaderText = "Номер";
            this.Room.MinimumWidth = 10;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 50;
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNum.Location = new System.Drawing.Point(1007, 132);
            this.RoomNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(220, 50);
            this.RoomNum.TabIndex = 41;
            this.RoomNum.Text = "НОМЕР №";
            // 
            // stlabel
            // 
            this.stlabel.AutoSize = true;
            this.stlabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stlabel.Location = new System.Drawing.Point(977, 467);
            this.stlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stlabel.Name = "stlabel";
            this.stlabel.Size = new System.Drawing.Size(131, 36);
            this.stlabel.TabIndex = 43;
            this.stlabel.Text = "СТАТУС:";
            // 
            // CurrentStatusLabel
            // 
            this.CurrentStatusLabel.AutoSize = true;
            this.CurrentStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentStatusLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentStatusLabel.Location = new System.Drawing.Point(1147, 464);
            this.CurrentStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CurrentStatusLabel.Name = "CurrentStatusLabel";
            this.CurrentStatusLabel.Size = new System.Drawing.Size(80, 44);
            this.CurrentStatusLabel.TabIndex = 44;
            this.CurrentStatusLabel.Text = "123";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(984, 515);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(86, 38);
            this.FullNameLabel.TabIndex = 45;
            this.FullNameLabel.Text = "ФИО";
            // 
            // GBDateOfEnter
            // 
            this.GBDateOfEnter.Controls.Add(this.DateOfEnter);
            this.GBDateOfEnter.Location = new System.Drawing.Point(977, 571);
            this.GBDateOfEnter.Margin = new System.Windows.Forms.Padding(6);
            this.GBDateOfEnter.Name = "GBDateOfEnter";
            this.GBDateOfEnter.Padding = new System.Windows.Forms.Padding(6);
            this.GBDateOfEnter.Size = new System.Drawing.Size(387, 77);
            this.GBDateOfEnter.TabIndex = 46;
            this.GBDateOfEnter.TabStop = false;
            this.GBDateOfEnter.Text = "Дата заезда:";
            // 
            // DateOfEnter
            // 
            this.DateOfEnter.AutoSize = true;
            this.DateOfEnter.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfEnter.Location = new System.Drawing.Point(69, 30);
            this.DateOfEnter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DateOfEnter.Name = "DateOfEnter";
            this.DateOfEnter.Size = new System.Drawing.Size(63, 35);
            this.DateOfEnter.TabIndex = 0;
            this.DateOfEnter.Text = "123";
            // 
            // GBDateOfLeaving
            // 
            this.GBDateOfLeaving.Controls.Add(this.DateOfLeaving);
            this.GBDateOfLeaving.Location = new System.Drawing.Point(984, 660);
            this.GBDateOfLeaving.Margin = new System.Windows.Forms.Padding(6);
            this.GBDateOfLeaving.Name = "GBDateOfLeaving";
            this.GBDateOfLeaving.Padding = new System.Windows.Forms.Padding(6);
            this.GBDateOfLeaving.Size = new System.Drawing.Size(400, 78);
            this.GBDateOfLeaving.TabIndex = 47;
            this.GBDateOfLeaving.TabStop = false;
            this.GBDateOfLeaving.Text = "Дата выезда:";
            // 
            // DateOfLeaving
            // 
            this.DateOfLeaving.AutoSize = true;
            this.DateOfLeaving.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfLeaving.Location = new System.Drawing.Point(61, 30);
            this.DateOfLeaving.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DateOfLeaving.Name = "DateOfLeaving";
            this.DateOfLeaving.Size = new System.Drawing.Size(63, 35);
            this.DateOfLeaving.TabIndex = 0;
            this.DateOfLeaving.Text = "123";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.SearchLabel);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(446, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(547, 74);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchButton.Location = new System.Drawing.Point(680, 13);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(52, 48);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackgroundImage = global::HotelElina.Properties.Resources.icons8_search_22;
            this.search.Location = new System.Drawing.Point(482, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 70);
            this.search.TabIndex = 49;
            this.search.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(12, 23);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(108, 30);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Поиск...";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(4, 23);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(500, 30);
            this.SearchTextBox.TabIndex = 8;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // PictureOfClient
            // 
            this.PictureOfClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureOfClient.BackColor = System.Drawing.SystemColors.Window;
            this.PictureOfClient.ImageLocation = "";
            this.PictureOfClient.Location = new System.Drawing.Point(1074, 188);
            this.PictureOfClient.Margin = new System.Windows.Forms.Padding(6);
            this.PictureOfClient.Name = "PictureOfClient";
            this.PictureOfClient.Size = new System.Drawing.Size(256, 244);
            this.PictureOfClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureOfClient.TabIndex = 42;
            this.PictureOfClient.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelElina.Properties.Resources.icons8_time_22;
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 84);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotelElina.Properties.Resources.icons8_squared_menu_30;
            this.pictureBox5.Location = new System.Drawing.Point(25, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 73);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(49, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(360, 58);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // ShowCardButton
            // 
            this.ShowCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCardButton.Location = new System.Drawing.Point(1051, 776);
            this.ShowCardButton.Name = "ShowCardButton";
            this.ShowCardButton.Size = new System.Drawing.Size(276, 76);
            this.ShowCardButton.TabIndex = 50;
            this.ShowCardButton.Text = "Просмотр карточки";
            this.ShowCardButton.UseVisualStyleBackColor = true;
            this.ShowCardButton.Click += new System.EventHandler(this.ShowCardButton_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AllStatuses
            // 
            this.AllStatuses.AutoSize = true;
            this.AllStatuses.Checked = true;
            this.AllStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllStatuses.Location = new System.Drawing.Point(25, 544);
            this.AllStatuses.Margin = new System.Windows.Forms.Padding(6);
            this.AllStatuses.Name = "AllStatuses";
            this.AllStatuses.Size = new System.Drawing.Size(88, 34);
            this.AllStatuses.TabIndex = 51;
            this.AllStatuses.TabStop = true;
            this.AllStatuses.Text = "Все";
            this.AllStatuses.UseVisualStyleBackColor = true;
            this.AllStatuses.CheckedChanged += new System.EventHandler(this.AllStatuses_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 917);
            this.Controls.Add(this.AllStatuses);
            this.Controls.Add(this.ShowCardButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBDateOfLeaving);
            this.Controls.Add(this.GBDateOfEnter);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.CurrentStatusLabel);
            this.Controls.Add(this.stlabel);
            this.Controls.Add(this.PictureOfClient);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.ClientsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeavingStatus);
            this.Controls.Add(this.AccupiedStatus);
            this.Controls.Add(this.FreeStatus);
            this.Controls.Add(this.ReservedStatus);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsList)).EndInit();
            this.GBDateOfEnter.ResumeLayout(false);
            this.GBDateOfEnter.PerformLayout();
            this.GBDateOfLeaving.ResumeLayout(false);
            this.GBDateOfLeaving.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton ReservedStatus;
        private System.Windows.Forms.RadioButton FreeStatus;
        private System.Windows.Forms.RadioButton AccupiedStatus;
        private System.Windows.Forms.RadioButton LeavingStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ClientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.Label RoomNum;
        private System.Windows.Forms.PictureBox PictureOfClient;
        private System.Windows.Forms.Label stlabel;
        private System.Windows.Forms.Label CurrentStatusLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.GroupBox GBDateOfEnter;
        private System.Windows.Forms.Label DateOfEnter;
        private System.Windows.Forms.GroupBox GBDateOfLeaving;
        private System.Windows.Forms.Label DateOfLeaving;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button ShowCardButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton AllStatuses;
    }
}

