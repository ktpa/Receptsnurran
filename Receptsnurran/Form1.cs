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
using System.Diagnostics;

namespace Receptsnurran
{
    public partial class Receptsnurran : Form
    {
        public Receptsnurran()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBoxLastPrescriptionDate.TextChanged += TextBox_TextChanged;
            textBoxTotalTablets.TextChanged += TextBox_TextChanged;
            textBoxDailyDosage.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculateAndDisplay();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateAndDisplay();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            calculateAndDisplay();
        }

        private string calculate()
        {
            string format = "yyMMdd";
            try
            {
                if (!DateTime.TryParseExact(textBoxLastPrescriptionDate.Text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime lastPrescriptionDate))
                    return "Ogiltigt datum";

                if (!int.TryParse(textBoxTotalTablets.Text, out int totalTablets) || totalTablets <= 0)
                    return "Ogiltigt antal tabletter";

                if (!int.TryParse(textBoxDailyDosage.Text, out int dailyDosage) || dailyDosage <= 0)
                    return "Ogiltig daglig dos";

                int daysMedicationShouldLast = totalTablets / dailyDosage;
                DateTime expectedEndDate = lastPrescriptionDate.AddDays(daysMedicationShouldLast);

                string verb = DateTime.Now > expectedEndDate ? "räckt" : "räcka";

                int daysSincePrescription = (DateTime.Now - lastPrescriptionDate).Days;
                double averageDailyIntake = (double)totalTablets / daysSincePrescription;
                string averageDailyIntakeMessage;
                string averageDailyConsumption = "Genomsnittlig konsumtion om läkemedlet är slut nu:";
                if (Math.Abs(averageDailyIntake - dailyDosage) < 0.05) // Within 0.05 of prescribed dosage
                {
                    averageDailyIntakeMessage = $"{averageDailyConsumption} \n{averageDailyIntake:F2} tabletter per dag";
                }
                else if (averageDailyIntake < dailyDosage)
                {
                    averageDailyIntakeMessage = $"{averageDailyConsumption} \n{averageDailyIntake:F2} tabletter per dag (LÄGRE än ordinerad dos)";
                }
                else
                {
                    averageDailyIntakeMessage = $"{averageDailyConsumption} \n{averageDailyIntake:F2} tabletter per dag (HÖGRE än ordinerad dos)";
                }

                return $"Läkemedlet borde {verb} till: {expectedEndDate.ToShortDateString()} ({daysMedicationShouldLast} dagar)\n\n" +
                       $"{averageDailyIntakeMessage}";
            }
            catch (Exception)
            {
                return "Ogiltig inmatning";
            }
        }

        private void calculateAndDisplay()
        {
            string result = calculate();
            richTextBoxResult.Text = result;
        }

        private void Receptsnurran_Load(object sender, EventArgs e)
        {

        }

        private void itkalle_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/ktpa/Receptsnurran/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Det gick inte att öppna länken: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
