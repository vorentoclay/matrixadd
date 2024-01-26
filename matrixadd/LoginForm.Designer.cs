namespace matrixadd
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RegisterLable = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.nameuser = new System.Windows.Forms.TextBox();
            this.Autoriz = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginPanel.Controls.Add(this.RegisterLable);
            this.LoginPanel.Controls.Add(this.password);
            this.LoginPanel.Controls.Add(this.ButtonLogin);
            this.LoginPanel.Controls.Add(this.nameuser);
            this.LoginPanel.Controls.Add(this.Autoriz);
            this.LoginPanel.Controls.Add(this.Close);
            this.LoginPanel.Controls.Add(this.mainPanel);
            this.LoginPanel.Location = new System.Drawing.Point(-1, -5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(833, 659);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // RegisterLable
            // 
            this.RegisterLable.BackColor = System.Drawing.Color.Black;
            this.RegisterLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterLable.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterLable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RegisterLable.Location = new System.Drawing.Point(41, 598);
            this.RegisterLable.Name = "RegisterLable";
            this.RegisterLable.Size = new System.Drawing.Size(737, 46);
            this.RegisterLable.TabIndex = 6;
            this.RegisterLable.Text = "Нет аккаунта? Вы можете создать его -->";
            this.RegisterLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegisterLable.Click += new System.EventHandler(this.RegisterLable_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(200, 366);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(413, 42);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Cascadia Code SemiLight", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonLogin.Location = new System.Drawing.Point(283, 497);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(250, 74);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // nameuser
            // 
            this.nameuser.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameuser.Location = new System.Drawing.Point(200, 263);
            this.nameuser.Multiline = true;
            this.nameuser.Name = "nameuser";
            this.nameuser.Size = new System.Drawing.Size(413, 75);
            this.nameuser.TabIndex = 7;
            this.nameuser.TextChanged += new System.EventHandler(this.nameuser_TextChanged);
            this.nameuser.Enter += new System.EventHandler(this.nameuser_Enter);
            this.nameuser.Leave += new System.EventHandler(this.nameuser_Leave);
            // 
            // Autoriz
            // 
            this.Autoriz.AutoSize = true;
            this.Autoriz.Font = new System.Drawing.Font("Linerama", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Autoriz.ForeColor = System.Drawing.Color.LawnGreen;
            this.Autoriz.Location = new System.Drawing.Point(247, 161);
            this.Autoriz.Name = "Autoriz";
            this.Autoriz.Size = new System.Drawing.Size(309, 65);
            this.Autoriz.TabIndex = 2;
            this.Autoriz.Text = "Авторизация";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Location = new System.Drawing.Point(788, 14);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 36);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPanel.Font = new System.Drawing.Font("Linerama", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(833, 147);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Text = "Сложение матриц";
            this.mainPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label mainPanel;
        private new System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Autoriz;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox nameuser;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label RegisterLable;
    }
}

