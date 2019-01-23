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
            ShowNumberOfPlanetsButton.Visible = false;
            ShowStarNameButton.Visible = false;
            AddPlanetButton.Visible = false;
            InputPlanetsNameLabel.Visible = false;
            PlanetsNameInputBox.Visible = false;
        }

        private void NumberOfPlanetsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.PlanetNum());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputPlanetsNameLabel.Visible = true;
            StarsNameInputBox.Visible = true;
            PlanetsNameInputBox.Visible = true;
            ConfirmChangesButton.Visible = true;
        }

        private void StarNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.StarName());
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!isSystemCreated)
            {
                if ((StarsNameInputBox.Text != "") && (SystemsNameInputBox.Text != ""))
                {
                    string[] a = new string[] { SystemsNameInputBox.Text, StarsNameInputBox.Text };
                    SystemsInstance = new StarSystem(a);
                    ShowNumberOfPlanetsButton.Visible = true;
                    ShowStarNameButton.Visible = true;
                    AddPlanetButton.Visible = true;
                    InputSystemsNameLabel.Visible = false;
                    InputStarsNameLabel.Visible = false;
                    StarsNameInputBox.Visible = false;
                    SystemsNameInputBox.Visible = false;
                    ConfirmChangesButton.Visible = false;
                    StarsNameInputBox.Clear();
                    SystemsNameInputBox.Clear();
                    isSystemCreated = true;
                }

                else
                {
                    MessageBox.Show("Enter both System's and Star's name");
                }
            }
            else
            {
                SystemsInstance.AddPlanet(StarsNameInputBox.Text);
                ConfirmChangesButton.Visible = false;
                StarsNameInputBox.Visible = false;
                InputPlanetsNameLabel.Visible = false;
                PlanetsNameInputBox.Visible = false;
                StarsNameInputBox.Clear();
                SystemsNameInputBox.Clear();
            }
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
            InputPlanetsNameLabel.Visible = true;
            PlanetsNameInputBox.Visible = true;
            ConfirmChangesButton.Visible = true;
        }
    }
}
