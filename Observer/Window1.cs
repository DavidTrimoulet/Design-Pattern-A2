﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppV1
{
    public partial class Window1 : Form, IObservateur
    {
        public int Temp { get; set; }
        public int Humi { get; set; }
        public int Press { get; set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void afficher()
        {
            label2.Text = Temp.ToString();
            label4.Text = Humi.ToString();
            label6.Text = Press.ToString();
        }

        
        public void actualiser(int temp, int humi, int press) {

            Temp = temp;
            Humi = humi;
            Press = press;

            // Hardcore !
            this.BeginInvoke((MethodInvoker)delegate
            {
                afficher();
            });
        }

    }
}
