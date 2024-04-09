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

namespace MedicianCenter.Registar
{
    public partial class AddHistoryForm : Form
    {
        private int? selectedPatientId = null;
        private int? selectedDoctorId = null;
        private istoria_priemov ip = null;
        public AddHistoryForm()
        {
            InitializeComponent();
            this.StatusComboBox.SelectedIndex = 0;
        }

        public AddHistoryForm(istoria_priemov ip)
        {
            InitializeComponent();
            this.ip = ip;
            this.StatusComboBox.SelectedIndex = 0;
        }

        private void AddHistoryForm_Load(object sender, EventArgs e)
        {
            if (ip != null)
            {
                using (Context db = new Context())
                {
                    var doc = db.doctor
                        .Find(ip.ID_doctor);
                    selectedDoctorId = doc.ID_doctor;

                    var pat = db.med_card
                        .Find(ip.ID_med_card);
                    selectedPatientId = pat.ID_med_card;

                    DoctorNameTextBox.Text = $"{doc.surname} {doc.name} {doc.middle_name}";
                    PatientNameTextBox.Text = $"{pat.surname} {pat.name} {pat.middle_name}";
                    DeseaseTextBox.Text = ip.disease;
                    TimeTextBox.Text = ip.time;
                    DatePicker.Value = ip.date_of_priem;
                    StatusComboBox.Text = ip.status;


                    EditButton.Text = "Изменить";
                    this.Text = "Изменить запись";
                }
            }
        }

        private void FindPatientButton_Click(object sender, EventArgs e)
        {
            Registar.FindPatientForm fpf = new FindPatientForm(this);
            fpf.ShowDialog();
        }

        private void FindDoctorButton_Click(object sender, EventArgs e)
        {
            FindDoctorForm fdf = new FindDoctorForm(this);
            fdf.ShowDialog();
        }

        public void ChangeSelectedPatient(med_card mc)
        {
            selectedPatientId = mc.ID_med_card;
            PatientNameTextBox.Text = $"{mc.surname} {mc.name} {mc.middle_name}";
        }

        public void ChangeSelectedDoctor(doctor doc)
        {
            selectedDoctorId = doc.ID_doctor;
            DoctorNameTextBox.Text = $"{doc.surname} {doc.name} {doc.middle_name}";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

                // Добавление
                if (ip == null)
                {
                    istoria_priemov nIp = new istoria_priemov();
                    nIp.ID_doctor = (int)selectedDoctorId;
                    nIp.ID_med_card = (int)selectedPatientId;
                    nIp.disease = DeseaseTextBox.Text;
                    nIp.date_of_priem = DatePicker.Value.Date;
                    nIp.time = TimeTextBox.Text;
                    nIp.status = StatusComboBox.Text;
                    nIp.ID_healing = 1;

                    using (Context db = new Context())
                    {
                        db.istoria_priemov.Add(nIp);
                        db.SaveChanges();
                    }
                }
                // Изменение
                else
                {
                    using (Context db = new Context())
                    {
                        var cIp = db.istoria_priemov.Find(ip.ID_istoria_priemov);
                        cIp.ID_doctor = (int)selectedDoctorId;
                        cIp.ID_med_card = (int)selectedPatientId;
                        cIp.disease = DeseaseTextBox.Text;
                        cIp.date_of_priem = DatePicker.Value.Date;
                        cIp.time = TimeTextBox.Text;
                        cIp.status = StatusComboBox.Text;
                        cIp.ID_healing = 1;

                        db.SaveChanges();
                    }
                }
                Close();
        }
    }
}
