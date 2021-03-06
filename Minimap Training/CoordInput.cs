﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minimap_Training
{
    public partial class CoordInput : Form
    {
        bool clicked = false; 

        public CoordInput()
        {
            InitializeComponent();
        }

        private void CoordInput_Load(object sender, EventArgs e) //loaded in the first few lines of Program.cs in the main method
        {
            DesktopLocation = new Point(0, 0);
            Size = new Size(12000, 12000); //covers the whole screen so you can click anywhere and have the program register 
        }                                  //which coords you clicked on

        private void CoordInput_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y; //the coordinates that the user clicked on
            if (clicked == false) //the user is prompted to click twice, once for the top left of minimap, once for the bottom right
            {                     //the if statement ensures this is handled properly
                Properties.Settings.Default.x1 = x;
                Properties.Settings.Default.y1 = y;
                Console.WriteLine("x1: " + x.ToString() + " y1: " + y.ToString());
                Console.WriteLine("Please click on the bottom right of your minimap");
                clicked = true;
            }
            else
            {
                Properties.Settings.Default.x2 = x;
                Properties.Settings.Default.y2 = y;
                Console.WriteLine("x2: " + x.ToString() + " y2: " + y.ToString());
                Close();
            }
        }
    }
}
