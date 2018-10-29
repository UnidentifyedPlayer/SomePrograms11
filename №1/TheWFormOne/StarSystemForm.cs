using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace TheWFormOne
{
    public partial class StarSystemForm : Form
    {
        public StarSystemForm()
        {
            InitializeComponent();
        }

        StarSystem SystemsInstance;
        bool isSystemCreated = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            NumberOfPlanetsButton.Visible = false;
            StarNameButton.Visible = false;
            AddPlanetButton.Visible = false;
            PlanetsName.Visible = false;
            PlanetsNameInput.Visible = false;
        }

        private void NumberOfPlanetsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.PlanetNum());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanetsName.Visible = true;
            StarsNameInput.Visible = true;
            PlanetsNameInput.Visible = true;
            OkButton.Visible = true;
        }

        private void StarNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.StarName());
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!isSystemCreated)
            {
                if ((StarsNameInput.Text != "") && (SystemsNameInput.Text != ""))
                {
                    string[] a = new string[] { SystemsNameInput.Text, StarsNameInput.Text };
                    SystemsInstance = new StarSystem(a);
                    NumberOfPlanetsButton.Visible = true;
                    StarNameButton.Visible = true;
                    AddPlanetButton.Visible = true;
                    SystemsName.Visible = false;
                    StarsName.Visible = false;
                    StarsNameInput.Visible = false;
                    SystemsNameInput.Visible = false;
                    OkButton.Visible = false;
                    StarsNameInput.Clear();
                    SystemsNameInput.Clear();
                    isSystemCreated = true;
                }

                else
                {
                    MessageBox.Show("Enter both System's and Star's name");
                }
            }
            else
            {
                SystemsInstance.AddPlanet(StarsNameInput.Text);
                OkButton.Visible = false;
                StarsNameInput.Visible = false;
                PlanetsName.Visible = false;
                PlanetsNameInput.Visible = false;
                StarsNameInput.Clear();
                SystemsNameInput.Clear();
            }
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
            PlanetsName.Visible = true;
            PlanetsNameInput.Visible = true;
            OkButton.Visible = true;
        }
    }
}
