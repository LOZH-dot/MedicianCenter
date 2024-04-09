using MedicianCenter.Admin;
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
    public partial class RegistarMainForm : Form
    {
        public RegistarMainForm()
        {
            InitializeComponent();
            UpdateHistoryDataGrid();
            UpdateMedCardsDataGrid();
        }

        private async void UpdateHistoryDataGrid()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var history = await db.istoria_priemov
                    .Include(x => x.doctor)
                    .Include(x => x.healing)
                    .Include(x => x.med_card)
                    .ToListAsync();

                HistoryDataGridView.DataSource = history;
            }
        }

        private async void UpdateMedCardsDataGrid()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                var medCards = await db.med_card
                    .Include(x => x.med_card_contra)
                    .Include(x => x.istoria_priemov)
                    .ToListAsync();

                MedCardsDataGridView.DataSource = medCards;
            }
        }

        // Контекстное меню для таблицы истории приемов
        private void HistoryDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = HistoryDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить запись
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var ip = db.istoria_priemov
                                .Find(HistoryDataGridView.Rows[currentMouseOverRow].Cells["ID_istoria_priemov"].Value);
                            AddHistoryForm ahf = new AddHistoryForm(ip);
                            ahf.FormClosed += Ahf_FormClosed;
                            ahf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить запись
                        using (Database.Model.Context db = new Context())
                        {
                            var dIp = db.istoria_priemov
                                .Remove(db.istoria_priemov.Find(HistoryDataGridView.Rows[currentMouseOverRow].Cells["ID_istoria_priemov"].Value));
                            db.SaveChanges();
                        }

                        MessageBox.Show("Запись успешно удалена!");
                        UpdateHistoryDataGrid();
                    }));
                }

                m.Show(HistoryDataGridView, new Point(e.X, e.Y));
            }
        }

        private void RegistarMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void AddHistoryButton_Click(object sender, EventArgs e)
        {
            AddHistoryForm ahf = new AddHistoryForm();
            ahf.FormClosed += Ahf_FormClosed;
            ahf.ShowDialog();
        }

        private void Ahf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateHistoryDataGrid();
        }
    }
}
