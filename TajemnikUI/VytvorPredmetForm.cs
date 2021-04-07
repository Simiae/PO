using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tajemnik;
using Tajemnik.Modely;

namespace TajemnikUI
{
    public partial class VytvorPredmetForm : Form
    {
        private List<PredmetModel> dostupnePredmety = GlobalConfig.Connection.GetPredmet_All();
        public VytvorPredmetForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            predmetyListBox.DataSource = null;
            predmetyListBox.DataSource = GlobalConfig.Connection.GetPredmet_All(); // = dostupnePredmety; se znovu nenacte
            predmetyListBox.DisplayMember = "Zkratka";
        }

        private void VytvorPredmetForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pridejPredmetButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PredmetModel model = new PredmetModel();
                model.Zkratka = zkratkaTextBox.Text;
                model.PocetTydnu = int.Parse(pocetTydnuTextBox.Text);
                model.HodinyPrednasek = int.Parse(hodinyPrednasekTextBox.Text);
                model.HodinyCviceni = int.Parse(hodinyCviceniTextBox.Text);
                model.HodinySeminaru = int.Parse(hodinySeminaruTextbox.Text);
                model.ZpusobZakonceni = zpusobUkonceniCheckedListBox.Text;
                model.Jazyk = jazykCheckedListBox.Text;
                model.VelikostTridy = int.Parse(velikostTridyTextBox.Text);

                GlobalConfig.Connection.VytvorPredmet(model);

                WireUpLists();

                zkratkaTextBox.Text = "";
                pocetTydnuLabel.Text = "";
                hodinyPrednasekTextBox.Text = "";
                hodinyCviceniTextBox.Text = "";
                hodinySeminaruTextbox.Text = "";
                zpusobUkonceniCheckedListBox.Items.Clear();
                jazykCheckedListBox.Items.Clear();
                velikostTridyTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Neplatné informace");
            }
        }
        // TODO - validace ostatních polí
        private bool ValidateForm()
        {
            bool output = true;

            if (zkratkaTextBox.Text.Length == 0)
            {
                output = false;
            }



            return output;
        }
    }
}
