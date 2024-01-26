namespace matrixadd
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Label();
            this.matrix4 = new System.Windows.Forms.Button();
            this.matrix3 = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel.Controls.Add(this.Back);
            this.Panel.Controls.Add(this.matrix4);
            this.Panel.Controls.Add(this.matrix3);
            this.Panel.Controls.Add(this.matrix2);
            this.Panel.Controls.Add(this.Information);
            this.Panel.Controls.Add(this.Close);
            this.Panel.Controls.Add(this.mainPanel);
            this.Panel.Location = new System.Drawing.Point(-4, -3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(942, 664);
            this.Panel.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Cartoon 1471 Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back.Location = new System.Drawing.Point(10, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(139, 54);
            this.Back.TabIndex = 19;
            this.Back.Text = "<---";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // matrix4
            // 
            this.matrix4.BackColor = System.Drawing.Color.SeaGreen;
            this.matrix4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matrix4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.matrix4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrix4.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrix4.Location = new System.Drawing.Point(640, 507);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(223, 107);
            this.matrix4.TabIndex = 18;
            this.matrix4.Text = "Матрица 4х4";
            this.matrix4.UseVisualStyleBackColor = false;
            this.matrix4.Click += new System.EventHandler(this.matrix4_Click);
            // 
            // matrix3
            // 
            this.matrix3.BackColor = System.Drawing.Color.SeaGreen;
            this.matrix3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matrix3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.matrix3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrix3.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrix3.Location = new System.Drawing.Point(350, 507);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(223, 107);
            this.matrix3.TabIndex = 17;
            this.matrix3.Text = "Матрица 3х3";
            this.matrix3.UseVisualStyleBackColor = false;
            this.matrix3.Click += new System.EventHandler(this.matrix3_Click);
            // 
            // matrix2
            // 
            this.matrix2.BackColor = System.Drawing.Color.SeaGreen;
            this.matrix2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matrix2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.matrix2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrix2.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrix2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrix2.Location = new System.Drawing.Point(65, 507);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(223, 107);
            this.matrix2.TabIndex = 16;
            this.matrix2.Text = "Матрица 2х2";
            this.matrix2.UseVisualStyleBackColor = false;
            this.matrix2.Click += new System.EventHandler(this.matrix2_Click);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Information.Cursor = System.Windows.Forms.Cursors.Help;
            this.Information.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(29, 196);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(887, 262);
            this.Information.TabIndex = 15;
            this.Information.Text = resources.GetString("Information.Text");
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Location = new System.Drawing.Point(897, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 36);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mainPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainPanel.Font = new System.Drawing.Font("Linerama", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.ForeColor = System.Drawing.Color.LawnGreen;
            this.mainPanel.Location = new System.Drawing.Point(-31, 66);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(995, 90);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Text = "Сложение матриц";
            this.mainPanel.UseVisualStyleBackColor = true;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 658);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button mainPanel;
        private new System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button matrix2;
        private System.Windows.Forms.Button matrix4;
        private System.Windows.Forms.Button matrix3;
        private System.Windows.Forms.Label Back;
    }
}