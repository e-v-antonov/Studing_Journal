namespace Studing_Journal
{
    partial class StandartDepartmentForm
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
            this.pnManup = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.gbStandart = new System.Windows.Forms.GroupBox();
            this.lstbStandart = new System.Windows.Forms.ListBox();
            this.gbStandartManup = new System.Windows.Forms.GroupBox();
            this.tbStandartName = new System.Windows.Forms.TextBox();
            this.lblStandartName = new System.Windows.Forms.Label();
            this.btStandartInsert = new System.Windows.Forms.Button();
            this.btStandartUpdate = new System.Windows.Forms.Button();
            this.btStandartDelete = new System.Windows.Forms.Button();
            this.pnStandartSearch = new System.Windows.Forms.Panel();
            this.tbStandartSearch = new System.Windows.Forms.TextBox();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.pndgv = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.gbDepartmentManup = new System.Windows.Forms.GroupBox();
            this.pnDepartmentManup2 = new System.Windows.Forms.Panel();
            this.btDepartmentDelete = new System.Windows.Forms.Button();
            this.btDepartmentUpdate = new System.Windows.Forms.Button();
            this.btDepartmentInsert = new System.Windows.Forms.Button();
            this.pnDepartmentManup1 = new System.Windows.Forms.Panel();
            this.cbstandartDepartment = new System.Windows.Forms.ComboBox();
            this.lblStandartDepartment = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.mtbDepartmentNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblDepartmentNumber = new System.Windows.Forms.Label();
            this.gbDepartmentSearchFilter = new System.Windows.Forms.GroupBox();
            this.cbFilterStandart = new System.Windows.Forms.CheckBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbDepartmentSearch = new System.Windows.Forms.TextBox();
            this.pnManup.SuspendLayout();
            this.gbStandart.SuspendLayout();
            this.gbStandartManup.SuspendLayout();
            this.pnStandartSearch.SuspendLayout();
            this.gbDepartment.SuspendLayout();
            this.pndgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.gbDepartmentManup.SuspendLayout();
            this.pnDepartmentManup2.SuspendLayout();
            this.pnDepartmentManup1.SuspendLayout();
            this.gbDepartmentSearchFilter.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnManup
            // 
            this.pnManup.Controls.Add(this.btClose);
            this.pnManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManup.Location = new System.Drawing.Point(0, 559);
            this.pnManup.Margin = new System.Windows.Forms.Padding(4);
            this.pnManup.Name = "pnManup";
            this.pnManup.Size = new System.Drawing.Size(1067, 42);
            this.pnManup.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(967, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 42);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // gbStandart
            // 
            this.gbStandart.Controls.Add(this.lstbStandart);
            this.gbStandart.Controls.Add(this.gbStandartManup);
            this.gbStandart.Controls.Add(this.pnStandartSearch);
            this.gbStandart.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbStandart.Location = new System.Drawing.Point(0, 0);
            this.gbStandart.Margin = new System.Windows.Forms.Padding(4);
            this.gbStandart.Name = "gbStandart";
            this.gbStandart.Padding = new System.Windows.Forms.Padding(4);
            this.gbStandart.Size = new System.Drawing.Size(336, 559);
            this.gbStandart.TabIndex = 1;
            this.gbStandart.TabStop = false;
            this.gbStandart.Text = "Справочник \"Стандарты\"";
            // 
            // lstbStandart
            // 
            this.lstbStandart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbStandart.FormattingEnabled = true;
            this.lstbStandart.ItemHeight = 16;
            this.lstbStandart.Location = new System.Drawing.Point(4, 49);
            this.lstbStandart.Margin = new System.Windows.Forms.Padding(4);
            this.lstbStandart.Name = "lstbStandart";
            this.lstbStandart.Size = new System.Drawing.Size(328, 355);
            this.lstbStandart.TabIndex = 2;
            this.lstbStandart.SelectedValueChanged += new System.EventHandler(this.lstbStandart_SelectedValueChanged);
            // 
            // gbStandartManup
            // 
            this.gbStandartManup.Controls.Add(this.tbStandartName);
            this.gbStandartManup.Controls.Add(this.lblStandartName);
            this.gbStandartManup.Controls.Add(this.btStandartInsert);
            this.gbStandartManup.Controls.Add(this.btStandartUpdate);
            this.gbStandartManup.Controls.Add(this.btStandartDelete);
            this.gbStandartManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStandartManup.Location = new System.Drawing.Point(4, 404);
            this.gbStandartManup.Margin = new System.Windows.Forms.Padding(4);
            this.gbStandartManup.Name = "gbStandartManup";
            this.gbStandartManup.Padding = new System.Windows.Forms.Padding(4);
            this.gbStandartManup.Size = new System.Drawing.Size(328, 151);
            this.gbStandartManup.TabIndex = 1;
            this.gbStandartManup.TabStop = false;
            this.gbStandartManup.Text = "Манипулирование:";
            // 
            // tbStandartName
            // 
            this.tbStandartName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStandartName.Location = new System.Drawing.Point(4, 36);
            this.tbStandartName.Margin = new System.Windows.Forms.Padding(4);
            this.tbStandartName.Name = "tbStandartName";
            this.tbStandartName.Size = new System.Drawing.Size(320, 22);
            this.tbStandartName.TabIndex = 4;
            // 
            // lblStandartName
            // 
            this.lblStandartName.AutoSize = true;
            this.lblStandartName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStandartName.Location = new System.Drawing.Point(4, 19);
            this.lblStandartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStandartName.Name = "lblStandartName";
            this.lblStandartName.Size = new System.Drawing.Size(149, 17);
            this.lblStandartName.TabIndex = 3;
            this.lblStandartName.Text = "Название стандарта:";
            // 
            // btStandartInsert
            // 
            this.btStandartInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartInsert.Location = new System.Drawing.Point(4, 63);
            this.btStandartInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btStandartInsert.Name = "btStandartInsert";
            this.btStandartInsert.Size = new System.Drawing.Size(320, 28);
            this.btStandartInsert.TabIndex = 2;
            this.btStandartInsert.Text = "Добавить запись";
            this.btStandartInsert.UseVisualStyleBackColor = true;
            this.btStandartInsert.Click += new System.EventHandler(this.btStandartInsert_Click);
            // 
            // btStandartUpdate
            // 
            this.btStandartUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartUpdate.Location = new System.Drawing.Point(4, 91);
            this.btStandartUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btStandartUpdate.Name = "btStandartUpdate";
            this.btStandartUpdate.Size = new System.Drawing.Size(320, 28);
            this.btStandartUpdate.TabIndex = 1;
            this.btStandartUpdate.Text = "Изменить запись";
            this.btStandartUpdate.UseVisualStyleBackColor = true;
            this.btStandartUpdate.Click += new System.EventHandler(this.btStandartUpdate_Click);
            // 
            // btStandartDelete
            // 
            this.btStandartDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btStandartDelete.Location = new System.Drawing.Point(4, 119);
            this.btStandartDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btStandartDelete.Name = "btStandartDelete";
            this.btStandartDelete.Size = new System.Drawing.Size(320, 28);
            this.btStandartDelete.TabIndex = 0;
            this.btStandartDelete.Text = "Удалить запись";
            this.btStandartDelete.UseVisualStyleBackColor = true;
            this.btStandartDelete.Click += new System.EventHandler(this.btStandartDelete_Click);
            // 
            // pnStandartSearch
            // 
            this.pnStandartSearch.Controls.Add(this.tbStandartSearch);
            this.pnStandartSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStandartSearch.Location = new System.Drawing.Point(4, 19);
            this.pnStandartSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnStandartSearch.Name = "pnStandartSearch";
            this.pnStandartSearch.Size = new System.Drawing.Size(328, 30);
            this.pnStandartSearch.TabIndex = 0;
            // 
            // tbStandartSearch
            // 
            this.tbStandartSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStandartSearch.Location = new System.Drawing.Point(0, 0);
            this.tbStandartSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbStandartSearch.Name = "tbStandartSearch";
            this.tbStandartSearch.Size = new System.Drawing.Size(328, 22);
            this.tbStandartSearch.TabIndex = 0;
            this.tbStandartSearch.Text = "Введите название...";
            this.tbStandartSearch.TextChanged += new System.EventHandler(this.tbStandartSearch_TextChanged);
            this.tbStandartSearch.Enter += new System.EventHandler(this.tbStandartSearch_Enter);
            this.tbStandartSearch.Leave += new System.EventHandler(this.tbStandartSearch_Leave);
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.pndgv);
            this.gbDepartment.Controls.Add(this.gbDepartmentManup);
            this.gbDepartment.Controls.Add(this.gbDepartmentSearchFilter);
            this.gbDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDepartment.Location = new System.Drawing.Point(336, 0);
            this.gbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Padding = new System.Windows.Forms.Padding(4);
            this.gbDepartment.Size = new System.Drawing.Size(731, 559);
            this.gbDepartment.TabIndex = 2;
            this.gbDepartment.TabStop = false;
            this.gbDepartment.Text = "Справочник \"Специальности\"";
            // 
            // pndgv
            // 
            this.pndgv.Controls.Add(this.dgvDepartment);
            this.pndgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndgv.Location = new System.Drawing.Point(4, 68);
            this.pndgv.Margin = new System.Windows.Forms.Padding(4);
            this.pndgv.Name = "pndgv";
            this.pndgv.Size = new System.Drawing.Size(723, 336);
            this.pndgv.TabIndex = 3;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(723, 336);
            this.dgvDepartment.TabIndex = 1;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            // 
            // gbDepartmentManup
            // 
            this.gbDepartmentManup.Controls.Add(this.pnDepartmentManup2);
            this.gbDepartmentManup.Controls.Add(this.pnDepartmentManup1);
            this.gbDepartmentManup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDepartmentManup.Location = new System.Drawing.Point(4, 404);
            this.gbDepartmentManup.Margin = new System.Windows.Forms.Padding(4);
            this.gbDepartmentManup.Name = "gbDepartmentManup";
            this.gbDepartmentManup.Padding = new System.Windows.Forms.Padding(4);
            this.gbDepartmentManup.Size = new System.Drawing.Size(723, 151);
            this.gbDepartmentManup.TabIndex = 2;
            this.gbDepartmentManup.TabStop = false;
            this.gbDepartmentManup.Text = "Манипулирование:";
            // 
            // pnDepartmentManup2
            // 
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentDelete);
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentUpdate);
            this.pnDepartmentManup2.Controls.Add(this.btDepartmentInsert);
            this.pnDepartmentManup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDepartmentManup2.Location = new System.Drawing.Point(472, 19);
            this.pnDepartmentManup2.Margin = new System.Windows.Forms.Padding(4);
            this.pnDepartmentManup2.Name = "pnDepartmentManup2";
            this.pnDepartmentManup2.Size = new System.Drawing.Size(247, 128);
            this.pnDepartmentManup2.TabIndex = 1;
            // 
            // btDepartmentDelete
            // 
            this.btDepartmentDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentDelete.Location = new System.Drawing.Point(0, 56);
            this.btDepartmentDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDepartmentDelete.Name = "btDepartmentDelete";
            this.btDepartmentDelete.Size = new System.Drawing.Size(247, 28);
            this.btDepartmentDelete.TabIndex = 2;
            this.btDepartmentDelete.Text = "Удалить запись";
            this.btDepartmentDelete.UseVisualStyleBackColor = true;
            // 
            // btDepartmentUpdate
            // 
            this.btDepartmentUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentUpdate.Location = new System.Drawing.Point(0, 28);
            this.btDepartmentUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btDepartmentUpdate.Name = "btDepartmentUpdate";
            this.btDepartmentUpdate.Size = new System.Drawing.Size(247, 28);
            this.btDepartmentUpdate.TabIndex = 1;
            this.btDepartmentUpdate.Text = "Изменить запись";
            this.btDepartmentUpdate.UseVisualStyleBackColor = true;
            // 
            // btDepartmentInsert
            // 
            this.btDepartmentInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDepartmentInsert.Location = new System.Drawing.Point(0, 0);
            this.btDepartmentInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btDepartmentInsert.Name = "btDepartmentInsert";
            this.btDepartmentInsert.Size = new System.Drawing.Size(247, 28);
            this.btDepartmentInsert.TabIndex = 0;
            this.btDepartmentInsert.Text = "Добавить запись";
            this.btDepartmentInsert.UseVisualStyleBackColor = true;
            // 
            // pnDepartmentManup1
            // 
            this.pnDepartmentManup1.Controls.Add(this.cbstandartDepartment);
            this.pnDepartmentManup1.Controls.Add(this.lblStandartDepartment);
            this.pnDepartmentManup1.Controls.Add(this.tbDepartmentName);
            this.pnDepartmentManup1.Controls.Add(this.lblDepartmentName);
            this.pnDepartmentManup1.Controls.Add(this.mtbDepartmentNumber);
            this.pnDepartmentManup1.Controls.Add(this.lblDepartmentNumber);
            this.pnDepartmentManup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDepartmentManup1.Location = new System.Drawing.Point(4, 19);
            this.pnDepartmentManup1.Margin = new System.Windows.Forms.Padding(4);
            this.pnDepartmentManup1.Name = "pnDepartmentManup1";
            this.pnDepartmentManup1.Size = new System.Drawing.Size(468, 128);
            this.pnDepartmentManup1.TabIndex = 0;
            // 
            // cbstandartDepartment
            // 
            this.cbstandartDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbstandartDepartment.FormattingEnabled = true;
            this.cbstandartDepartment.Location = new System.Drawing.Point(0, 95);
            this.cbstandartDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbstandartDepartment.Name = "cbstandartDepartment";
            this.cbstandartDepartment.Size = new System.Drawing.Size(468, 24);
            this.cbstandartDepartment.TabIndex = 5;
            // 
            // lblStandartDepartment
            // 
            this.lblStandartDepartment.AutoSize = true;
            this.lblStandartDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStandartDepartment.Location = new System.Drawing.Point(0, 78);
            this.lblStandartDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStandartDepartment.Name = "lblStandartDepartment";
            this.lblStandartDepartment.Size = new System.Drawing.Size(139, 17);
            this.lblStandartDepartment.TabIndex = 4;
            this.lblStandartDepartment.Text = "Группа стандартов:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDepartmentName.Location = new System.Drawing.Point(0, 56);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(468, 22);
            this.tbDepartmentName.TabIndex = 3;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartmentName.Location = new System.Drawing.Point(0, 39);
            this.lblDepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(180, 17);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Название специальности:";
            // 
            // mtbDepartmentNumber
            // 
            this.mtbDepartmentNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbDepartmentNumber.Location = new System.Drawing.Point(0, 17);
            this.mtbDepartmentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDepartmentNumber.Mask = "00.00.00";
            this.mtbDepartmentNumber.Name = "mtbDepartmentNumber";
            this.mtbDepartmentNumber.Size = new System.Drawing.Size(468, 22);
            this.mtbDepartmentNumber.TabIndex = 1;
            // 
            // lblDepartmentNumber
            // 
            this.lblDepartmentNumber.AutoSize = true;
            this.lblDepartmentNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepartmentNumber.Location = new System.Drawing.Point(0, 0);
            this.lblDepartmentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentNumber.Name = "lblDepartmentNumber";
            this.lblDepartmentNumber.Size = new System.Drawing.Size(159, 17);
            this.lblDepartmentNumber.TabIndex = 0;
            this.lblDepartmentNumber.Text = "Номер специальности:";
            // 
            // gbDepartmentSearchFilter
            // 
            this.gbDepartmentSearchFilter.Controls.Add(this.cbFilterStandart);
            this.gbDepartmentSearchFilter.Controls.Add(this.pnSearch);
            this.gbDepartmentSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDepartmentSearchFilter.Location = new System.Drawing.Point(4, 19);
            this.gbDepartmentSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbDepartmentSearchFilter.Name = "gbDepartmentSearchFilter";
            this.gbDepartmentSearchFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbDepartmentSearchFilter.Size = new System.Drawing.Size(723, 49);
            this.gbDepartmentSearchFilter.TabIndex = 1;
            this.gbDepartmentSearchFilter.TabStop = false;
            this.gbDepartmentSearchFilter.Text = "Поиск и фильтрация:";
            // 
            // cbFilterStandart
            // 
            this.cbFilterStandart.AutoSize = true;
            this.cbFilterStandart.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFilterStandart.Location = new System.Drawing.Point(568, 19);
            this.cbFilterStandart.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterStandart.Name = "cbFilterStandart";
            this.cbFilterStandart.Size = new System.Drawing.Size(151, 26);
            this.cbFilterStandart.TabIndex = 1;
            this.cbFilterStandart.Text = "Отфильтровывать";
            this.cbFilterStandart.UseVisualStyleBackColor = true;
            this.cbFilterStandart.CheckedChanged += new System.EventHandler(this.cbFilterStandart_CheckedChanged);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbDepartmentSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(4, 19);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(548, 26);
            this.pnSearch.TabIndex = 0;
            // 
            // tbDepartmentSearch
            // 
            this.tbDepartmentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDepartmentSearch.Location = new System.Drawing.Point(0, 0);
            this.tbDepartmentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepartmentSearch.Name = "tbDepartmentSearch";
            this.tbDepartmentSearch.Size = new System.Drawing.Size(548, 22);
            this.tbDepartmentSearch.TabIndex = 0;
            this.tbDepartmentSearch.Text = "Введите название специальности...";
            this.tbDepartmentSearch.Enter += new System.EventHandler(this.tbDepartmentSearch_Enter);
            this.tbDepartmentSearch.Leave += new System.EventHandler(this.tbDepartmentSearch_Leave);
            // 
            // StandartDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 601);
            this.Controls.Add(this.gbDepartment);
            this.Controls.Add(this.gbStandart);
            this.Controls.Add(this.pnManup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StandartDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник \"Стандарты\" и \"Специальности\"";
            this.pnManup.ResumeLayout(false);
            this.gbStandart.ResumeLayout(false);
            this.gbStandartManup.ResumeLayout(false);
            this.gbStandartManup.PerformLayout();
            this.pnStandartSearch.ResumeLayout(false);
            this.pnStandartSearch.PerformLayout();
            this.gbDepartment.ResumeLayout(false);
            this.pndgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.gbDepartmentManup.ResumeLayout(false);
            this.pnDepartmentManup2.ResumeLayout(false);
            this.pnDepartmentManup1.ResumeLayout(false);
            this.pnDepartmentManup1.PerformLayout();
            this.gbDepartmentSearchFilter.ResumeLayout(false);
            this.gbDepartmentSearchFilter.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnManup;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox gbStandart;
        private System.Windows.Forms.ListBox lstbStandart;
        private System.Windows.Forms.GroupBox gbStandartManup;
        private System.Windows.Forms.TextBox tbStandartName;
        private System.Windows.Forms.Label lblStandartName;
        private System.Windows.Forms.Button btStandartInsert;
        private System.Windows.Forms.Button btStandartUpdate;
        private System.Windows.Forms.Button btStandartDelete;
        private System.Windows.Forms.Panel pnStandartSearch;
        private System.Windows.Forms.TextBox tbStandartSearch;
        private System.Windows.Forms.GroupBox gbDepartment;
        private System.Windows.Forms.GroupBox gbDepartmentSearchFilter;
        private System.Windows.Forms.GroupBox gbDepartmentManup;
        private System.Windows.Forms.Panel pnDepartmentManup2;
        private System.Windows.Forms.Panel pnDepartmentManup1;
        private System.Windows.Forms.Button btDepartmentDelete;
        private System.Windows.Forms.Button btDepartmentUpdate;
        private System.Windows.Forms.Button btDepartmentInsert;
        private System.Windows.Forms.CheckBox cbFilterStandart;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbDepartmentSearch;
        private System.Windows.Forms.ComboBox cbstandartDepartment;
        private System.Windows.Forms.Label lblStandartDepartment;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.MaskedTextBox mtbDepartmentNumber;
        private System.Windows.Forms.Label lblDepartmentNumber;
        private System.Windows.Forms.Panel pndgv;
        private System.Windows.Forms.DataGridView dgvDepartment;
    }
}