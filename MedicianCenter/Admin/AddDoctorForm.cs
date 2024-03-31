using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicianCenter.Admin
{
    public partial class AddDoctorForm : Form
    {
        private doctor doctor = null;
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        public AddDoctorForm(doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            AddDoctorButton.Text = "Изменить";
            this.Text = "Изменить доктора";
            FillDoctorInfo();
        }

        private void FillDoctorInfo()
        {
            SpecializationTextBox.Text = doctor.specialization;
            WorkPhoneMaskedTextBox.Text = doctor.work_number;
            NameTextBox.Text = doctor.name;
            SurnameTextBox.Text = doctor.surname;
            PatronymicTextBox.Text = doctor.middle_name;
            CabinetNumberTextBox.Text = doctor.cabinet.ToString();
            BirhdayDateTimePicker.Value = doctor.date_of_birth.Value;
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            if (this.doctor == null)
            {
                doctor nDoctor = new doctor();
                nDoctor.specialization = SpecializationTextBox.Text;
                nDoctor.work_number = WorkPhoneMaskedTextBox.Text;
                nDoctor.name = NameTextBox.Text;
                nDoctor.surname = SurnameTextBox.Text;
                nDoctor.middle_name = PatronymicTextBox.Text;
                nDoctor.cabinet = int.Parse(CabinetNumberTextBox.Text);
                nDoctor.date_of_birth = BirhdayDateTimePicker.Value;

                using (Database.Model.Context db = new Database.Model.Context())
                {
                    db.doctor.Add(nDoctor);
                    db.SaveChanges();
                }

                MessageBox.Show("Доктор успешно добавлен!");
            }
            else
            {
                using (Database.Model.Context db = new Context())
                {
                    var cDoc = db.doctor.Find(doctor.ID_doctor);
                    cDoc.specialization = SpecializationTextBox.Text;
                    cDoc.work_number = WorkPhoneMaskedTextBox.Text;
                    cDoc.name = NameTextBox.Text;
                    cDoc.surname = SurnameTextBox.Text;
                    cDoc.middle_name = PatronymicTextBox.Text;
                    cDoc.cabinet = int.Parse(CabinetNumberTextBox.Text);
                    cDoc.date_of_birth = BirhdayDateTimePicker.Value;

                    db.SaveChanges();
                }

                MessageBox.Show("Доктор успешно изменен!");
            }
            this.Close();
        }
    }
}
