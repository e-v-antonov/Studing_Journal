﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studing_Journal
{
    public partial class StandartDepartmentForm : Form
    {
        DataBaseTables tableStandart = new DataBaseTables();
        DataBaseTables tableDepartment = new DataBaseTables();
        DataBaseTables tableStandartcb = new DataBaseTables();
        DataBaseProcedure procedure = new DataBaseProcedure();
        string filterDepartment;

        public StandartDepartmentForm()
        {
            InitializeComponent();
            Thread threadDepartment = new Thread(tableDepartment.dtDepartmentFill);
            threadDepartment.Start();
        }
        
        private void dgvDepartmentFill()
        {
            Action action = () =>
            {
                DataBaseTables data = new DataBaseTables();
                filterDepartment = data.qrDepartment;
                data.dtDepartmentFill();
                data.dependency.OnChange += onchangeDepartment;
                dgvDepartment.DataSource = data.dtDepartment;
                dgvDepartment.Columns[0].Visible = false;
                dgvDepartment.Columns[1].HeaderText = "Номер специальности";
                dgvDepartment.Columns[2].HeaderText = "Название специальности";
                dgvDepartment.Columns[3].Visible = false;
                dgvDepartment.Columns[4].HeaderText = "Группа стандартов";
                dgvDepartment.Columns[5].Visible = false;
            };
            Invoke(action);
        }

        private void stbStandart()
        {
            Action action = () =>
            {
                DataBaseTables data = new DataBaseTables();
                data.dtStandardFill();
                data.dependency.OnChange += onchangeStandart;
                lstbStandart.DataSource = data.dtStandard;
                lstbStandart.ValueMember = "ID_Standard";
                lstbStandart.DisplayMember = "Standard_name";
            };
            Invoke(action);
        }

        private void cbStandartDepartment()
        {
            Action action = () =>
            {
                DataBaseTables data = new DataBaseTables();
                data.dtStandardFill();
                data.dependency.OnChange += onchangeStandartDependency;
                cbstandartDepartment.DataSource = data.dtStandard;
                cbstandartDepartment.ValueMember = "ID_Standard";
                cbstandartDepartment.DisplayMember = "Standard_name";
            };
            Invoke(action);
        }

        private void dtFillFullStandart(DataTable data)
        {
            Action action = () =>
            {
                lstbStandart.DataSource = data;
                lstbStandart.ValueMember = "ID_Standard";
                lstbStandart.DisplayMember = "Standard_name";
                Thread threadStandartcb = new Thread(tableStandartcb.dtStandardFill);
                threadStandartcb.Start();
                SqlDependency dependency = new SqlDependency(tableStandart.command);
                dependency.OnChange += onchangeStandart;
                SqlDependency.Start(Registry_Class.sqlConnection.ConnectionString);
            };
            Invoke(action);
        }

        private void onchangeStandart(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                stbStandart();
        }

        private void onchangeStandartDependency(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                cbStandartDepartment();
        }

        private void onchangeDepartment(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                dgvDepartmentFill();
        }

        private void dtFillFullDepartment(DataTable data)
        {
            Action action = () =>
            {
                dgvDepartment.DataSource = data;
                dgvDepartment.Columns[0].Visible = false;
                dgvDepartment.Columns[1].HeaderText = "Номер специальности";
                dgvDepartment.Columns[2].HeaderText = "Название специальности";
                dgvDepartment.Columns[3].Visible = false;
                dgvDepartment.Columns[4].HeaderText = "Стандарт";
                dgvDepartment.Columns[5].Visible = false;
                Thread threadStandart = new Thread(tableStandart.dtStandardFill);
                threadStandart.Start();
            };
            Invoke(action);
        }

        private void dtFillFulltableStandartcb(DataTable data)
        {
            Action action = () =>
            {
                cbstandartDepartment.DataSource = data;
                cbstandartDepartment.ValueMember = "ID_Standard";
                cbstandartDepartment.DisplayMember = "Standard_name";
            };
            Invoke(action);
        }

        private void tbStandartSearch_Enter(object sender, EventArgs e)
        {
            if (tbStandartSearch.Text == "Введите название...")
                tbStandartSearch.Clear();
        }

        private void tbStandartSearch_Leave(object sender, EventArgs e)
        {
            if (tbStandartSearch.Text == "")
                tbStandartSearch.Text = "Введите название...";
        }

        private void tbDepartmentSearch_Enter(object sender, EventArgs e)
        {
            if (tbDepartmentSearch.Text == "Введите название специальности...")
                tbDepartmentSearch.Clear();
        }

        private void tbDepartmentSearch_Leave(object sender, EventArgs e)
        {
            if (tbDepartmentSearch.Text == "")
                tbDepartmentSearch.Text = "Введите название специальности...";
        }

        private void lstbStandart_SelectedValueChanged(object sender, EventArgs e)
        {
            tbStandartName.Text = lstbStandart.Text; 
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbDepartmentNumber.Text = dgvDepartment.CurrentRow.Cells[1].Value.ToString();
            tbDepartmentName.Text = dgvDepartment.CurrentRow.Cells[2].Value.ToString();
            cbstandartDepartment.SelectedValue = dgvDepartment.CurrentRow.Cells[3].Value.ToString();
        }

        private void tbStandartSearch_TextChanged(object sender, EventArgs e)
        {
            lstbStandart.SelectedIndex = lstbStandart.FindString(tbStandartSearch.Text);
        }

        private void cbFilterStandart_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbFilterStandart.CheckState)
            {
                case (CheckState.Checked):
                    DataBaseTables data = new DataBaseTables();
                    data.qrDepartment = filterDepartment + " and [Department_Number] like '%" + tbDepartmentSearch.Text + "%' or [Department_Name] like '%" + tbDepartmentSearch.Text + "%'";
                    data.dtDepartmentFill();
                    dgvDepartment.DataSource = data.dtDepartment;
                    dgvDepartment.Columns[0].Visible = false;
                    dgvDepartment.Columns[1].HeaderText = "Номер специальности";
                    dgvDepartment.Columns[2].HeaderText = "Название специальности";
                    dgvDepartment.Columns[3].Visible = false;
                    dgvDepartment.Columns[4].HeaderText = "Группа стандартов";
                    dgvDepartment.Columns[5].Visible = false;
                    break;
                case (CheckState.Unchecked):
                    dgvDepartmentFill();
                    for (int i = 0; i < dgvDepartment.RowCount; i++)
                    {
                        for (int j = 0; j < dgvDepartment.ColumnCount; j++)
                        {
                            if (dgvDepartment.Rows[i].Cells[j].Value != null)
                                if (dgvDepartment.Rows[i].Cells[j].Value.ToString().Contains(tbDepartmentSearch.Text))
                                {
                                    dgvDepartment.Rows[i].Selected = true;
                                }
                        }
                    }
                    break;
            }
        }

        private void btStandartInsert_Click(object sender, EventArgs e)
        {
            procedure.spStandard_Insert(tbStandartName.Text);
            tbStandartName.Clear();
        }

        private void btStandartUpdate_Click(object sender, EventArgs e)
        {
            procedure.spStandard_Update(Convert.ToInt32(lstbStandart.SelectedValue.ToString()),tbStandartName.Text);
        }

        private void btStandartDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись "+lstbStandart.Text+"?","Справочник \"Стандарты\"",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spStandard_Delete(Convert.ToInt32(lstbStandart.SelectedValue.ToString()));
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void btDepartmentInsert_Click(object sender, EventArgs e)
        {
            procedure.spDepartment_Insert(mtbDepartmentNumber.Text, tbDepartmentName
                .Text, Convert.ToInt32(cbstandartDepartment.SelectedValue.ToString()));
            mtbDepartmentNumber.Clear();
            tbDepartmentName.Clear();
        }

        private void btDepartmentUpdate_Click(object sender, EventArgs e)
        {
            procedure.spDepartment_Update(Convert.ToInt32(dgvDepartment.CurrentRow.Cells[0].Value.ToString()), mtbDepartmentNumber.Text, tbDepartmentName.Text, Convert.ToInt32(cbstandartDepartment.SelectedValue.ToString()));
        }

        private void btDepartmentDelete_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Удаление специальности", "Удалить специальность " + mtbDepartmentNumber.Text + " " + tbDepartmentName.Name + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spDepartment_Delete(Convert.ToInt32(dgvDepartment.CurrentRow.Cells[0].Value.ToString()));
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tbDepartmentSearch_TextChanged(object sender, EventArgs e)
        {
            cbFilterStandart_CheckedChanged(sender, e);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
