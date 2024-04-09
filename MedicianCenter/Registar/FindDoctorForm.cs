using MedicianCenter.Database.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace MedicianCenter.Registar
{
    public partial class FindDoctorForm : Form
    {
        private AddHistoryForm ahf;
        public FindDoctorForm(AddHistoryForm ahf)
        {
            InitializeComponent();
            this.ahf = ahf;
        }

        private void DoctorsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            doctor selectedDoc = DoctorsDataGridView.Rows[e.RowIndex].DataBoundItem as doctor;

            ahf.ChangeSelectedDoctor(selectedDoc);
            Close();
        }

        private async void FindDoctorForm_Load(object sender, EventArgs e)
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                DoctorsDataGridView.DataSource = await db.doctor
                    .Include(x => x.istoria_priemov)
                    .ToListAsync();
            }
        }
    }
}
