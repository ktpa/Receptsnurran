using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Receptsnurran
{
    public partial class Receptsnurran : Form
    {
        public Receptsnurran()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBoxLastPrescriptionDate.KeyDown += TextBox_KeyDown;
            textBoxTotalTablets.KeyDown += TextBox_KeyDown;
            textBoxDailyDosage.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate();
                e.Handled = true; // Prevents the 'ding' sound
                e.SuppressKeyPress = true; // Suppresses the Enter key press
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            string format = "yyMMdd";
            try
            {
                DateTime lastPrescriptionDate = DateTime.ParseExact(textBoxLastPrescriptionDate.Text, format, CultureInfo.InvariantCulture);
                int totalTablets = int.Parse(textBoxTotalTablets.Text);
                int dailyDosage = int.Parse(textBoxDailyDosage.Text);

                // Beräkna hur länge läkemedlet borde räcka
                int daysMedicationShouldLast = totalTablets / dailyDosage;
                DateTime expectedEndDate = lastPrescriptionDate.AddDays(daysMedicationShouldLast);

                // Determine whether to use "räcka" or "räckt"
                string verb = DateTime.Now > expectedEndDate ? "räckt" : "räcka";

                // Beräkna hur många tabletter patienten tagit per dag i genomsnitt om läkemedlet är slut nu
                int daysSincePrescription = (DateTime.Now - lastPrescriptionDate).Days;
                double averageDailyIntake = (double)totalTablets / daysSincePrescription;

                string result = $"Läkemedlet borde {verb} till: {expectedEndDate.ToShortDateString()} ({daysMedicationShouldLast} dagar)\n\n" +
                                $"Genomsnittlig daglig konsumtion om läkemedlet är slut nu: \n{averageDailyIntake:F2} tabletter per dag";

                MessageBox.Show(result, "Resultat");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel vid bearbetning av inmatning:\n" + ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Receptsnurran_Load(object sender, EventArgs e)
        {

        }
    }
}
