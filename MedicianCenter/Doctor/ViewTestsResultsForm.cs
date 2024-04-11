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

namespace MedicianCenter.Doctor
{
    public partial class ViewTestsResultsForm : Form
    {
        private med_card mc;
        public ViewTestsResultsForm(med_card mc)
        {
            InitializeComponent();
            this.mc = mc;
        }

        private void ViewTestsResultsForm_Load(object sender, EventArgs e)
        {
            UpdateTestsComboBox();
            PatientNameTextBox.Text = $"{mc.surname} {mc.name} {mc.middle_name}";
        }

        private void UpdateTestsComboBox()
        {
            using (Database.Model.Context db = new Context())
            {
                var tests =
                    db.list_tests
                    .Where(x => x.ID_med_card == mc.ID_med_card)
                    .ToList();

                TestsComboBox.DataSource = tests;
                TestsComboBox.DisplayMember = "name";
                TestsComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateResultsComboBox(list_tests test)
        {
            using (Database.Model.Context db = new Context())
            {
                var results =
                    db.TestResult
                    .Where(x => x.TestId == test.ID_list_tests)
                    .ToList();

                ResultsDataGridView.DataSource = results;
            }
        }

        private void TestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultsComboBox(TestsComboBox.SelectedItem as list_tests);
        }
    }
}
