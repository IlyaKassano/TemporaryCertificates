namespace WindowsFormsApplication5
{
    partial class Меню
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Меню));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.TabPrimaryData = new System.Windows.Forms.ToolStripMenuItem();
			this.DataClient = new System.Windows.Forms.ToolStripMenuItem();
			this.DataRepres = new System.Windows.Forms.ToolStripMenuItem();
			this.DataOffice = new System.Windows.Forms.ToolStripMenuItem();
			this.TabJournal = new System.Windows.Forms.ToolStripMenuItem();
			this.JournalTempSert = new System.Windows.Forms.ToolStripMenuItem();
			this.TabRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.RequestFind = new System.Windows.Forms.ToolStripMenuItem();
			this.TabReference = new System.Windows.Forms.ToolStripMenuItem();
			this.Help = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
			this.TabOther = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeUser = new System.Windows.Forms.ToolStripMenuItem();
			this.Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ResetSettings = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabPrimaryData,
            this.TabJournal,
            this.TabRequest,
            this.TabReference,
            this.TabOther});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip1.Size = new System.Drawing.Size(82, 361);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "Меню";
			// 
			// TabPrimaryData
			// 
			this.TabPrimaryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.TabPrimaryData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataClient,
            this.DataRepres,
            this.DataOffice});
			this.TabPrimaryData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TabPrimaryData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.TabPrimaryData.Name = "TabPrimaryData";
			this.TabPrimaryData.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.TabPrimaryData.Size = new System.Drawing.Size(81, 71);
			this.TabPrimaryData.Text = "Данные";
			this.TabPrimaryData.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.TabPrimaryData.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// DataClient
			// 
			this.DataClient.BackColor = System.Drawing.Color.White;
			this.DataClient.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.DataClient.Name = "DataClient";
			this.DataClient.Size = new System.Drawing.Size(180, 22);
			this.DataClient.Text = "Клиенты";
			this.DataClient.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click_1);
			// 
			// DataRepres
			// 
			this.DataRepres.BackColor = System.Drawing.Color.White;
			this.DataRepres.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.DataRepres.Name = "DataRepres";
			this.DataRepres.Size = new System.Drawing.Size(180, 22);
			this.DataRepres.Text = "Представители";
			this.DataRepres.Click += new System.EventHandler(this.представителиToolStripMenuItem_Click);
			// 
			// DataOffice
			// 
			this.DataOffice.BackColor = System.Drawing.Color.White;
			this.DataOffice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.DataOffice.Name = "DataOffice";
			this.DataOffice.Size = new System.Drawing.Size(180, 22);
			this.DataOffice.Text = "Офисы";
			this.DataOffice.Click += new System.EventHandler(this.оффисToolStripMenuItem_Click);
			// 
			// TabJournal
			// 
			this.TabJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.TabJournal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JournalTempSert});
			this.TabJournal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TabJournal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.TabJournal.Name = "TabJournal";
			this.TabJournal.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.TabJournal.Size = new System.Drawing.Size(81, 71);
			this.TabJournal.Text = "Журналы";
			this.TabJournal.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.TabJournal.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// JournalTempSert
			// 
			this.JournalTempSert.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.JournalTempSert.Name = "JournalTempSert";
			this.JournalTempSert.Size = new System.Drawing.Size(233, 22);
			this.JournalTempSert.Text = "Временные свидетельства";
			this.JournalTempSert.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// TabRequest
			// 
			this.TabRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.TabRequest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RequestFind});
			this.TabRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TabRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.TabRequest.Name = "TabRequest";
			this.TabRequest.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.TabRequest.Size = new System.Drawing.Size(81, 71);
			this.TabRequest.Text = "Запросы";
			this.TabRequest.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.TabRequest.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// RequestFind
			// 
			this.RequestFind.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.RequestFind.Name = "RequestFind";
			this.RequestFind.Size = new System.Drawing.Size(180, 22);
			this.RequestFind.Text = "Поиск";
			this.RequestFind.Click += new System.EventHandler(this.поискToolStripMenuItem_Click_1);
			// 
			// TabReference
			// 
			this.TabReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.TabReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help,
            this.AboutProgram});
			this.TabReference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TabReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.TabReference.Name = "TabReference";
			this.TabReference.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.TabReference.Size = new System.Drawing.Size(81, 71);
			this.TabReference.Text = "Справка";
			this.TabReference.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.TabReference.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// Help
			// 
			this.Help.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Help.Name = "Help";
			this.Help.Size = new System.Drawing.Size(189, 22);
			this.Help.Text = "Просмотр справки";
			this.Help.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click_1);
			// 
			// AboutProgram
			// 
			this.AboutProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.AboutProgram.Name = "AboutProgram";
			this.AboutProgram.Size = new System.Drawing.Size(189, 22);
			this.AboutProgram.Text = "О программе";
			this.AboutProgram.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// TabOther
			// 
			this.TabOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
			this.TabOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeUser,
            this.Settings,
            this.ChangePassword,
            this.Exit});
			this.TabOther.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TabOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.TabOther.Name = "TabOther";
			this.TabOther.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.TabOther.Size = new System.Drawing.Size(81, 71);
			this.TabOther.Text = "Прочее";
			this.TabOther.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.TabOther.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// ChangeUser
			// 
			this.ChangeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.ChangeUser.Name = "ChangeUser";
			this.ChangeUser.Size = new System.Drawing.Size(213, 22);
			this.ChangeUser.Text = "Сменить пользователя";
			this.ChangeUser.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// Settings
			// 
			this.Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(213, 22);
			this.Settings.Text = "Настройки";
			this.Settings.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
			// 
			// ChangePassword
			// 
			this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.ChangePassword.Name = "ChangePassword";
			this.ChangePassword.Size = new System.Drawing.Size(213, 22);
			this.ChangePassword.Text = "Изменить пароль";
			this.ChangePassword.Click += new System.EventHandler(this.настройкаПаролейToolStripMenuItem1_Click);
			// 
			// Exit
			// 
			this.Exit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(213, 22);
			this.Exit.Text = "Выйти из программы";
			this.Exit.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.Makc_m;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(203, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(278, 129);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// ResetSettings
			// 
			this.ResetSettings.Location = new System.Drawing.Point(346, 320);
			this.ResetSettings.Name = "ResetSettings";
			this.ResetSettings.Size = new System.Drawing.Size(122, 29);
			this.ResetSettings.TabIndex = 2;
			this.ResetSettings.Text = "Сбросить настройки";
			this.ResetSettings.UseVisualStyleBackColor = true;
			this.ResetSettings.Click += new System.EventHandler(this.button1_Click);
			// 
			// Меню
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources._272038;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(480, 361);
			this.Controls.Add(this.ResetSettings);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(496, 500);
			this.MinimumSize = new System.Drawing.Size(496, 400);
			this.Name = "Меню";
			this.Text = "Выдача временных свидетельств";
			this.Load += new System.EventHandler(this.Меню_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TabJournal;
        private System.Windows.Forms.ToolStripMenuItem TabPrimaryData;
        private System.Windows.Forms.ToolStripMenuItem DataRepres;
        private System.Windows.Forms.ToolStripMenuItem DataOffice;
		private System.Windows.Forms.ToolStripMenuItem DataClient;
		private System.Windows.Forms.ToolStripMenuItem TabRequest;
		private System.Windows.Forms.ToolStripMenuItem JournalTempSert;
		private System.Windows.Forms.ToolStripMenuItem RequestFind;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem TabReference;
		private System.Windows.Forms.ToolStripMenuItem AboutProgram;
		private System.Windows.Forms.ToolStripMenuItem TabOther;
		private System.Windows.Forms.ToolStripMenuItem ChangeUser;
		private System.Windows.Forms.ToolStripMenuItem ChangePassword;
		private System.Windows.Forms.ToolStripMenuItem Exit;
		private System.Windows.Forms.ToolStripMenuItem Help;
		private System.Windows.Forms.ToolStripMenuItem Settings;
		private System.Windows.Forms.Button ResetSettings;
	}
}

