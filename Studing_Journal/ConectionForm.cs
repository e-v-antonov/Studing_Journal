using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Studing_Journal
{
    public partial class ConectionForm : Form
    {
        private DataBase_Configuration configuration = new DataBase_Configuration();
        private Int32 status;
        public ConectionForm()
        {
            InitializeComponent();
        }

        private void ConectionForm_Load(object sender, EventArgs e)
        {
            switch(DataBase_Configuration.logCon)
            {
                case (true):
                    cbDataSource.Text = Registry_Class.DS;
                    cbInitialCatalog.Text = Registry_Class.IC;
                    cbDataSource.Enabled = true;
                    cbInitialCatalog.Enabled = true;
                    tbUserID.Enabled = true;
                    tbPassword.Enabled = true;
                    btCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    configuration.dtServers += dtservers;
                    Thread thread = new Thread(configuration.Servers_get);
                    thread.Start();
                    break;
            }
            
        }

        private void dtservers(DataTable table)
        {
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbDataSource.Items.Add(r[0] + @"\" + r[1]);
                }
                status = 0;
                cbDataSource.Enabled = true;
                tbUserID.Enabled = true;
                tbPassword.Enabled = true;
                btCheck.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            tsslStatus.Visible = true;
            switch (status)
            {
                case (1):
                    tsslStatus.Text = "Поиск серверов";
                    break;
                case (2):
                    tsslStatus.Text = "Поиск источников данных";
                    break;
            }
            do
            {
                Thread.Sleep(750);
                switch (status)
                {
                    case (1):
                        if (tsslStatus.Text == "Поиск серверов...")
                            tsslStatus.Text = "Поиск серверов";
                        else tsslStatus.Text = tsslStatus.Text + ".";
                        break;
                    case (2):
                        if (tsslStatus.Text == "Поиск источников данных...")
                            tsslStatus.Text = "Поиск источников данных";
                        else tsslStatus.Text = tsslStatus.Text + ".";
                        break;
                }
                
            } while (status != 0);
            tsslStatus.Text = "-";
            tsslStatus.Visible = false;
            Thread.CurrentThread.Abort();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            configuration.cds = cbDataSource.Text;
            configuration.cui = tbUserID.Text;
            configuration.cpw = tbPassword.Text;
            configuration.dtDatabases += databases;
            status = 2;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(configuration.Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                foreach(DataRow r in table.Rows)
                {
                    cbInitialCatalog.Items.Add(r[0]);
                }
                status = 0;
                cbInitialCatalog.Enabled = true;
                btConect.Enabled = true;
            };
            Invoke(action);
        }

        private void btConect_Click(object sender, EventArgs e)
        {
            Registry_Class registry = new Registry_Class();
            registry.Registry_Set(cbDataSource.Text,
                cbInitialCatalog.Text,tbUserID.Text, tbPassword.Text);
            ((MainForm)Owner).MainForm_Load(sender, e);
            DataBase_Configuration.logCon = true;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DataBase_Configuration.logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    switch (MessageBox.Show("Подключение не было уствновлено! " +
                        "\n Завершить работу приложения?","Учебный журнал", 
                        MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
                    {
                        case DialogResult.Yes:
                            e.Cancel = false;
                            Application.Exit();
                            break;
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                    }
                    break;
            }
        }
    }
}
