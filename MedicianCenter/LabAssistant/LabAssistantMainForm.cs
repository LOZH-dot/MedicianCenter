using MedicianCenter.Admin;
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

namespace MedicianCenter.LabAssistant
{
    public partial class LabAssistantMainForm : Form
    {
        public LabAssistantMainForm()
        {
            InitializeComponent();
        }

        private void LabAssistantMainForm_Load(object sender, EventArgs e)
        {
            UpdateTestsDataGridView();
        }

        private void UpdateTestsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                TestsDataGridView.DataSource = db.list_tests.ToList();
        }

        private void LabAssistantMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void TestsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = TestsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Добавить результаты", (s, se) =>
                    {
                        // Добавить результаты анализа
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            var test = db.list_tests.Find(TestsDataGridView.Rows[currentMouseOverRow].Cells["ID_list_tests"].Value);
                            AddTestResultForm atrf = new AddTestResultForm(test);
                            atrf.ShowDialog();
                        }
                    }));
                }

                m.Show(TestsDataGridView, new Point(e.X, e.Y));
            }
        }
    }
}
