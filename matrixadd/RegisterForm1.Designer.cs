namespace matrixadd
{
    partial class RegisterForm1
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
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.AutorizLable = new System.Windows.Forms.Label();
            this.userSurField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.nameuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.ButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.Ivory;
            this.ButtonRegister.Location = new System.Drawing.Point(197, 602);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(502, 78);
            this.ButtonRegister.TabIndex = 4;
            this.ButtonRegister.Text = "Зарегистрироваться";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Location = new System.Drawing.Point(858, 3);
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
            this.mainPanel.ForeColor = System.Drawing.Color.LawnGreen;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(901, 141);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Text = "Сложение матриц";
            this.mainPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.AutorizLable);
            this.LoginPanel.Controls.Add(this.userSurField);
            this.LoginPanel.Controls.Add(this.userNameField);
            this.LoginPanel.Controls.Add(this.password);
            this.LoginPanel.Controls.Add(this.Close);
            this.LoginPanel.Controls.Add(this.ButtonRegister);
            this.LoginPanel.Controls.Add(this.nameuser);
            this.LoginPanel.Controls.Add(this.mainPanel);
            this.LoginPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginPanel.Location = new System.Drawing.Point(-14, -3);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(901, 787);
            this.LoginPanel.TabIndex = 1;
            // 
            // AutorizLable
            // 
            this.AutorizLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutorizLable.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorizLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AutorizLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutorizLable.Location = new System.Drawing.Point(-122, 711);
            this.AutorizLable.Name = "AutorizLable";
            this.AutorizLable.Size = new System.Drawing.Size(1154, 49);
            this.AutorizLable.TabIndex = 8;
            this.AutorizLable.Text = "У вас уже есть аккаунт? Вы можете авторизоваться -->";
            this.AutorizLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutorizLable.Click += new System.EventHandler(this.AutorizLable_Click);
            // 
            // userSurField
            // 
            this.userSurField.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurField.Location = new System.Drawing.Point(463, 328);
            this.userSurField.Multiline = true;
            this.userSurField.Name = "userSurField";
            this.userSurField.Size = new System.Drawing.Size(348, 72);
            this.userSurField.TabIndex = 7;
            this.userSurField.Enter += new System.EventHandler(this.userSurField_Enter);
            this.userSurField.Leave += new System.EventHandler(this.userSurField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(98, 328);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(348, 72);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(463, 456);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(348, 39);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // nameuser
            // 
            this.nameuser.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameuser.Location = new System.Drawing.Point(98, 456);
            this.nameuser.Multiline = true;
            this.nameuser.Name = "nameuser";
            this.nameuser.Size = new System.Drawing.Size(348, 72);
            this.nameuser.TabIndex = 7;
            this.nameuser.Enter += new System.EventHandler(this.nameuser_Enter);
            this.nameuser.Leave += new System.EventHandler(this.nameuser_Leave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Linerama", 45F);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(0, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 141);
            this.label1.TabIndex = 9;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 776);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRegister;
        private new System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label mainPanel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox nameuser;
        private System.Windows.Forms.TextBox userSurField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label AutorizLable;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label1;
    }
}