using System;
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
    public partial class MainForm : Form
    {
        DataBase_Configuration data = new DataBase_Configuration();
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();
        }

        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        tsslCon.Visible = true;
                        tsslCon.Text = Registry_Class.DS+" - "+Registry_Class.IC;
                        break;
                    case (false):
                        ConectionForm conection = new ConectionForm();
                        tsslCon.Visible = true;
                        tsslCon.Text = "Подключение отсутвует!";
                        conection.Show(this);
                        break;
                }
            };
            Invoke(action);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssldateTime.Text = DateTime.Now.ToLongTimeString() + "/" + DateTime.Now.ToShortDateString();
        }

        private void конфигурацияПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConectionForm conectionForm = new ConectionForm();
            conectionForm.Show(this);
        }

        private void стандартыСпециальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandartDepartmentForm form = new StandartDepartmentForm();
            form.Show(this);
        }
    }
}
