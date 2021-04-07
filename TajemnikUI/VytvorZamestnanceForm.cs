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
    public partial class VytvorZamestnanceForm : Form
    {
        private List<ZamestnanecModel> dostupniZamestnanci = GlobalConfig.Connection.GetZamestnanec_All();
        public VytvorZamestnanceForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            zamestnanciListBox.DataSource = null;
            zamestnanciListBox.DataSource = GlobalConfig.Connection.GetZamestnanec_All(); ;  // = dostupniZamestnanci; se nerefreshne
            zamestnanciListBox.DisplayMember = "CeleJmeno";
        }
        private void pridejZamestnanceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ZamestnanecModel model = new ZamestnanecModel();
                model.Jmeno = jmenoTextBox.Text;
                model.Prijmeni = prijmeniTextBox.Text;
                model.PracovniEmail = pracovniEmailTextBox.Text;
                model.SoukromyEmail = soukromyEmailTextBox.Text;
                model.Doktorand = doktorandCheckBox.Checked;
                model.Uvazek = double.Parse(uvazekTextBox.Text);
                model.PracovniTelefon = pracovniTelefonTextBox.Text;
                model.SoukromyTelefon = soukromyTelefonTextBox.Text;

                GlobalConfig.Connection.VytvorZamestnance(model);

                WireUpLists();

                jmenoTextBox.Text = "";
                prijmeniTextBox.Text = "";
                pracovniEmailTextBox.Text = "";
                soukromyEmailTextBox.Text = "";
                doktorandCheckBox.Checked = false;
                uvazekTextBox.Text = "0";
                pracovniTelefonTextBox.Text = "";
                soukromyTelefonTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Neplatné informace");
            }
        }
        // TODO - mazani zamestnance

        // TODO - validace ostatních polí
        private bool ValidateForm()
        {
            bool output = true;
            
            if (jmenoTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (prijmeniTextBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
