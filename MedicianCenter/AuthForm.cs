using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicianCenter
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            StateSingleton.getInstance().authForm = this;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            // Устанавливаем контекст подключения
            StateSingleton.getInstance().connectionString =
                $"Data Source=DESKTOP-QL85CJN\\SQLEXPRESS;Initial Catalog=Poliklinika;Persist Security Info=True;User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text};Encrypt=False";

            using (Database.Model.Context db = new Database.Model.Context())
            {
                try
                {
                    if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('doctor')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Doctor;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('assistant')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Assistant;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('registrator')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Registar;
                    else if (db.Database.SqlQuery<int>("SELECT IS_MEMBER('admin')").First() == 1)
                        StateSingleton.getInstance().authState = AuthState.Admin;
                }
                catch
                {
                    StateSingleton.getInstance().authState = AuthState.NonAuth;
                }
            }

            // Открытие определенной формы в зависимости от роли пользователя
            switch (StateSingleton.getInstance().authState)
            {
                case AuthState.NonAuth:
                    MessageBox.Show("Указаны неверные логин или пароль!");
                    break;
                case AuthState.Doctor:
                    Doctor.DoctorMainForm dmf = new Doctor.DoctorMainForm();
                    this.Hide();
                    dmf.Show();
                    break;
                case AuthState.Assistant:
                    LabAssistant.LabAssistantMainForm lamf = new LabAssistant.LabAssistantMainForm();
                    this.Hide();
                    lamf.Show();
                    break;
                case AuthState.Registar:
                    Registar.RegistarMainForm rmf = new Registar.RegistarMainForm();
                    this.Hide();
                    rmf.Show();
                    break;
                case AuthState.Admin:
                    Admin.AdminMain am = new Admin.AdminMain();
                    this.Hide();
                    am.Show();
                    break;
                default:
                    break;
            }

        }
    }
}
