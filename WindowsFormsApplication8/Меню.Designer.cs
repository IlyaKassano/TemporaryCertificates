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
			this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.представителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оффисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
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
            this.данныеToolStripMenuItem,
            this.журналыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem3});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip1.Size = new System.Drawing.Size(82, 361);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "Меню";
			// 
			// данныеToolStripMenuItem
			// 
			this.данныеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.представителиToolStripMenuItem,
            this.оффисToolStripMenuItem});
			this.данныеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.данныеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
			this.данныеToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.данныеToolStripMenuItem.Size = new System.Drawing.Size(81, 71);
			this.данныеToolStripMenuItem.Text = "Данные";
			this.данныеToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.данныеToolStripMenuItem.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// клиентыToolStripMenuItem
			// 
			this.клиентыToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.клиентыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
			this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.клиентыToolStripMenuItem.Text = "Клиенты";
			this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click_1);
			// 
			// представителиToolStripMenuItem
			// 
			this.представителиToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.представителиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.представителиToolStripMenuItem.Name = "представителиToolStripMenuItem";
			this.представителиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.представителиToolStripMenuItem.Text = "Представители";
			this.представителиToolStripMenuItem.Click += new System.EventHandler(this.представителиToolStripMenuItem_Click);
			// 
			// оффисToolStripMenuItem
			// 
			this.оффисToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.оффисToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.оффисToolStripMenuItem.Name = "оффисToolStripMenuItem";
			this.оффисToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.оффисToolStripMenuItem.Text = "Офисы";
			this.оффисToolStripMenuItem.Click += new System.EventHandler(this.оффисToolStripMenuItem_Click);
			// 
			// журналыToolStripMenuItem
			// 
			this.журналыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.журналыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
			this.журналыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.журналыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.журналыToolStripMenuItem.Name = "журналыToolStripMenuItem";
			this.журналыToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.журналыToolStripMenuItem.Size = new System.Drawing.Size(81, 71);
			this.журналыToolStripMenuItem.Text = "Журналы";
			this.журналыToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.журналыToolStripMenuItem.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 22);
			this.toolStripMenuItem2.Text = "Временные свидетельства";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 71);
			this.toolStripMenuItem1.Text = "Запросы";
			this.toolStripMenuItem1.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.toolStripMenuItem1.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// поискToolStripMenuItem
			// 
			this.поискToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
			this.поискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.поискToolStripMenuItem.Text = "Поиск";
			this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click_1);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
			this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem,
            this.toolStripMenuItem9});
			this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.toolStripMenuItem7.Size = new System.Drawing.Size(81, 71);
			this.toolStripMenuItem7.Text = "Справка";
			this.toolStripMenuItem7.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.toolStripMenuItem7.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// просмотрСправкиToolStripMenuItem
			// 
			this.просмотрСправкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
			this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
			this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click_1);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(189, 22);
			this.toolStripMenuItem9.Text = "О программе";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
			this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.параметрыToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
			this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(4, 50, 4, 0);
			this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 71);
			this.toolStripMenuItem3.Text = "Прочее";
			this.toolStripMenuItem3.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
			this.toolStripMenuItem3.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItem4.Text = "Сменить пользователя";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// параметрыToolStripMenuItem
			// 
			this.параметрыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
			this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.параметрыToolStripMenuItem.Text = "Параметры";
			this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItem5.Text = "Настройка паролей";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.настройкаПаролейToolStripMenuItem1_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItem6.Text = "Выйти из программы";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(346, 320);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "Сбросить настройки";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Меню
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources._272038;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(480, 361);
			this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ToolStripMenuItem журналыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem представителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оффисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
		private System.Windows.Forms.Button button1;
	}
}

