using MedicianCenter.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;

namespace MedicianCenter.Doctor
{
    public partial class SelectPillsForm : Form
    {
        private med_card mc;
        public SelectPillsForm(med_card mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void SelectPillsForm_Load(object sender, EventArgs e)
        {
            PatientNameTextBox.Text = $"{mc.surname} {mc.name} {mc.middle_name}";

            using (Database.Model.Context db = new Context())
            {
                PillsComboBox.DataSource = db.list_pills
                    .ToList();
                PillsComboBox.DisplayMember = "name";
                PillsComboBox.SelectedIndex = 0;

                var pills = db.healing_list_pills
                    .Include(x => x.list_pills)
                    .Include(x => x.med_card)
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .Select(x => x.list_pills);

                PillsDataGridView.DataSource = pills.Include(x => x.list_pills_list_tests).Include(x => x.healing_list_pills).ToList();

            }
        }

        private void AddPillButton_Click(object sender, EventArgs e)
        {
            using (Database.Model.Context db = new Context())
            {
                list_pills nPill = PillsComboBox.SelectedItem as list_pills;
                healing_list_pills hlp = new healing_list_pills();
                hlp.ID_list_pills = nPill.ID_list_pills;
                hlp.ID_med_card = mc.ID_med_card;

                db.healing_list_pills.Add(hlp);
                db.SaveChanges();

                var pills = db.healing_list_pills
                    .Include(x => x.list_pills)
                    .Include(x => x.med_card)
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .Select(x => x.list_pills);

                PillsDataGridView.DataSource = pills.Include(x => x.list_pills_list_tests).Include(x => x.healing_list_pills).ToList();
            }
        }

    }
}
