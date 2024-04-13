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
using MedicianCenter.Database.Model;
using System.IO;
using System.Xml.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Security.Policy;
using MedicianCenter.Properties;

namespace MedicianCenter.Doctor
{
    public partial class DoctorMainForm : Form
    {
        public DoctorMainForm()
        {
            InitializeComponent();
        }

        private void DoctorMainForm_Load(object sender, EventArgs e)
        {
            UpdateMedCardsDataGridView();
        }

        private async void UpdateMedCardsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                MedCardsDataGridView.DataSource = await db.med_card
                    .Include(x => x.med_card_contra)
                    .Include(x => x.istoria_priemov)
                    .Include(x => x.healing_list_pills)
                    .ToListAsync();
        }

        private void DoctorMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        // Для контекстного меню таблицы MedCardsDataGridView
        private void MedCardsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = MedCardsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить карту
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            Admin.AddMedCardForm amcf = new AddMedCardForm(mc);
                            amcf.FormClosed += Amcf_FormClosed;
                            amcf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Назначить лекарства", (s, se) =>
                    {
                        // Назначить анализы
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            Doctor.SelectPillsForm spf = new SelectPillsForm(mc);
                            spf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Назначить анализы", (s, se) =>
                    {
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);

                            Doctor.AddTestForm atf = new AddTestForm(mc);
                            atf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Отчет по анализам", (s, se) =>
                    {
                        // Отчет по анализам
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);

                            Doctor.ViewTestsResultsForm vtrf = new ViewTestsResultsForm(mc);
                            vtrf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Составить выписку", (s, se) =>
                    {
                        string savePath = null;
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "Word документ (*.docx)|*.docx";
                            DialogResult result = sfd.ShowDialog();

                            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                                savePath = sfd.FileName;
                        }
                        // Составить выписку
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var mc = db.med_card
                                .Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            CreateExtract(savePath, mc);
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Направить к другому специалисту", (s, se) =>
                    {
                        // Направить к другому специалисту
                        using (Database.Model.Context db = new Database.Model.Context())
                        {

                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить карту
                        using (Database.Model.Context db = new Context())
                        {
                            db.med_card
                            .Remove(db.med_card.Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value));
                            db.SaveChanges();
                        }

                        MessageBox.Show("Карта успешно удалена!");
                        UpdateMedCardsDataGridView();
                    }));
                }

                m.Show(MedCardsDataGridView, new Point(e.X, e.Y));
            }
        }

        private void CreateExtract(string path, med_card mc)
        {
            var doc = DocX.Create(path);

            doc.DifferentFirstPage = true;

            doc.InsertParagraph($"СПРАВКА").Bold().FontSize(32);
            doc.InsertParagraph($"Справка выдана {mc.surname} {mc.name} {mc.middle_name}").FontSize(16);
            doc.InsertParagraph($"Перенес следующие заболевания:\n").FontSize(16);

            using (Database.Model.Context db = new Context())
            {
                var visits = db.istoria_priemov
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .ToList();

                var t = doc.AddTable(visits.Count + 1, 2);
                t.Alignment = Alignment.center;

                t.Rows[0].Cells[0].Paragraphs.First().Append("Диагноз");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Статус");

                for (int i = 0; i < visits.Count; i++)
                {
                    t.Rows[i + 1].Cells[0].Paragraphs.First().Append(visits[i].disease);
                    t.Rows[i + 1].Cells[1].Paragraphs.First().Append(visits[i].status);
                }

                doc.InsertTable(t);

                doc.InsertParagraph($"\n\nЛечащий врач: _________________").FontSize(16);
                doc.InsertParagraph($"\t\t\t(Подпись, дата, Фамилия И.О.)").FontSize(9);
                doc.InsertParagraph($"\t\t\t\tМ.П.").FontSize(9);
            }

            doc.Save();
        }
        private void Amcf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateMedCardsDataGridView();
        }

        private void AddMedCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.AddMedCardForm amcf = new AddMedCardForm();
            amcf.FormClosed += Amcf_FormClosed;
            amcf.ShowDialog();
        }
    }
}
