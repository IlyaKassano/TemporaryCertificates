namespace TemporaryCertificates
{
    partial class Авторизация
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
			this.HeadLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.User = new System.Windows.Forms.ComboBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.ShowPassword = new System.Windows.Forms.CheckBox();
			this.EnterButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HeadLabel
			// 
			this.HeadLabel.AutoSize = true;
			this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HeadLabel.Location = new System.Drawing.Point(24, 19);
			this.HeadLabel.Name = "HeadLabel";
			this.HeadLabel.Size = new System.Drawing.Size(237, 39);
			this.HeadLabel.TabIndex = 0;
			this.HeadLabel.Text = "Внимание! Для работы с программой \r\n\"Выдача временных свидетельств\"\r\nнеобходима а" +
    "вторизация";
			this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пользователь";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Пароль";
			// 
			// User
			// 
			this.User.FormattingEnabled = true;
			this.User.Location = new System.Drawing.Point(98, 79);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(174, 21);
			this.User.TabIndex = 6;
			this.User.SelectedIndexChanged += new System.EventHandler(this.User_SelectedIndexChanged);
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(98, 120);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(174, 20);
			this.Password.TabIndex = 7;
			this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// ShowPassword
			// 
			this.ShowPassword.AutoSize = true;
			this.ShowPassword.Location = new System.Drawing.Point(15, 156);
			this.ShowPassword.Name = "ShowPassword";
			this.ShowPassword.Size = new System.Drawing.Size(127, 17);
			this.ShowPassword.TabIndex = 8;
			this.ShowPassword.Text = "Отображать пароль";
			this.ShowPassword.UseVisualStyleBackColor = true;
			this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
			// 
			// EnterButton
			// 
			this.EnterButton.Location = new System.Drawing.Point(145, 198);
			this.EnterButton.MaximumSize = new System.Drawing.Size(127, 38);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.Size = new System.Drawing.Size(127, 38);
			this.EnterButton.TabIndex = 4;
			this.EnterButton.Text = "Вход";
			this.EnterButton.UseVisualStyleBackColor = true;
			this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(15, 198);
			this.CloseButton.MaximumSize = new System.Drawing.Size(127, 38);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(127, 38);
			this.CloseButton.TabIndex = 5;
			this.CloseButton.Text = "Закрыть";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// Авторизация
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(284, 248);
			this.Controls.Add(this.ShowPassword);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.User);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.EnterButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HeadLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Авторизация";
			this.Text = "Авторизация";
			this.Load += new System.EventHandler(this.Авторизация_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CloseButton;
    }
}