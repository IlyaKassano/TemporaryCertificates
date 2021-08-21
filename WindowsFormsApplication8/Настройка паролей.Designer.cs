namespace WindowsFormsApplication5
{
    partial class Настройка_паролей
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Настройка_паролей));
			this.ChangePassButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NewPass = new System.Windows.Forms.TextBox();
			this.EqualPass = new System.Windows.Forms.TextBox();
			this.User = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CurrentPass = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ChangePassButton
			// 
			this.ChangePassButton.Location = new System.Drawing.Point(137, 177);
			this.ChangePassButton.MaximumSize = new System.Drawing.Size(137, 50);
			this.ChangePassButton.Name = "ChangePassButton";
			this.ChangePassButton.Size = new System.Drawing.Size(137, 23);
			this.ChangePassButton.TabIndex = 0;
			this.ChangePassButton.Text = "Изменить пароль";
			this.ChangePassButton.UseVisualStyleBackColor = true;
			this.ChangePassButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Пользователь";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Новый пароль:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Подтверждение\r\nпароля:";
			// 
			// NewPass
			// 
			this.NewPass.Location = new System.Drawing.Point(118, 95);
			this.NewPass.Name = "NewPass";
			this.NewPass.Size = new System.Drawing.Size(184, 20);
			this.NewPass.TabIndex = 5;
			// 
			// EqualPass
			// 
			this.EqualPass.Location = new System.Drawing.Point(118, 138);
			this.EqualPass.Name = "EqualPass";
			this.EqualPass.Size = new System.Drawing.Size(184, 20);
			this.EqualPass.TabIndex = 6;
			// 
			// User
			// 
			this.User.FormattingEnabled = true;
			this.User.Location = new System.Drawing.Point(118, 9);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(184, 21);
			this.User.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Текущий пароль:";
			// 
			// CurrentPass
			// 
			this.CurrentPass.Location = new System.Drawing.Point(118, 53);
			this.CurrentPass.Name = "CurrentPass";
			this.CurrentPass.Size = new System.Drawing.Size(184, 20);
			this.CurrentPass.TabIndex = 9;
			// 
			// Настройка_паролей
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(317, 212);
			this.Controls.Add(this.CurrentPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.User);
			this.Controls.Add(this.EqualPass);
			this.Controls.Add(this.NewPass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChangePassButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Настройка_паролей";
			this.Text = "Настройка паролей";
			this.Load += new System.EventHandler(this.Настройка_паролей_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox EqualPass;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentPass;
    }
}