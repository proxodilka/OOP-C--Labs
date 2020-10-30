namespace Banrk_Lab
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerTypePicker = new System.Windows.Forms.ComboBox();
            this.workersListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.hiredateLabel = new System.Windows.Forms.Label();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.BirthdayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HireDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(45, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // workerTypePicker
            // 
            this.workerTypePicker.FormattingEnabled = true;
            this.workerTypePicker.Items.AddRange(new object[] {
            "Saler",
            "Chief"});
            this.workerTypePicker.Location = new System.Drawing.Point(12, 27);
            this.workerTypePicker.Name = "workerTypePicker";
            this.workerTypePicker.Size = new System.Drawing.Size(191, 21);
            this.workerTypePicker.TabIndex = 1;
            this.workerTypePicker.Text = "---Select Worker Type---";
            // 
            // workersListBox
            // 
            this.workersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersListBox.FormattingEnabled = true;
            this.workersListBox.Location = new System.Drawing.Point(236, 27);
            this.workersListBox.Name = "workersListBox";
            this.workersListBox.Size = new System.Drawing.Size(605, 446);
            this.workersListBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(65, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(138, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Tag = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Name";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(9, 92);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(45, 13);
            this.birthdayLabel.TabIndex = 999;
            this.birthdayLabel.Text = "Birthday";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(9, 118);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 999;
            this.salaryLabel.Text = "Salary";
            // 
            // hiredateLabel
            // 
            this.hiredateLabel.AutoSize = true;
            this.hiredateLabel.Location = new System.Drawing.Point(9, 144);
            this.hiredateLabel.Name = "hiredateLabel";
            this.hiredateLabel.Size = new System.Drawing.Size(50, 13);
            this.hiredateLabel.TabIndex = 999;
            this.hiredateLabel.Text = "Hire date";
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(12, 181);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(191, 23);
            this.addWorkerButton.TabIndex = 6;
            this.addWorkerButton.Text = "Add worker";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Location = new System.Drawing.Point(65, 92);
            this.BirthdayTextBox.Mask = "00/00/0000";
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(138, 20);
            this.BirthdayTextBox.TabIndex = 3;
            this.BirthdayTextBox.Tag = "birthday";
            this.BirthdayTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(65, 141);
            this.HireDateTextBox.Mask = "00/00/0000";
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(138, 20);
            this.HireDateTextBox.TabIndex = 5;
            this.HireDateTextBox.Tag = "hireDate";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(65, 118);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(138, 20);
            this.SalaryTextBox.TabIndex = 4;
            this.SalaryTextBox.Tag = "salary";
            this.SalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.addWorkerButton);
            this.Controls.Add(this.hiredateLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.workersListBox);
            this.Controls.Add(this.workerTypePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ComboBox workerTypePicker;
        private System.Windows.Forms.ListBox workersListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label hiredateLabel;
        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.MaskedTextBox BirthdayTextBox;
        private System.Windows.Forms.MaskedTextBox HireDateTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
    }
}

