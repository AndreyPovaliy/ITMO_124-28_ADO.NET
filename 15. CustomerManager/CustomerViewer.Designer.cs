namespace _15.CustomerManager
{
    partial class CustomerViewer
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
            this.customerList = new System.Windows.Forms.ComboBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(12, 27);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(162, 25);
            this.customerList.TabIndex = 0;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.ItemHeight = 17;
            this.orderlistBox.Location = new System.Drawing.Point(12, 59);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.Size = new System.Drawing.Size(162, 106);
            this.orderlistBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Фото";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(285, 26);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 25);
            this.textBoxname.TabIndex = 7;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(285, 57);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(100, 25);
            this.textBoxlastname.TabIndex = 8;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(285, 88);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(100, 25);
            this.textBoxmail.TabIndex = 9;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(285, 119);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(100, 25);
            this.textBoxage.TabIndex = 10;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(285, 150);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(100, 50);
            this.buttonFile.TabIndex = 11;
            this.buttonFile.Text = "Выберете файл...";
            this.buttonFile.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(432, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 70);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(554, 12);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(107, 70);
            this.buttonOut.TabIndex = 13;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(667, 59);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 39);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(667, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 37);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(432, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 77);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(23, 44);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(94, 21);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(208, 44);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(70, 21);
            this.OrderradioButton.TabIndex = 1;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(438, 190);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 17);
            this.labelid.TabIndex = 17;
            this.labelid.Text = "ID";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(474, 187);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(314, 25);
            this.textBoxCustomer.TabIndex = 18;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 237);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 27;
            this.GridView.Size = new System.Drawing.Size(800, 213);
            this.GridView.TabIndex = 19;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.Name = "CustomerViewer";
            this.Text = "Customer Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.DataGridView GridView;
    }
}

