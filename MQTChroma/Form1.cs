﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Corale.Colore.Core;
using Corale.Colore.WinForms;
using Corale.Colore.Razer.ChromaLink;
using Corale.Colore.Razer.Keyboard;
using Corale.Colore.Razer.Keypad;
using Corale.Colore.Razer.Mouse;
using Corale.Colore.Razer.Mousepad;
using ColoreColor = Corale.Colore.Core.Color;

namespace MQTChroma
{
    public partial class MQTChroma : Form
    {
        public MQTChroma()
        {
            InitializeComponent();
            Chroma.Instance.Initialize();
        }
        public void RazerSet(int R, int G, int B) {
            var color = new ColoreColor((byte)R, (byte)G, (byte)B);
            Chroma.Instance.SetAll(color);
            Chroma.Instance.ChromaLink.SetAll(color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RazerSet(Convert.ToInt32(Color_R.Value), Convert.ToInt32(Color_G.Value), Convert.ToInt32(Color_B.Value));
        }
    }
}