using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusesProject
{
    public partial class BusForm : Form
    {
        bool BusPlacementMode = false;
        World world;
        public BusForm()
        {
            InitializeComponent();
            world = new World(pictureBox1.Size);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Worldtimer.Start();
            world.BeginTheWorld();
            //Drawer.DrawBus(ref g, new Point(230, 170), 40);
        }

        private void addbusbutton_Click(object sender, EventArgs e)
        {
            BusPlacementMode = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (BusPlacementMode)
            {
                textBox1.Text += world.AddBus(e.Location);
                Graphics g = pictureBox1.CreateGraphics();
                world.DrawWorld(g);
            }
        }

        private void Worldtimer_Tick(object sender, EventArgs e)
        {
            
            Graphics g = pictureBox1.CreateGraphics();
            world.DrawWorld(g);
        }
    }
}
