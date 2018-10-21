﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StarSystem SystemsInstance;
        bool isSystemCreated = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            NumberOfPlanets.Visible = false;
            StarName.Visible = false;
            AddPlanet.Visible = false;
            PlanetsName.Visible = false;
            PlanetsNameInput.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.PlanetNum());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanetsName.Visible = true;
            StarsNameInput.Visible = true;
            PlanetsNameInput.Visible = true;
            Ok.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemsInstance.StarName());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isSystemCreated)
            {
                if ((StarsNameInput.Text != "") && (SystemsNameInput.Text != ""))
                {
                    string[] a = new string[] { SystemsNameInput.Text, StarsNameInput.Text };
                    SystemsInstance = new StarSystem(a);
                    NumberOfPlanets.Visible = true;
                    StarName.Visible = true;
                    AddPlanet.Visible = true;
                    SystemsName.Visible = false;
                    StarsName.Visible = false;
                    StarsNameInput.Visible = false;
                    SystemsNameInput.Visible = false;
                    Ok.Visible = false;
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
                Ok.Visible = false;
                StarsNameInput.Visible = false;
                PlanetsName.Visible = false;
                PlanetsNameInput.Visible = false;
                StarsNameInput.Clear();
                SystemsNameInput.Clear();
            }
        }
    }
}
