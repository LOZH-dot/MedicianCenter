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
    public partial class AddMedCardForm : Form
    {
        private med_card medCard = null;
        public AddMedCardForm()
        {
            InitializeComponent();
        }

        public AddMedCardForm(med_card medCard)
        {
            InitializeComponent();
            this.medCard = medCard;
            this.Text = "Изменить медицинскую карту";
            AddMedCardButton.Text = "Изменить";
            FillMedCardInfo();
        }

        private void FillMedCardInfo()
        {
            SurnameTextBox.Text = medCard.surname;
            NameTextBox.Text = medCard.name;
            PatronymicTextBox.Text = medCard.middle_name;

            BirthDateTimePicker.Value = medCard.date_of_birth.Value;
            PhoneMaskedTextBox.Text = medCard.phone_number;
            ProfessionTextBox.Text = medCard.profession;
            SNILSMaskedTextBox.Text = medCard.snils;

            PassportSeriesMaskedTextBox.Text = medCard.seria_passport;
            PassportNumberMaskedTextBox.Text = medCard.number_passport;

            SubjectTextBox.Text = medCard.place_of_residence;
            CityTextBox.Text = medCard.settlenment;
            StreetTextBox.Text = medCard.street;
            HouseTextBox.Text = medCard.number_house.ToString();
            RoomTextBox.Text = medCard.number_room.ToString();
        }

        private void AddMedCardButton_Click(object sender, EventArgs e)
        {
            if (medCard == null)
            {
                med_card nMedCard = new med_card();
                nMedCard.surname = SurnameTextBox.Text;
                nMedCard.name = NameTextBox.Text;
                nMedCard.middle_name = PatronymicTextBox.Text;

                nMedCard.date_of_birth = BirthDateTimePicker.Value;
                nMedCard.phone_number = PhoneMaskedTextBox.Text;
                nMedCard.profession = ProfessionTextBox.Text;
                nMedCard.snils = SNILSMaskedTextBox.Text;

                nMedCard.number_passport = PassportNumberMaskedTextBox.Text;
                nMedCard.seria_passport = PassportSeriesMaskedTextBox.Text;

                nMedCard.place_of_residence = SubjectTextBox.Text;
                nMedCard.settlenment = CityTextBox.Text;
                nMedCard.street = StreetTextBox.Text;
                nMedCard.number_house = int.Parse(HouseTextBox.Text);
                nMedCard.number_room = int.Parse(RoomTextBox.Text);

                using (Database.Model.Context db = new Context())
                {
                    db.med_card.Add(nMedCard);
                    db.SaveChanges();
                }

                MessageBox.Show("Медицинская карта успешно добавлена!");
            }
            else
            {
                using (Database.Model.Context db = new Context())
                {
                    var cMedCard = db.med_card.Find(medCard.ID_med_card);

                    cMedCard.surname = SurnameTextBox.Text;
                    cMedCard.name = NameTextBox.Text;
                    cMedCard.middle_name = PatronymicTextBox.Text;
                    
                    cMedCard.date_of_birth = BirthDateTimePicker.Value;
                    cMedCard.phone_number = PhoneMaskedTextBox.Text;
                    cMedCard.profession = ProfessionTextBox.Text;
                    cMedCard.snils = SNILSMaskedTextBox.Text;
                    
                    cMedCard.number_passport = PassportNumberMaskedTextBox.Text;
                    cMedCard.seria_passport = PassportSeriesMaskedTextBox.Text;
                    
                    cMedCard.place_of_residence = SubjectTextBox.Text;
                    cMedCard.settlenment = CityTextBox.Text;
                    cMedCard.street = StreetTextBox.Text;
                    cMedCard.number_house = int.Parse(HouseTextBox.Text);
                    cMedCard.number_room = int.Parse(RoomTextBox.Text);

                    db.SaveChanges();
                }

                MessageBox.Show("Медицинская карта успешно изменена!");
            }
            this.Close();
        }
    }
}
