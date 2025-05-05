namespace CourseWork
{
    partial class FromAuthorization
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
            this.authorization = new System.Windows.Forms.Label();
            this.entrance = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.prof = new System.Windows.Forms.PictureBox();
            this.LabelLog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.prof)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorization
            // 
            this.authorization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorization.AutoSize = true;
            this.authorization.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization.Location = new System.Drawing.Point(96, 26);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(213, 37);
            this.authorization.TabIndex = 0;
            this.authorization.Text = "Авторизация";
            // 
            // entrance
            // 
            this.entrance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entrance.Location = new System.Drawing.Point(111, 249);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(180, 40);
            this.entrance.TabIndex = 1;
            this.entrance.Text = "Войти";
            this.entrance.UseVisualStyleBackColor = true;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(141, 101);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 34);
            this.login.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(141, 176);
            this.pass.MaximumSize = new System.Drawing.Size(250, 100);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(250, 34);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            // 
            // LabelPass
            // 
            this.LabelPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPass.Location = new System.Drawing.Point(16, 176);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(120, 32);
            this.LabelPass.TabIndex = 5;
            this.LabelPass.Text = "Пароль:";
            // 
            // prof
            // 
            this.prof.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prof.BackgroundImage = global::CourseWork.Properties.Resources.Prof;
            this.prof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prof.Location = new System.Drawing.Point(0, 0);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(482, 225);
            this.prof.TabIndex = 6;
            this.prof.TabStop = false;
            // 
            // LabelLog
            // 
            this.LabelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelLog.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLog.Location = new System.Drawing.Point(21, 101);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(102, 32);
            this.LabelLog.TabIndex = 3;
            this.LabelLog.Text = "Логин:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.entrance);
            this.panel1.Controls.Add(this.authorization);
            this.panel1.Controls.Add(this.LabelPass);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.LabelLog);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 324);
            this.panel1.TabIndex = 7;
            // 
            // FromAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prof);
            this.Name = "FromAuthorization";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.FromAuthorization_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.prof)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.Button entrance;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.PictureBox prof;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Panel panel1;
    }
}

