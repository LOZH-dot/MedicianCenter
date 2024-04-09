using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicianCenter.Registar
{
    public partial class FindPatientForm : Form
    {
        private AddHistoryForm ahf;
        public FindPatientForm(AddHistoryForm ahf)
        {
            InitializeComponent();
            this.ahf = ahf;
        }

        private async void FindPatientForm_Load(object sender, EventArgs e)
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                MedCardsDataGridView.DataSource = await db.med_card
                    .Include(x => x.med_card_contra)
                    .Include(x => x.istoria_priemov)
                    .Include(x => x.healing_list_pills)
                    .ToListAsync();
            }
        }

        private void MedCardsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            med_card selectedCard = MedCardsDataGridView.Rows[e.RowIndex].DataBoundItem as med_card;

            ahf.ChangeSelectedPatient(selectedCard);
            Close();
        }
    }
}
