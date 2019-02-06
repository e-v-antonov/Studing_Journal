namespace Studing_Journal
{
    partial class ConectionForm
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
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.lblServers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btConect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDataSource
            // 
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(12, 25);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(270, 21);
            this.cbDataSource.TabIndex = 0;
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Location = new System.Drawing.Point(12, 9);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(98, 13);
            this.lblServers.TabIndex = 1;
            this.lblServers.Text = "Список серверов:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(12, 49);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(128, 13);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // statusConect
            // 
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 201);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(292, 22);
            this.statusConect.TabIndex = 3;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            this.tsslStatus.Visible = false;
            // 
            // tbUserID
            // 
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(12, 65);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '*';
            this.tbUserID.Size = new System.Drawing.Size(270, 20);
            this.tbUserID.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 88);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(12, 104);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(270, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(12, 127);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(148, 13);
            this.lblDataSource.TabIndex = 7;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(12, 143);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(270, 21);
            this.cbInitialCatalog.TabIndex = 8;
            // 
            // btCheck
            // 
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(12, 170);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 9;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btConect
            // 
            this.btConect.Enabled = false;
            this.btConect.Location = new System.Drawing.Point(93, 170);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(108, 23);
            this.btConect.TabIndex = 10;
            this.btConect.Text = "Подключить";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(207, 170);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // ConectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 223);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConect);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.statusConect);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.cbDataSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подлючения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConectionForm_Load);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.StatusStrip statusConect;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCancel;
    }
}