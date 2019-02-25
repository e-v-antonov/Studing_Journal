using System;
using System.Windows.Forms;

namespace Studing_Journal
{
    class DynamicObjects
    {
        ComboBox comboBoxDepartment = new ComboBox();
        ComboBox comboBoxGroup = new ComboBox();
        Form formRedaction = new Form();
        Label labelStudentInfo = new Label();
        Button buttonCommnit = new Button();
        Button buttonCancel = new Button();
        public string student;
        public Form parent;

        private void DepartmentFill()
        {
            DataBaseTables dataDepartment = new DataBaseTables();
            dataDepartment.dtDepartmentFill();
            comboBoxDepartment.DataSource = dataDepartment.dtDepartment;
            comboBoxDepartment.ValueMember = "ID_Department";
            comboBoxDepartment.DisplayMember = "Departments_List";
        }

        private void GroupFill()
        {
            try
            {
                DataBaseTables dataGroup = new DataBaseTables();
                dataGroup.qrGroup += " and [Department_ID] = " + comboBoxDepartment.SelectedValue.ToString();
                dataGroup.dtGroupFill();
                comboBoxGroup.DataSource = dataGroup.dtGroup;
                comboBoxGroup.ValueMember = "ID_Group";
                comboBoxGroup.DisplayMember = "Group__name";
            }
            catch { }
        }

        public void ChangeFormCreate()
        {
            Action action = () =>
            {
                formRedaction.FormBorderStyle = FormBorderStyle.None;
                formRedaction.StartPosition = FormStartPosition.CenterScreen;
                formRedaction.Text = "Изменение группы и специальности";

                labelStudentInfo.Text = "Укажите специальность и группу, в которую необходимо определить студента " + student;
                labelStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                labelStudentInfo.Dock = DockStyle.Top;

                comboBoxDepartment.Dock = DockStyle.Top;
                comboBoxDepartment.SelectedValueChanged += ComboBoxDepartment_SelectedValueChanged;
                comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                DepartmentFill();

                comboBoxGroup.Dock = DockStyle.Top;
                comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
                GroupFill();

                buttonCommnit.Text = "Изменить";
                buttonCommnit.Dock = DockStyle.Top;
                buttonCommnit.Click += ButtonCommnit_Click;

                buttonCancel.Text = "Отмена";
                buttonCancel.Dock = DockStyle.Top;
                buttonCancel.Click += ButtonCancel_Click;

                formRedaction.Size = new System.Drawing.Size(500, comboBoxDepartment.Height + comboBoxGroup.Height + buttonCancel.Height + buttonCommnit.Height + labelStudentInfo.Height);
                formRedaction.Controls.Add(buttonCancel);
                formRedaction.Controls.Add(buttonCommnit);
                formRedaction.Controls.Add(comboBoxGroup);
                formRedaction.Controls.Add(comboBoxDepartment);
                formRedaction.Controls.Add(labelStudentInfo);
                formRedaction.Show(parent);
            };
            parent.Invoke(action);
        }

        private void ButtonCommnit_Click(object sender, EventArgs e)
        {
            switch (comboBoxGroup.Text == ((StudentsForm)parent).cbGroup.Text) //обращаемся напрямую к свойству текст комбобокса без перезаписи значения куда-то еще
            {
                case (true):
                    MessageBox.Show("Невозможно изменить группу " + ((StudentsForm)parent).cbGroup.Text + " на " + comboBoxGroup.Text + ". \n Выберите другую группу!");
                    break;

                case (false):
                    DataBaseProcedure procedure = new DataBaseProcedure();
                    procedure.spStudent_Update(student, ((StudentsForm)parent).tbStudentSurname.Text, ((StudentsForm)parent).tbStudentName.Text, ((StudentsForm)parent).tbStudentMiddleName.Text, ((StudentsForm)parent).mtbTicketNumber.Text, Convert.ToInt32(comboBoxGroup.SelectedValue.ToString()));
                    break;
            }
        }

        private void ComboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            GroupFill();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            formRedaction.Controls.Remove(buttonCancel);
            formRedaction.Controls.Remove(buttonCommnit);
            formRedaction.Controls.Remove(comboBoxGroup);
            formRedaction.Controls.Remove(comboBoxDepartment);
            formRedaction.Controls.Remove(labelStudentInfo);
            buttonCancel.Click -= ButtonCancel_Click;
            comboBoxDepartment.SelectedValueChanged -= ComboBoxDepartment_SelectedValueChanged;
            buttonCommnit.Click -= ButtonCommnit_Click;
            formRedaction.Close();
        }

        public Form fmNewUser = new Form();
        Label lblNewLogin = new Label();
        Label lblNewPass = new Label();
        Label lblConfPass = new Label();
        TextBox tbNewLogin = new TextBox();
        TextBox tbNewPassword = new TextBox();
        TextBox tbConfPass = new TextBox();
        Label imgStudentImage = new Label();
        TextBox tbImagePath = new TextBox();
        PictureBox pbStudent = new PictureBox();
        Button btCommint = new Button();
        Button btCancel = new Button();
        Button btBrowse = new Button();
        Panel pnBrowse = new Panel();
        Panel pnPicture = new Panel();
        Panel pnSelect = new Panel();
        OpenFileDialog fileDialog = new OpenFileDialog();
        public Form parentCreate = new Form();

        public void NewStudentAccountCreate()
        {
            Action action = () =>
            {
                fmNewUser.Text = "Создание новой учетной записи студента";
                fmNewUser.StartPosition = FormStartPosition.CenterScreen;
                fmNewUser.FormBorderStyle = FormBorderStyle.FixedDialog;
                fmNewUser.Size = new System.Drawing.Size(300, 415);

                lblNewLogin.Text = "Новый логин студента";
                lblNewLogin.Dock = DockStyle.Top;

                tbNewLogin.MaxLength = 16;
                tbNewLogin.Dock = DockStyle.Top;
                tbNewLogin.Text = ((StudentsForm)parentCreate).cbStudentLogin.Text;

                lblNewPass.Text = "Новый пароль студента";
                lblNewPass.Dock = DockStyle.Top;

                tbNewPassword.MaxLength = 16;
                tbNewPassword.PasswordChar = '*';
                tbNewPassword.Dock = DockStyle.Top;

                lblConfPass.Text = "Повторение пароля";
                lblConfPass.Dock = DockStyle.Top;

                tbConfPass.MaxLength = 16;
                tbConfPass.PasswordChar = '*';
                tbConfPass.Dock = DockStyle.Top;

                pnSelect.BorderStyle = BorderStyle.FixedSingle;
                pnSelect.Dock = DockStyle.Top;
                pnSelect.Height = 25;

                pnPicture.BorderStyle = BorderStyle.FixedSingle;
                pnPicture.Width = 200;
                pnPicture.Dock = DockStyle.Fill;

                pbStudent.Dock = DockStyle.Fill;
                pbStudent.SizeMode = PictureBoxSizeMode.Zoom;

                pnBrowse.BorderStyle = BorderStyle.FixedSingle;
                pnBrowse.Height = 200;
                pnBrowse.Dock = DockStyle.Top;

                btBrowse.Size = new System.Drawing.Size(25, 25);
                btBrowse.Text = ". . .";
                btBrowse.Dock = DockStyle.Right;
                btBrowse.Click += BtBrowse_Click;

                tbImagePath.Enabled = false;
                tbImagePath.Dock = DockStyle.Fill;

                btCommint.Text = "Создать учетную запись";
                btCommint.Dock = DockStyle.Top;
                btCommint.Click += BtCommint_Click;

                btCancel.Text = "Отмена";
                btCancel.Dock = DockStyle.Top;
                btCancel.Click += BtCancel_Click;

                fileDialog.Filter = "Изображение JPG|*.JPG|Изображение JPEG|*.JPEG";
    }
}
