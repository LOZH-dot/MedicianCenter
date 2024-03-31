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
    public partial class AddPillForm : Form
    {
        private list_pills pill = null;
        public AddPillForm()
        {
            InitializeComponent();
        }

        public AddPillForm(list_pills pill)
        {
            InitializeComponent();
            this.pill = pill;
            this.Text = "Изменить препарат";
            AddPillButton.Text = "Изменить";
            FillPillInfo();
        }

        private void FillPillInfo()
        {
            PillNameTextBox.Text = pill.name;
            PillDescriptionTextBox.Text = pill.opisanie;
        }

        private void AddPillButton_Click(object sender, EventArgs e)
        {
            if (pill == null) 
            {
                list_pills nPill = new list_pills();
                nPill.name = PillNameTextBox.Text;
                nPill.opisanie = PillDescriptionTextBox.Text;
                
                using (Database.Model.Context db = new Context())
                {
                    db.list_pills.Add(nPill);
                    db.SaveChanges();
                }

                MessageBox.Show("Препарат успешно добавлен!");
            }
            else
            {
                using (Database.Model.Context db = new Context())
                {
                    var cPill = db.list_pills.Find(pill.ID_list_pills);
                    cPill.name = PillNameTextBox.Text;
                    cPill.opisanie = PillDescriptionTextBox.Text;

                    db.SaveChanges();
                }

                MessageBox.Show("Препарат успешно изменен!");
            }
            this.Close();
        }
    }
}
