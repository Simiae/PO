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
        public VytvorZamestnanceForm()
        {
            InitializeComponent();
        }

        private void pridejZamestnanceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ZamestnanecModel model = new ZamestnanecModel(
                    jmenoTextBox.Text,
                    prijmeniTextBox.Text);

                GlobalConfig.Connection.VytvorZamestnance(model);

                jmenoTextBox.Text = "";
                prijmeniTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Neplatné informace");
            }
        }

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
