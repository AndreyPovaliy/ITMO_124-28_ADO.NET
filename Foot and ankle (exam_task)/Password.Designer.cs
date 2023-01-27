namespace Foot_and_ankle__exam_task_
{
    partial class Password
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
            this.Login_groupBox = new System.Windows.Forms.GroupBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pswrd_label = new System.Windows.Forms.Label();
            this.Pswrd_Log_textBox = new System.Windows.Forms.TextBox();
            this.Pswrd_pswrd_textBox = new System.Windows.Forms.TextBox();
            this.Pwrd_ok = new System.Windows.Forms.Button();
            this.Pwrd_cancel = new System.Windows.Forms.Button();
            this.Login_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_groupBox
            // 
            this.Login_groupBox.Controls.Add(this.Pswrd_pswrd_textBox);
            this.Login_groupBox.Controls.Add(this.Pswrd_Log_textBox);
            this.Login_groupBox.Controls.Add(this.pswrd_label);
            this.Login_groupBox.Controls.Add(this.login_label);
            this.Login_groupBox.Location = new System.Drawing.Point(12, 25);
            this.Login_groupBox.Name = "Login_groupBox";
            this.Login_groupBox.Size = new System.Drawing.Size(458, 117);
            this.Login_groupBox.TabIndex = 0;
            this.Login_groupBox.TabStop = false;
            this.Login_groupBox.Text = "Введите ваши данные";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(47, 38);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(46, 17);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            // 
            // pswrd_label
            // 
            this.pswrd_label.AutoSize = true;
            this.pswrd_label.Location = new System.Drawing.Point(47, 75);
            this.pswrd_label.Name = "pswrd_label";
            this.pswrd_label.Size = new System.Drawing.Size(55, 17);
            this.pswrd_label.TabIndex = 1;
            this.pswrd_label.Text = "Пароль";
            // 
            // Pswrd_Log_textBox
            // 
            this.Pswrd_Log_textBox.Location = new System.Drawing.Point(121, 35);
            this.Pswrd_Log_textBox.Name = "Pswrd_Log_textBox";
            this.Pswrd_Log_textBox.Size = new System.Drawing.Size(284, 25);
            this.Pswrd_Log_textBox.TabIndex = 2;
            // 
            // Pswrd_pswrd_textBox
            // 
            this.Pswrd_pswrd_textBox.Location = new System.Drawing.Point(121, 72);
            this.Pswrd_pswrd_textBox.Name = "Pswrd_pswrd_textBox";
            this.Pswrd_pswrd_textBox.Size = new System.Drawing.Size(284, 25);
            this.Pswrd_pswrd_textBox.TabIndex = 3;
            // 
            // Pwrd_ok
            // 
            this.Pwrd_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Pwrd_ok.Location = new System.Drawing.Point(74, 158);
            this.Pwrd_ok.Name = "Pwrd_ok";
            this.Pwrd_ok.Size = new System.Drawing.Size(128, 33);
            this.Pwrd_ok.TabIndex = 1;
            this.Pwrd_ok.Text = "Войти";
            this.Pwrd_ok.UseVisualStyleBackColor = true;
            // 
            // Pwrd_cancel
            // 
            this.Pwrd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Pwrd_cancel.Location = new System.Drawing.Point(258, 158);
            this.Pwrd_cancel.Name = "Pwrd_cancel";
            this.Pwrd_cancel.Size = new System.Drawing.Size(140, 33);
            this.Pwrd_cancel.TabIndex = 2;
            this.Pwrd_cancel.Text = "Отмена";
            this.Pwrd_cancel.UseVisualStyleBackColor = true;
            this.Pwrd_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.Pwrd_cancel);
            this.Controls.Add(this.Pwrd_ok);
            this.Controls.Add(this.Login_groupBox);
            this.Name = "Password";
            this.Text = "Войти в систему";
            this.Login_groupBox.ResumeLayout(false);
            this.Login_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login_groupBox;
        private System.Windows.Forms.Label pswrd_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox Pswrd_pswrd_textBox;
        private System.Windows.Forms.TextBox Pswrd_Log_textBox;
        private System.Windows.Forms.Button Pwrd_ok;
        private System.Windows.Forms.Button Pwrd_cancel;
    }
}