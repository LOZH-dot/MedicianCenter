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

namespace MedicianCenter.Admin
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            UpdateDoctorsDataGridView();
            UpdatePillsDataGridView();
            UpdateMedCardsDataGridView();
        }

        private async void UpdateDoctorsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
            {
                DoctorsDataGridView.DataSource = await db.doctor.Include(x => x.istoria_priemov).ToListAsync();
            }
            
        }

        private async void UpdatePillsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                PillsDataGridView.DataSource = await db.list_pills.Include(x => x.healing_list_pills).Include(x => x.list_pills_list_tests).ToListAsync();
        }

        private async void UpdateMedCardsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                MedCardsDataGridView.DataSource = await db.med_card.Include(x => x.med_card_contra).Include(x => x.istoria_priemov).ToListAsync();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        // Добавить доктора
        private void AddDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.AddDoctorForm adf = new Admin.AddDoctorForm();
            adf.FormClosed += Adf_FormClosed;
            adf.ShowDialog();
        }

        // Добавить препарат
        private void PillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPillForm apf = new AddPillForm();
            apf.FormClosed += Apf_FormClosed;
            apf.ShowDialog();
        }

        // Добавить мед. карту
        private void MedCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedCardForm amcf = new AddMedCardForm();
            amcf.FormClosed += Amcf_FormClosed;
            amcf.ShowDialog();
        }

        // Контекстное меню для таблицы докторов
        private void DoctorsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = DoctorsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить доктора
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            doctor cDoc = db.doctor.Find(DoctorsDataGridView.Rows[currentMouseOverRow].Cells["ID_doctor"].Value);
                            AddDoctorForm adf = new AddDoctorForm(cDoc);
                            adf.FormClosed += Adf_FormClosed;
                            adf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) => 
                    {
                        // Удалить доктора
                        using (Database.Model.Context db = new Context())
                        {
                            var rDoc = db.doctor.Find(DoctorsDataGridView.Rows[currentMouseOverRow].Cells["ID_doctor"].Value);
                            db.doctor.Remove(rDoc);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Доктор успешно удален!");
                        UpdateDoctorsDataGridView();
                    }));
                }

                m.Show(DoctorsDataGridView, new Point(e.X, e.Y));
            }
        }

        // Контекстное меню для таблицы препаратов
        private void PillsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = PillsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Изменить", (s, se) =>
                    {
                        // Изменить препарат
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            list_pills cPill = db.list_pills.Find(PillsDataGridView.Rows[currentMouseOverRow].Cells["ID_list_pills"].Value);
                            AddPillForm apf = new AddPillForm(cPill);
                            apf.FormClosed += Apf_FormClosed;
                            apf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить препарат
                        using (Database.Model.Context db = new Context())
                        {
                            var rPill = db.list_pills.Find(PillsDataGridView.Rows[currentMouseOverRow].Cells["ID_list_pills"].Value);
                            db.list_pills.Remove(rPill);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Препарат успешно удален!");
                        UpdatePillsDataGridView();
                    }));
                }

                m.Show(PillsDataGridView, new Point(e.X, e.Y));
            }
        }

        // Контекстное меню для таблицы мед. карт
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
                        // Изменить мед. карту
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            med_card cMedCard = db.med_card.Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            AddMedCardForm amcf = new AddMedCardForm(cMedCard);
                            amcf.FormClosed += Amcf_FormClosed;
                            amcf.ShowDialog();
                        }
                    }));
                    m.MenuItems.Add(new MenuItem("Удалить", (s, se) =>
                    {
                        // Удалить мед. карту
                        using (Database.Model.Context db = new Context())
                        {
                            var rMedCard = db.med_card.Find(MedCardsDataGridView.Rows[currentMouseOverRow].Cells["ID_med_card"].Value);
                            db.med_card.Remove(rMedCard);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Медицинская карта успешно удалена!");
                        UpdateMedCardsDataGridView();
                    }));
                }

                m.Show(MedCardsDataGridView, new Point(e.X, e.Y));
            }
        }

        // Закрытие формы добавления мед. карты
        private void Amcf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateMedCardsDataGridView();
        }


        // Закрытие формы добавления препарата
        private void Apf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePillsDataGridView();
        }

        // Закрытие формы добавления доктора
        private void Adf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateDoctorsDataGridView();
        }
    }
}
