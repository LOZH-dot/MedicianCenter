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
    public partial class AddTestResultForm : Form
    {
        private list_tests test;
        public AddTestResultForm(list_tests test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void AddTestResultForm_Load(object sender, EventArgs e)
        {
            UpdateTestResultsDataGridView();
        }

        private void UpdateTestResultsDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                TestResultsDataGridView.DataSource = db.TestResult
                    .Where(x => x.TestId == test.ID_list_tests)
                    .ToList();
        }

        private void AddResultButton_Click(object sender, EventArgs e)
        {
            TestResult testResult = new TestResult();
            testResult.Key = KeyTextBox.Text;
            testResult.Value = ValueTextBox.Text;
            testResult.TestId = test.ID_list_tests;

            using (Database.Model.Context db = new Context())
            {
                db.TestResult.Add(testResult);
                db.SaveChanges();
            }

            UpdateTestResultsDataGridView();
        }

        private void TestResultsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = TestResultsDataGridView.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Удалить результат", (s, se) =>
                    {
                        // Удалить результат
                        using (Database.Model.Context db = new Database.Model.Context())
                        {
                            db.TestResult.Remove(db.TestResult.Find(TestResultsDataGridView.Rows[currentMouseOverRow].Cells["id"].Value));
                            db.SaveChangesAsync();
                            UpdateTestResultsDataGridView();
                        }
                    }));
                }

                m.Show(TestResultsDataGridView, new Point(e.X, e.Y));
            }
        }
    }
}
