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
using MedicianCenter.Admin;

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

                UpdatePills();
            }
        }

        private void UpdatePills()
        {
            using (Database.Model.Context db = new Context())
            {
                var pills = db.healing_list_pills
                        .Include(x => x.list_pills)
                        .Include(x => x.med_card)
                        .Where(x => x.ID_med_card == mc.ID_med_card)
                        .Select(x => x.list_pills);

                PillsDataGridView.DataSource = pills.Include(x => x.list_pills_list_tests).Include(x => x.healing_list_pills).ToList();
            }
        }

        private void PillsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = PillsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var id = db.list_pills.Find(PillsDataGridView.Rows[currentMouseOverRow].Cells["ID_list_pills"].Value);

                            var rHealingListPills = db.healing_list_pills
                                .Where(x => x.ID_list_pills == id.ID_list_pills
                                && x.ID_med_card == mc.ID_med_card)
                                .FirstOrDefault();

                            db.healing_list_pills.Remove(rHealingListPills);
                            db.SaveChanges();
                        }

                        UpdatePills();
                    }));
                }

                m.Show(PillsDataGridView, new Point(e.X, e.Y));
            }
        }
    }
}
